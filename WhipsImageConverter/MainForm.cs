using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.Net.Http;
using System.Net;
using System.Drawing.Drawing2D;

/*
Color3 method adapted from user dacwe on StackExchange
Without using a custom color class, the clamping of Color will distort the colors
https://stackoverflow.com/questions/5940188/how-to-convert-a-24-bit-png-to-3-bit-png-using-floyd-steinberg-dithering

Dithering methods found from:
https://en.wikipedia.org/wiki/Floyd%E2%80%93Steinberg_dithering
http://www.tannerhelland.com/4660/dithering-eleven-algorithms-source-code/
http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
*/

namespace WhipsImageConverter
{
    public partial class MainForm : Form
    {
        const string myVersionString = "1.2.3.0";
        const string buildDateString = "05/14/20";
        const string githubVersionUrl = "https://github.com/Whiplash141/Whips-Image-Converter/releases/latest";

        #region Member fields
        string formTitle = $"Whip's Image Converter (Version {myVersionString} - {buildDateString})";
        string fileDirectory = "";

        Bitmap baseImage;
        Bitmap convertedImage;
        Bitmap desiredImage;
        Bitmap imageOriginalAspect;
        Bitmap imageStretched;

        bool imageLoaded = false;

        int[,] convertedColorArray = null;
        int imageWidth = 0;
        int imageHeight = 0;

        List<Color3> paletteColors = new List<Color3>();

        ImageLoadProgressForm progressBarForm = new ImageLoadProgressForm();

        Dictionary<int, Color3> paletteColorDictionary = new Dictionary<int, Color3>(512);

        Color backgroundColor = Color.FromArgb(0, 0, 0);
        int backgroundColorPacked = (255 << 24);

        const double bitSpacing = 255.0 / 7.0;

        const char transparencyFake = '#';

        string spacer = "" + '\uE075' + '\uE072' + '\uE070';
        string spacer2 = "" + '\ue076' + '\ue073' + '\ue071';
        string spacer4 = "" + '\ue076' + '\ue076' + '\ue074' + '\ue072';
        string spacer8 = "" + '\ue078' + '\ue075' + '\ue073';
        string spacer178 = new string('\ue078', 25) + '\ue077' + '\ue075' + '\ue074' + '\ue073' + '\ue071';

        string trans = transparencyFake.ToString();
        string trans2 = new string(transparencyFake, 2);
        string trans4 = new string(transparencyFake, 4);
        string trans8 = new string(transparencyFake, 8);
        string trans178 = new string(transparencyFake, 178);
        StringBuilder sb = new StringBuilder();

        const float PIXELS_TO_CHARACTERS =  1f / 2.88f;

        readonly List<string> blockNames = new List<string>();
        readonly List<string> surfaceNames = new List<string>();

        Vector2 screenSizeChars;

        #endregion

        public MainForm()
        {
            InitializeComponent();
            comboBoxDither.SelectedIndex = 0;
            comboBoxBlock.SelectedIndex = 0;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            CheckBackgroundColorEnabled();

            // Set form name
            this.Text = formTitle;

            // Check for any new updates
            StartUpdateBackgroundWorker();

            // Construct colormap
            ConstructColorMap();

            PopulateComboBoxes();
        }

        void PopulateComboBoxes()
        {
            foreach (var tsp in TextSurfaceProvider.TextSurfaceProviders)
            {
                blockNames.Add(tsp.BlockName);
            }

            blockNames.Add("(Custom)");
            blockNames.Add("(None)");

            comboBoxBlock.DataSource = blockNames;
            comboBoxBlock.SelectedIndex = 0;
            SelectTextSurfaceTypeComboBoxes(0);
        }

        void SelectTextSurfaceTypeComboBoxes(int index)
        {
            comboBoxSurface.Items.Clear();

            if (index < TextSurfaceProvider.TextSurfaceProviders.Count)
            {
                foreach (var surf in TextSurfaceProvider.TextSurfaceProviders[index].TextSurfaces)
                {
                    comboBoxSurface.Items.Add(surf.SurfaceName);
                }
            }
            else
            {
                comboBoxSurface.Items.Add("N/A");
            }

            comboBoxSurface.SelectedIndex = 0;
        }

        void OnMainFormPaint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rectangle = new Rectangle(0, 0, this.Width, this.Height);
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(80, 0, 0), 45f);
            graphics.FillRectangle(b, gradient_rectangle);
        }

        #region Update Checking
        void StartUpdateBackgroundWorker()
        {
            if (!backgroundWorkerUpdate.IsBusy)
            {
                backgroundWorkerUpdate.RunWorkerAsync();
            }
        }

        private void OnBackgroundWorkerUpdateDoWork(object sender, DoWorkEventArgs e)
        {
            CheckForUpdates();
        }

        void CheckForUpdates()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(githubVersionUrl);
            webRequest.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            webRequest.AllowAutoRedirect = true;
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            var latestVersionUrl = webResponse.ResponseUri.ToString();
            var urlSplit = latestVersionUrl.Split('/');
            if (urlSplit.Length < 1)
                return;
            var latestVersionString = urlSplit[urlSplit.Length - 1];
            latestVersionString = latestVersionString.ToLower().Replace("v", "");

            Version latestVersion = new Version();
            if (!Version.TryParse(latestVersionString, out latestVersion))
                return;

            Version myVersion = new Version();
            if (!Version.TryParse(myVersionString, out myVersion))
                return;

            if (latestVersion > myVersion)
            {
                var confirmResult = MessageBox.Show($"Old version detected. Update to newest version?\nYour version: {myVersionString}\nLatest release: {latestVersionString}",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (confirmResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(githubVersionUrl);
                    this.Close();
                }
            }
        }
        #endregion

        void ConstructColorMap()
        {
            //allowedColors.Clear();
            paletteColors.Clear();
            for (int r = 0; r <= 7; r++)
            {
                for (int g = 0; g <= 7; g++)
                {
                    for (int b = 0; b <= 7; b++)
                    {
                        //allowedColors.Add(Color.FromArgb(ClampColor(r * 37), ClampColor(g * 37), ClampColor(b * 37)));
                        var thisColor = new Color3(ClampColor((int)Math.Round(r * bitSpacing)), ClampColor((int)Math.Round(g * bitSpacing)), ClampColor((int)Math.Round(b * bitSpacing)));
                        paletteColors.Add(thisColor);
                        paletteColorDictionary.Add(thisColor.Packed, thisColor);
                    }
                }
            }
        }

        void ResetPaletteDictionary()
        {
            paletteColorDictionary.Clear();
            foreach (var thisColor in paletteColors)
            {
                paletteColorDictionary.Add(thisColor.Packed, thisColor);
            }
        }

        void LoadImage()
        {
            //Check if file exists
            fileDirectory = textBox_FileDirectory.Text;

            if (!File.Exists(fileDirectory))
            {
                MessageBox.Show("Error! Filepath is invalid");
                imageLoaded = false;
                return;
            }

            //Check if valid file type
            if (!(fileDirectory.ToLower().EndsWith(".png") || fileDirectory.ToLower().EndsWith(".jpg") || fileDirectory.EndsWith(".jpeg") || fileDirectory.EndsWith(".bmp")))
            {
                MessageBox.Show("Error! File must be a png or jpg or bmp image");
                return;
            }

            // Does not keep a file handle that is disposed at an indeterminate time
            baseImage = (Bitmap)Image.FromStream(new MemoryStream(File.ReadAllBytes(fileDirectory)));
            if (comboBoxBlock.SelectedIndex == blockNames.Count - 1)
            {
                numericUpDownWidth.Value = baseImage.Width;
                numericUpDownHeight.Value = baseImage.Height;
            }
            imageLoaded = true;
        }

        void BuildBitmaps()
        {
            if (!imageLoaded)
                return;

            imageStretched = new Bitmap(baseImage, (int)screenSizeChars.X, (int)screenSizeChars.Y);
            imageOriginalAspect = FrameImage(baseImage, (int)screenSizeChars.X, (int)screenSizeChars.Y);
        }

        Bitmap FrameImage(Bitmap baseImage, int width, int height)
        {
            Bitmap framedImage = new Bitmap(width, height);
            int borderThickness = 0;
            float compressionRatio = 1;
            int borderMode = 0; //0 = none; 1 = horizontal; 2 = vertical bars
            int desiredWidth = 0;
            int desiredHeight = 0;

            //Change background color of the image
            //method from https://stackoverflow.com/a/1720261
            var thisColor = backgroundColor;
            if (checkBoxTransparency.Checked)
                thisColor = Color.FromArgb(0, backgroundColor.R, backgroundColor.G, backgroundColor.B);

            using (Graphics gfx = Graphics.FromImage(framedImage))
            using (SolidBrush brush = new SolidBrush(thisColor))
            {
                gfx.FillRectangle(brush, 0, 0, width, height);
            }

            if ((float)baseImage.Width / width > (float)baseImage.Height / height) //horizontal bars
            {
                desiredWidth = width;
                compressionRatio = (float)width / baseImage.Width;
                desiredHeight = (int)(baseImage.Height * compressionRatio);

                borderThickness = Math.Abs(desiredHeight - height) / 2;
                borderMode = 1;
            }
            else if ((float)baseImage.Width / width == (float)baseImage.Height / height)
            {
                borderMode = 0;
                desiredWidth = width;
                desiredHeight = height;
            }
            else //vertical bars
            {
                desiredHeight = height;
                compressionRatio = (float)height / baseImage.Height;
                desiredWidth = (int)(baseImage.Width * compressionRatio);

                borderThickness = Math.Abs(desiredWidth - width) / 2;
                borderMode = 2;
            }

            if (borderThickness == 0)
            {
                borderMode = 0;
            }

            Bitmap imageNoBorder = new Bitmap(baseImage, new Size(desiredWidth, desiredHeight));

            switch (borderMode)
            {
                case 0:
                    framedImage = imageNoBorder;
                    break;

                case 1: // horizontal bars

                    for (int w = 0; w < width; w++)
                    {
                        for (int h = 0; h < height; h++)
                        {
                            if (h - borderThickness < imageNoBorder.Height && h >= borderThickness)
                                framedImage.SetPixel(w, h, imageNoBorder.GetPixel(w, h - borderThickness));
                        }
                    }

                    break;

                case 2: //vertical bars

                    for (int h = 0; h < height; h++)
                    {
                        for (int w = 0; w < width; w++)
                        {
                            if (w - borderThickness < imageNoBorder.Width && w >= borderThickness)
                                framedImage.SetPixel(w, h, imageNoBorder.GetPixel(w - borderThickness, h));
                        }
                    }

                    break;
            }

            return framedImage;
        }

        void DitherImage()
        {
            if (!imageLoaded)
            {
                return;
            }

            label_stringLength.Text = "String Length: 0";
            textBox_Return.Clear();

            if (checkBox_aspectratio.Checked)
                desiredImage = imageOriginalAspect;
            else
                desiredImage = imageStretched;

            //Get image dimensions
            imageWidth = desiredImage.Width;
            imageHeight = desiredImage.Height;

            //Initialize empty color array
            //convertedColorArray = new Color[imageHeight, imageWidth];
            convertedColorArray = new int[imageHeight, imageWidth];

            //Get dithering type
            int type = comboBoxDither.SelectedIndex;

            //Assign color array based on dithering options
            StartDitheringBackgroundWorker(type);
        }

        public int GetPercentCompletion(int maxRows, int maxColumns, int currentRow, int currentColumn)
        {
            int maximumValue = maxRows * maxColumns;
            int currentValue = currentRow * maxColumns + (currentColumn + 1);
            return (int)((float)currentValue / maximumValue * 100f);
        }

        void ConvertImage()
        {
            if (!imageLoaded)
            {
                MessageBox.Show("Error: No image loaded");
                return;
            }

            //Create encoded string
            string convertedImageString = BuildFinalString(convertedColorArray, imageWidth, imageHeight);

            if (checkBoxTransparency.Checked)
            {
                convertedImageString = convertedImageString.Replace(trans178, spacer178);
                convertedImageString = convertedImageString.Replace(trans8, spacer8);
                convertedImageString = convertedImageString.Replace(trans4, spacer4);
                convertedImageString = convertedImageString.Replace(trans2, spacer2);
                convertedImageString = convertedImageString.Replace(trans, spacer);
            }
            else
            {
                convertedImageString = convertedImageString.Replace(transparencyFake, '\ue100');
            }

            //Display converted image and encoded string
            textBox_Return.Text = convertedImageString;

            label_stringLength.Text = $"String Length: {textBox_Return.Text.Length}";
            //MessageBox.Show("Image Converted"); //successful conversion
        }

        public Color3 ColorToColor3(Color regularColor)
        {
            return new Color3(regularColor.R, regularColor.G, regularColor.B, regularColor.A);
        }

        int[,] GetDitherFilter(int type)
        {
            int[,] ditherFilter = new int[1,1];
            switch (type)
            {
                case 1: //Floyd Steinberg
                    ditherFilter = new int [,]
                    {
                        { 7,0,1 },
                        { 1,1,1 },
                        { 5,1,0 },
                        { 3,1,-1 }
                    };
                    break;
                case 2: //Ju-Ji-Ni
                    ditherFilter = new int[,]
                    {
                        { 7,0,1 },
                        { 5,0,2 },
                        { 3,1,-2 },
                        { 5,1,-1 },
                        { 7,1,0 },
                        { 5,1,1 },
                        { 3,1,2 },
                        { 1,2,-2 },
                        { 3,2,-1 },
                        { 5,2,0 },
                        { 3,2,1 },
                        { 1,2,2 }
                    };
                    break;
                case 3: //Stucci
                    ditherFilter = new int[,]
                    {
                        { 8,0,1 },
                        { 4,0,2 },
                        { 2,1,-2 },
                        { 4,1,-1 },
                        { 8,1,0 },
                        { 4,1,1 },
                        { 2,1,2 },
                        { 1,2,-2 },
                        { 2,2,-1 },
                        { 4,2,0 },
                        { 2,2,1 },
                        { 1,2,2 }
                    };
                    break;
                case 4: //Sierra 3
                    ditherFilter = new int[,]
                    {
                        { 5,0,1 },
                        { 3,0,2 },
                        { 2,1,-2 },
                        { 4,1,-1 },
                        { 5,1,0 },
                        { 4,1,1 },
                        { 2,1,2 },
                        { 2,2,-1 },
                        { 3,2,0 },
                        { 2,2,1 }
                    };
                    break;
                case 5: //Sierra 2
                    ditherFilter = new int[,]
                    {
                        { 4,0,1 },
                        { 3,0,2 },
                        { 1,1,-2 },
                        { 2,1,-1 },
                        { 3,1,0 },
                        { 2,1,1 },
                        { 1,1,2 }
                    };
                    break;
                case 6: //Sierra Lite
                    ditherFilter = new int[,]
                    {
                        { 2,0,1 },
                        { 1,1,-1 },
                        { 1,1,0 }
                    };
                    break;
            }
            return ditherFilter;
        }

        int GetFilterDivisor(int[,] filterArray)
        {
            int divisor = 0;

            for (int row = 0; row < filterArray.GetLength(0); row++)
            {
                divisor += filterArray[row, 0];
            }

            return divisor;
        }

        bool IsIndexAllowed(int indexRow, int indexColumn, int width, int height)
        {
            return (indexRow < height && indexRow >= 0 && indexColumn < width && indexColumn >= 0);
        }

        int[,] Dithering(Bitmap image, int width, int height, int type)
        {
            var filterArray = GetDitherFilter(type);

            Color3[,] initialColorArray = new Color3[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    initialColorArray[row, col] = ColorToColor3(image.GetPixel(col, row));
                }
            }

            int[,] convertedColorArray = new int[height, width];

            int divisor = GetFilterDivisor(filterArray);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    var oldColor = initialColorArray[row, col];
                    var newColor = GetClosestColorFast(oldColor);
                    var error = oldColor - newColor;

                    if (oldColor.A < 36)
                    {
                        if (checkBoxTransparency.Checked)
                            convertedColorArray[row, col] = -141;
                        else
                            convertedColorArray[row, col] = backgroundColorPacked;

                        error = new Color3(0, 0, 0, 0);
                    }
                    else
                        convertedColorArray[row, col] = newColor.Packed;

                    for (int i = 0; i < filterArray.GetLength(0); i++) //iterate through each row
                    {
                        int factor = filterArray[i, 0]; //factor
                        int rowIndex = filterArray[i, 1] + row; //adjusted row
                        int colIndex = filterArray[i, 2] + col; //adjusted column

                        #region debugger
                        //debug.AppendLine(IsIndexAllowed(rowIndex, colIndex, filterArray).ToString());
                        #endregion

                        if (IsIndexAllowed(rowIndex, colIndex, width, height))
                            initialColorArray[rowIndex, colIndex] = initialColorArray[rowIndex, colIndex] + error * ((float)factor / divisor);
                        else
                            continue;
                    }

                    if (progressBarForm.DialogResult != DialogResult.Abort)
                        backgroundWorkerDithering.ReportProgress(GetPercentCompletion(height, width, row, col));
                }
            }

            return convertedColorArray;
        }

        int[,] NoDithering(Bitmap image, int width, int height)
        {
            Color3[,] initialColorArray = new Color3[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    initialColorArray[row, col] = ColorToColor3(image.GetPixel(col, row));
                }
            }

            int[,] convertedColorArray = new int[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    var pixelColor = initialColorArray[row, col];
                    if (pixelColor.A < 36) //and check rgb too
                    {
                        if (checkBoxTransparency.Checked)
                            convertedColorArray[row, col] = -141;
                        else
                            convertedColorArray[row, col] = backgroundColorPacked;
                    }
                    else
                        convertedColorArray[row, col] = GetClosestColorFast(pixelColor).Packed;

                    if (progressBarForm.DialogResult != DialogResult.Abort)
                        backgroundWorkerDithering.ReportProgress(GetPercentCompletion(height, width, row, col));
                }
            }

            return convertedColorArray;
        }

        int ClampColor(int value)
        {
            int clampedValue = value;

            if (clampedValue > 255)
            {
                clampedValue = 255;
            }
            else if (clampedValue < 0)
            {
                clampedValue = 0;
            }

            return clampedValue;
        }

        Color3 GetClosestColorFast(Color3 pixelColor)
        {
            Color3 paletteColor = new Color3(0, 0, 0);

            if (!paletteColorDictionary.TryGetValue(pixelColor.Packed, out paletteColor))
            {
                paletteColor = GetClosestColor(pixelColor);
                //paletteColorDictionary.Add(pixelColor.Packed, paletteColor);
            }

            return paletteColor;
        }

        Color3 GetClosestColor(Color3 pixelColor)
        {
            int R, G, B;
            R = (int)(Math.Round(pixelColor.R / bitSpacing) * bitSpacing);
            G = (int)(Math.Round(pixelColor.G / bitSpacing) * bitSpacing);
            B = (int)(Math.Round(pixelColor.B / bitSpacing) * bitSpacing);

            return new Color3(R, G, B);
        }

        char ColorToChar(byte r, byte g, byte b)
        {
            return (char)(0xe100 + ((int)Math.Round(r / bitSpacing) << 6) + ((int)Math.Round(g / bitSpacing) << 3) + (int)Math.Round(b / bitSpacing));
        }

        string BuildFinalString(int[,] colorArray, int width, int height)
        {
            sb.Clear();
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    var thisColor = colorArray[row, col];
                    char colorChar;
                    if (thisColor == -141)
                        colorChar = transparencyFake;
                    else
                        colorChar = ColorToChar((byte)(thisColor >> 16), (byte)(thisColor >> 8), (byte)thisColor);
                    sb.Append(colorChar);
                }

                if (row + 1 < height)
                    sb.Append("\n");
            }

            sb.Append($"WIC v{myVersionString} - Dither mode: {comboBoxDither.SelectedItem} - {imageWidth}x{imageHeight} px");
            return sb.ToString();
        }

        Bitmap ArrayToBmp(int[,] colorArray, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    bmp.SetPixel(col, row, IntToColor(colorArray[row, col])); //i think this should work because of how bmp is traversed
                }
            }

            return bmp;
        }

        Color IntToColor(int integer)
        {
            if (integer == -141)
            {
                return Color.Transparent;
                //backgroundColor
            }

            return Color.FromArgb(integer);
        }

        #region Image Dithering
        void StartDitheringBackgroundWorker(int type)
        {
            this.Enabled = false;

            if (!backgroundWorkerDithering.IsBusy)
                backgroundWorkerDithering.RunWorkerAsync(type);

            progressBarForm = new ImageLoadProgressForm();
            progressBarForm.FormClosed += ImageLoadProgressBarClosed;
            progressBarForm.ShowDialog();
        }

        private void OnBackgroundWorkerDitheringDoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorkerDithering.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            if ((int)e.Argument == 0) //no dithering
            {
                convertedColorArray = NoDithering(desiredImage, imageWidth, imageHeight);
            }
            else //dithering
            {
                convertedColorArray = Dithering(desiredImage, imageWidth, imageHeight, (int)e.Argument);
            }
        }

        private void OnBackgroundWorkerDitheringProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarForm.SetProgressBarValue(e.ProgressPercentage);
        }

        private void OnBackgroundWorkerDitheringRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarForm.Close();
            this.Enabled = true;
            convertedImage = ArrayToBmp(convertedColorArray, imageWidth, imageHeight);
            ImagePreviewBox.Image = convertedImage;
            //ResetPaletteDictionary();
        }
        #endregion

        #region Image Invert
        void StartInvertBackgroundWorker()
        {
            if (baseImage == null)
                return;

            this.Enabled = false;

            if (!backgroundWorkerInvert.IsBusy)
                backgroundWorkerInvert.RunWorkerAsync();
        }

        private void OnBackgroundWorkerInvertDoWork(object sender, DoWorkEventArgs e)
        {
            InvertImageColors();
        }

        private void OnBackgroundWorkerInvertRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BuildBitmaps(); //cache images
            DitherImage(); //image dithering
        }
        #endregion

        #region Event Driven Actions
        void RotateImage(bool clockwise)
        {
            if (baseImage == null)
                return;

            if (clockwise)
            {
                baseImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            else
            {
                baseImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }

            BuildBitmaps(); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        void InvertImageColors()
        {
            for (int i = 0; i < baseImage.Height; i++)
            {
                for (int j = 0; j < baseImage.Width; j++)
                {
                    var pixel = ColorToColor3(baseImage.GetPixel(j, i));
                    var invertedPixel = new Color3(255, 255, 255) - pixel;
                    baseImage.SetPixel(j, i, invertedPixel.ToColor());
                }
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Show the dialog.
        }

        private void OnButtonClipboardClick(object sender, EventArgs e)
        {
            ConvertImage();

            if (!String.IsNullOrEmpty(textBox_Return.Text))
            {
                try
                {
                    Clipboard.SetText(textBox_Return.Text, TextDataFormat.UnicodeText);
                }
                catch
                {}
                //Clipboard.SetDataObject(textBox_Return.Text, true, 2, 100);
            }
        }

        private void OnLinkLabelCreditsClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var creditsPopup = new CreditsForm();
            creditsPopup.ShowDialog();
        }

        private void OnLinkLabelDitheringClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var popupForm = new DitheringForm(1);
            popupForm.ShowDialog();
        }

        private void OnLinkLabelDithering2Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var popupForm = new DitheringForm(2);
            popupForm.ShowDialog();
        }

        private void OnImagePreviewBoxClick(object sender, EventArgs e)
        {
            if (ImagePreviewBox.Image != null)
            {
                var popup_image = new EnlargedImageForm((Bitmap)ImagePreviewBox.Image);
                popup_image.ShowDialog();
            }
        }

        bool newImageLoaded = false;
        private void OnOpenFileDialogFileOk(object sender, CancelEventArgs e)
        {
            newImageLoaded = true;
            textBox_FileDirectory.Text = openFileDialog1.FileName;

            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            //ResetPaletteDictionary();
            LoadImage(); //cache all image sizes
            BuildBitmaps();
            DitherImage(); //initial image dithering
            newImageLoaded = false;
        }

        private void OnComboboxDitherSelectedIndexChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            if (!newImageLoaded)
            {
                DitherImage();
            }
        }

        private void OnComboboxResizeSelectedIndexChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            bool enableComboBoxes = false;

            if (comboBoxBlock.SelectedIndex == blockNames.Count - 1)
            {
                var confirmResult = MessageBox.Show("Selecting '(None)' for the resizing option can cause the code to take longer than normal and can lead to unexpected crashes!\n\nContinue?",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.No)
                {
                    newImageLoaded = true; //this avoids double processing of the image
                    comboBoxBlock.SelectedIndex = 0; //reset selection index to a safe option
                    newImageLoaded = false;
                    return;
                }
            }
            else if (comboBoxBlock.SelectedIndex == blockNames.Count - 2)
            {
                var confirmResult = MessageBox.Show("Selecting '(Custom)' for the resizing option can cause the code to take longer than normal and can lead to unexpected crashes!\n\nContinue?",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.No)
                {
                    newImageLoaded = true; //this avoids double processing of the image
                    comboBoxBlock.SelectedIndex = 0; //reset selection index to a safe option
                    newImageLoaded = false;
                    buttonUpdateResolution.Enabled = false;
                    return;
                }
                else
                {
                    buttonUpdateResolution.Enabled = true;
                    enableComboBoxes = true;
                }
            }
            else
            {
                buttonUpdateResolution.Enabled = false;
            }

            numericUpDownWidth.Enabled = enableComboBoxes;
            numericUpDownHeight.Enabled = enableComboBoxes;

            SelectTextSurfaceTypeComboBoxes(comboBoxBlock.SelectedIndex);
        }

        private void OnCheckBoxAspectRatioCheckedChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();

            //enable or disable background color selector
            //button_background_color.Enabled = checkBox_aspectratio.Checked;
            //pictureBox_background_color.Enabled = checkBox_aspectratio.Checked;
            CheckBackgroundColorEnabled();

            LoadImage();
            BuildBitmaps();
            DitherImage();
        }

        private void OnButtonRotateCCWClick(object sender, EventArgs e)
        {
            RotateImage(false);
        }

        private void OnButtonRotateCWClick(object sender, EventArgs e)
        {
            RotateImage(true);
        }

        private void OnButtonFlipHorizontalClick(object sender, EventArgs e)
        {
            if (baseImage == null)
                return;

            baseImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

            BuildBitmaps(); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        private void OnButtonFlipVerticalClick(object sender, EventArgs e)
        {
            if (baseImage == null)
                return;

            baseImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

            BuildBitmaps(); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        //bool abortLoad = false;
        void ImageLoadProgressBarClosed(object sender, FormClosedEventArgs e)
        {
            if (progressBarForm.DialogResult == DialogResult.Abort)
            {
                backgroundWorkerDithering.CancelAsync();
                Close();
            }
        }

        private void OnButtonUpdateResolutionClick(object sender, EventArgs e)
        {
            if (comboBoxBlock.SelectedIndex == blockNames.Count - 2)
            {
                screenSizeChars = new Vector2((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                BuildBitmaps();
                DitherImage(); //this will update our resolution and recompile the image
            }
        }

        private void OnButtonBackgroundColorClick(object sender, EventArgs e)
        {
            BackgroundColorButtonPressed();
        }

        private void OnPictureBoxBackgroundColorClick(object sender, EventArgs e)
        {
            BackgroundColorButtonPressed();
        }

        void BackgroundColorButtonPressed()
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                backgroundColor = colorDialog1.Color;
                backgroundColorPacked = ColorToColor3(backgroundColor).Packed;

                pictureBox_background_color.BackColor = backgroundColor;

                //reset return string
                textBox_Return.Clear();

                //Redraw image
                if (imageLoaded)
                {
                    BuildBitmaps();
                    DitherImage();
                }
            }
        }

        private void OnLinkLabelGitHubClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(githubVersionUrl);
        }

        private void OnButtonInvertColorsClick(object sender, EventArgs e)
        {
            StartInvertBackgroundWorker();
        }

        private void OnCheckBoxTransparencyCheckedChanged(object sender, EventArgs e)
        {
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";
            CheckBackgroundColorEnabled();

            BuildBitmaps();
            DitherImage();
        }

        void CheckBackgroundColorEnabled()
        {
            bool enabled = (checkBox_aspectratio.Checked && !checkBoxTransparency.Checked);
            button_background_color.Enabled = enabled;
            pictureBox_background_color.Enabled = enabled;
        }

        private void ComboBoxSurface_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBlock.SelectedIndex == blockNames.Count - 1) // None
            {
                if (!imageLoaded)
                    return;

                screenSizeChars = new Vector2(baseImage.Width, baseImage.Height);
                numericUpDownWidth.Value = baseImage.Width;
                numericUpDownHeight.Value = baseImage.Height;
            }
            else if (comboBoxBlock.SelectedIndex == blockNames.Count - 2) // Custom
            {
                screenSizeChars = new Vector2((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
            }
            else // Presets
            {
                var surface = TextSurfaceProvider.TextSurfaceProviders[comboBoxBlock.SelectedIndex].TextSurfaces[comboBoxSurface.SelectedIndex];
                float scale = 512f / Math.Min(surface.TextureSize.X, surface.TextureSize.Y);
                screenSizeChars = surface.SurfaceSize * PIXELS_TO_CHARACTERS * scale;
                screenSizeChars.X = (float)Math.Round(screenSizeChars.X);
                screenSizeChars.Y = (float)Math.Round(screenSizeChars.Y);
                numericUpDownWidth.Value = (int)screenSizeChars.X;
                numericUpDownHeight.Value = (int)screenSizeChars.Y;
            }

            BuildBitmaps();
            DitherImage();

            Console.WriteLine($"screen size:{screenSizeChars} | {PIXELS_TO_CHARACTERS}");
        }

        #endregion
    }
}
