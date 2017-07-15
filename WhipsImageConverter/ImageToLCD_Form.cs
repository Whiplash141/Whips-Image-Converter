using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.Net.Http;
using System.Net;

//Reference: http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT

namespace WhipsImageConverter
{
    public partial class ImageToLCD : Form
    {
        const string myVersionString = "1.1.0";
        const string buildDateString = "7/14/17";
        const string githubVersionUrl = "https://github.com/Whiplash141/Whips-Image-Converter/releases/latest";

        string formTitle = $"Whip's Image Converter (Version {myVersionString} - {buildDateString})";
        string fileDirectory = "";

        Bitmap squareImage;
        Bitmap rectangleImage;
        Bitmap largeCornerImage;
        Bitmap smallCornerImage;
        Bitmap baseImage;
        Bitmap convertedImage;
        Bitmap desiredImage;

        bool imageLoaded = false;

        Color[,] convertedColorArray = null;
        int imageWidth = 0;
        int imageHeight = 0;

        List<Color> allowedColors = new List<Color>();

        ImageLoadProgressForm progressBarForm = new ImageLoadProgressForm();

        Color backgroundColor = Color.FromArgb(0, 0, 0);

        public ImageToLCD()
        {
            InitializeComponent();
            combobox_dither.SelectedIndex = 0;
            combobox_resize.SelectedIndex = 0;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";

            //Set form name
            this.Text = formTitle;

            //Check for any new updates
            CheckForUpdates();

            //Construct colormap
            ConstructColorMap();
        }

        void CheckForUpdates()
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(githubVersionUrl);
            webRequest.AllowAutoRedirect = true;
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            var latestVersionUrl = webResponse.ResponseUri.ToString();
            var urlSplit = latestVersionUrl.Split('/');
            var latestVersionString = urlSplit[urlSplit.Length - 1];
            
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

        void ConstructColorMap()
        {
            allowedColors.Clear();
            for (int r = 0; r <= 7; r++)
            {
                for (int g = 0; g <= 7; g++)
                {
                    for (int b = 0; b <= 7; b++)
                    {
                        allowedColors.Add(Color.FromArgb(ClampColor(r * 37), ClampColor(g * 37), ClampColor(b * 37)));
                    }
                }
            }
        }

        void CacheImages(bool getBaseImage = true)
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

            if (getBaseImage)
                baseImage = (Bitmap)Image.FromFile(fileDirectory, true);

            bool maintainAspectRatio = checkBox_aspectratio.Checked; //default is false

            if (!maintainAspectRatio)
            {
                squareImage = new Bitmap(baseImage, 178, 178);
                rectangleImage = new Bitmap(baseImage, 356, 178);
                largeCornerImage = new Bitmap(baseImage, 178, 27);
                smallCornerImage = new Bitmap(baseImage, 178, 47);
            }
            else
            {
                squareImage = FrameImage(baseImage, 178, 178);
                rectangleImage = FrameImage(baseImage, 356, 178);
                largeCornerImage = FrameImage(baseImage, 178, 27);
                smallCornerImage = FrameImage(baseImage, 178, 47);
            }

            imageLoaded = true;
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
            using (Graphics gfx = Graphics.FromImage(framedImage))
            using (SolidBrush brush = new SolidBrush(backgroundColor))
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

            desiredImage = baseImage;
            
            //Get resize parameters
            switch (combobox_resize.SelectedIndex)
            {
                case 0:
                    desiredImage = squareImage;
                    break;

                case 1:
                    desiredImage = rectangleImage;
                    break;

                case 2:
                    desiredImage = largeCornerImage;
                    break;

                case 3:
                    desiredImage = smallCornerImage;
                    break;

                case 4:
                    if (!checkBox_aspectratio.Checked)
                        desiredImage = new Bitmap(baseImage, new Size((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value));
                    else
                        desiredImage = FrameImage(baseImage, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                    break;

                case 5:
                    desiredImage = baseImage;
                    break;
            }
            

            //Get image dimensions
            imageWidth = desiredImage.Width;
            imageHeight = desiredImage.Height;

            //Initialize empty color array
            convertedColorArray = new Color[imageHeight, imageWidth];

            //Get dithering type
            int type = combobox_dither.SelectedIndex;

            //Assign color array based on dithering options
            StartBackgroundWorker(type);
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

            //Display converted image and encoded string
            textBox_Return.Text = convertedImageString;

            //textBox_Return.Text = debug.ToString(); //for debugging
            //ImagePreviewBox.Image = convertedImage;

            label_stringLength.Text = $"String Length: {textBox_Return.Text.Length}";
            MessageBox.Show("Image Converted"); //successful conversion
        }

        public Color3 ColorToColor3(Color regularColor)
        {
            return new Color3(regularColor.R, regularColor.G, regularColor.B);
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

        StringBuilder debug = new StringBuilder();

        /*
        Color3 medhod adapted from user dacwe on StackExchange 
        Without using a custom color class, the clamping of Color will distort the colors
        https://stackoverflow.com/questions/5940188/how-to-convert-a-24-bit-png-to-3-bit-png-using-floyd-steinberg-dithering

        Dithering methods found from: 
        https://en.wikipedia.org/wiki/Floyd%E2%80%93Steinberg_dithering
        http://www.tannerhelland.com/4660/dithering-eleven-algorithms-source-code/
        http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT
        */
        private Color[,] Dithering(Bitmap image, int width, int height, int type)
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

            Color[,] convertedColorArray = new Color[height, width];

            int divisor = GetFilterDivisor(filterArray);

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    var oldColor = initialColorArray[row, col];
                    var newColor = GetClosestColor(oldColor);
                    convertedColorArray[row, col] = newColor.ToColor();

                    Color3 error = oldColor.Subtract(newColor);

                    for (int i = 0; i < filterArray.GetLength(0); i++) //iterate through each row
                    {
                        int factor = filterArray[i, 0]; //factor 
                        int rowIndex = filterArray[i, 1] + row; //adjusted row
                        int colIndex = filterArray[i, 2] + col; //adjusted column

                        #region debugger
                        //debug.AppendLine(IsIndexAllowed(rowIndex, colIndex, filterArray).ToString());
                        #endregion

                        if (IsIndexAllowed(rowIndex, colIndex, width, height))
                            initialColorArray[rowIndex, colIndex] = initialColorArray[rowIndex, colIndex].Add(error.Multiply((float)factor / divisor));
                        else
                            continue;
                    }

                    if (progressBarForm.DialogResult != DialogResult.Abort)
                        backgroundWorker1.ReportProgress(GetPercentCompletion(height, width, row, col));
                }
            }
           
            return convertedColorArray;
        }

        private Color[,] NoDithering(Bitmap image, int width, int height)
        {
            Color[,]colorArray = new Color[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Color pixelColor = image.GetPixel(col, row);
                    colorArray[row, col] = GetClosestColor(pixelColor);

                    if (progressBarForm.DialogResult != DialogResult.Abort)
                            backgroundWorker1.ReportProgress(GetPercentCompletion(height, width, row, col));
                }
            }

            return colorArray;
        }

        //Manhattan distance
        int ColorDiff(Color color1, Color color2)
        {
            return Math.Abs(color1.R - color2.R) + Math.Abs(color1.G - color2.G) + Math.Abs(color1.B - color2.B);
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

        Color GetClosestColor(Color pixelColor)
        {
            var leastDiff = 10000000f;
            var leastIndex = -1;
            
            for (int i = 0; i < allowedColors.Count; i++)
            {
                var comparisonColor = allowedColors[i];
                var thisDiff = ColorDiff(pixelColor, comparisonColor);

                if (thisDiff < leastDiff)
                {
                    leastIndex = i;
                    leastDiff = thisDiff;
                }
            }

            return allowedColors[leastIndex];
        }

        Color3 GetClosestColor(Color3 pixelColor)
        {
            var leastDiff = 10000000f;
            var leastIndex = -1;

            for (int i = 0; i < allowedColors.Count; i++)
            {
                var comparisonColor = ColorToColor3(allowedColors[i]);
                var thisDiff = pixelColor.Diff(comparisonColor);

                if (thisDiff < leastDiff)
                {
                    leastIndex = i;
                    leastDiff = thisDiff;
                }
            }

            return ColorToColor3(allowedColors[leastIndex]);
        }

        int ColorToInt(byte r, byte g, byte b)
        {
            return (int)(0xe100 + ((r/37) << 6) + ((g/37) << 3) + (b/37));
        }

        string BuildFinalString(Color[,] colorArray, int width, int height)
        {
            var sb = new StringBuilder();
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    var thisColor = colorArray[row, col];
                    var colorInt = ColorToInt(thisColor.R, thisColor.G, thisColor.B);
                    string colorGlyph = ".";
                    colorGlyphs.TryGetValue(colorInt, out colorGlyph);
                    sb.Append(colorGlyph);
                }

                if (row + 1 < height)
                    sb.Append("\n");
            }

            sb.Append("Converted with Whip's Image Converter");
            return sb.ToString();
        }

        private Bitmap ArrayToBmp(Color[,] colorArray, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    bmp.SetPixel(col, row, colorArray[row, col]); //i think this should work because of how bmp is traversed
                }
            }

            return bmp;
        }

        

        Dictionary<int, string> colorGlyphs = new Dictionary<int, string>()
        {
            #region Bigass Dictionary
            { (int)0xe100,""},
            {(int)0xe101,""},
            {(int)0xe102,""},
            {(int)0xe103,""},
            {(int)0xe104,""},
            {(int)0xe105,""},
            {(int)0xe106,""},
            {(int)0xe107,""},
            {(int)0xe108,""},
            {(int)0xe109,""},
            {(int)0xe10a,""},
            {(int)0xe10b,""},
            {(int)0xe10c,""},
            {(int)0xe10d,""},
            {(int)0xe10e,""},
            {(int)0xe10f,""},
            {(int)0xe110,""},
            {(int)0xe111,""},
            {(int)0xe112,""},
            {(int)0xe113,""},
            {(int)0xe114,""},
            {(int)0xe115,""},
            {(int)0xe116,""},
            {(int)0xe117,""},
            {(int)0xe118,""},
            {(int)0xe119,""},
            {(int)0xe11a,""},
            {(int)0xe11b,""},
            {(int)0xe11c,""},
            {(int)0xe11d,""},
            {(int)0xe11e,""},
            {(int)0xe11f,""},
            {(int)0xe120,""},
            {(int)0xe121,""},
            {(int)0xe122,""},
            {(int)0xe123,""},
            {(int)0xe124,""},
            {(int)0xe125,""},
            {(int)0xe126,""},
            {(int)0xe127,""},
            {(int)0xe128,""},
            {(int)0xe129,""},
            {(int)0xe12a,""},
            {(int)0xe12b,""},
            {(int)0xe12c,""},
            {(int)0xe12d,""},
            {(int)0xe12e,""},
            {(int)0xe12f,""},
            {(int)0xe130,""},
            {(int)0xe131,""},
            {(int)0xe132,""},
            {(int)0xe133,""},
            {(int)0xe134,""},
            {(int)0xe135,""},
            {(int)0xe136,""},
            {(int)0xe137,""},
            {(int)0xe138,""},
            {(int)0xe139,""},
            {(int)0xe13a,""},
            {(int)0xe13b,""},
            {(int)0xe13c,""},
            {(int)0xe13d,""},
            {(int)0xe13e,""},
            {(int)0xe13f,""},
            {(int)0xe140,""},
            {(int)0xe141,""},
            {(int)0xe142,""},
            {(int)0xe143,""},
            {(int)0xe144,""},
            {(int)0xe145,""},
            {(int)0xe146,""},
            {(int)0xe147,""},
            {(int)0xe148,""},
            {(int)0xe149,""},
            {(int)0xe14a,""},
            {(int)0xe14b,""},
            {(int)0xe14c,""},
            {(int)0xe14d,""},
            {(int)0xe14e,""},
            {(int)0xe14f,""},
            {(int)0xe150,""},
            {(int)0xe151,""},
            {(int)0xe152,""},
            {(int)0xe153,""},
            {(int)0xe154,""},
            {(int)0xe155,""},
            {(int)0xe156,""},
            {(int)0xe157,""},
            {(int)0xe158,""},
            {(int)0xe159,""},
            {(int)0xe15a,""},
            {(int)0xe15b,""},
            {(int)0xe15c,""},
            {(int)0xe15d,""},
            {(int)0xe15e,""},
            {(int)0xe15f,""},
            {(int)0xe160,""},
            {(int)0xe161,""},
            {(int)0xe162,""},
            {(int)0xe163,""},
            {(int)0xe164,""},
            {(int)0xe165,""},
            {(int)0xe166,""},
            {(int)0xe167,""},
            {(int)0xe168,""},
            {(int)0xe169,""},
            {(int)0xe16a,""},
            {(int)0xe16b,""},
            {(int)0xe16c,""},
            {(int)0xe16d,""},
            {(int)0xe16e,""},
            {(int)0xe16f,""},
            {(int)0xe170,""},
            {(int)0xe171,""},
            {(int)0xe172,""},
            {(int)0xe173,""},
            {(int)0xe174,""},
            {(int)0xe175,""},
            {(int)0xe176,""},
            {(int)0xe177,""},
            {(int)0xe178,""},
            {(int)0xe179,""},
            {(int)0xe17a,""},
            {(int)0xe17b,""},
            {(int)0xe17c,""},
            {(int)0xe17d,""},
            {(int)0xe17e,""},
            {(int)0xe17f,""},
            {(int)0xe180,""},
            {(int)0xe181,""},
            {(int)0xe182,""},
            {(int)0xe183,""},
            {(int)0xe184,""},
            {(int)0xe185,""},
            {(int)0xe186,""},
            {(int)0xe187,""},
            {(int)0xe188,""},
            {(int)0xe189,""},
            {(int)0xe18a,""},
            {(int)0xe18b,""},
            {(int)0xe18c,""},
            {(int)0xe18d,""},
            {(int)0xe18e,""},
            {(int)0xe18f,""},
            {(int)0xe190,""},
            {(int)0xe191,""},
            {(int)0xe192,""},
            {(int)0xe193,""},
            {(int)0xe194,""},
            {(int)0xe195,""},
            {(int)0xe196,""},
            {(int)0xe197,""},
            {(int)0xe198,""},
            {(int)0xe199,""},
            {(int)0xe19a,""},
            {(int)0xe19b,""},
            {(int)0xe19c,""},
            {(int)0xe19d,""},
            {(int)0xe19e,""},
            {(int)0xe19f,""},
            {(int)0xe1a0,""},
            {(int)0xe1a1,""},
            {(int)0xe1a2,""},
            {(int)0xe1a3,""},
            {(int)0xe1a4,""},
            {(int)0xe1a5,""},
            {(int)0xe1a6,""},
            {(int)0xe1a7,""},
            {(int)0xe1a8,""},
            {(int)0xe1a9,""},
            {(int)0xe1aa,""},
            {(int)0xe1ab,""},
            {(int)0xe1ac,""},
            {(int)0xe1ad,""},
            {(int)0xe1ae,""},
            {(int)0xe1af,""},
            {(int)0xe1b0,""},
            {(int)0xe1b1,""},
            {(int)0xe1b2,""},
            {(int)0xe1b3,""},
            {(int)0xe1b4,""},
            {(int)0xe1b5,""},
            {(int)0xe1b6,""},
            {(int)0xe1b7,""},
            {(int)0xe1b8,""},
            {(int)0xe1b9,""},
            {(int)0xe1ba,""},
            {(int)0xe1bb,""},
            {(int)0xe1bc,""},
            {(int)0xe1bd,""},
            {(int)0xe1be,""},
            {(int)0xe1bf,""},
            {(int)0xe1c0,""},
            {(int)0xe1c1,""},
            {(int)0xe1c2,""},
            {(int)0xe1c3,""},
            {(int)0xe1c4,""},
            {(int)0xe1c5,""},
            {(int)0xe1c6,""},
            {(int)0xe1c7,""},
            {(int)0xe1c8,""},
            {(int)0xe1c9,""},
            {(int)0xe1ca,""},
            {(int)0xe1cb,""},
            {(int)0xe1cc,""},
            {(int)0xe1cd,""},
            {(int)0xe1ce,""},
            {(int)0xe1cf,""},
            {(int)0xe1d0,""},
            {(int)0xe1d1,""},
            {(int)0xe1d2,""},
            {(int)0xe1d3,""},
            {(int)0xe1d4,""},
            {(int)0xe1d5,""},
            {(int)0xe1d6,""},
            {(int)0xe1d7,""},
            {(int)0xe1d8,""},
            {(int)0xe1d9,""},
            {(int)0xe1da,""},
            {(int)0xe1db,""},
            {(int)0xe1dc,""},
            {(int)0xe1dd,""},
            {(int)0xe1de,""},
            {(int)0xe1df,""},
            {(int)0xe1e0,""},
            {(int)0xe1e1,""},
            {(int)0xe1e2,""},
            {(int)0xe1e3,""},
            {(int)0xe1e4,""},
            {(int)0xe1e5,""},
            {(int)0xe1e6,""},
            {(int)0xe1e7,""},
            {(int)0xe1e8,""},
            {(int)0xe1e9,""},
            {(int)0xe1ea,""},
            {(int)0xe1eb,""},
            {(int)0xe1ec,""},
            {(int)0xe1ed,""},
            {(int)0xe1ee,""},
            {(int)0xe1ef,""},
            {(int)0xe1f0,""},
            {(int)0xe1f1,""},
            {(int)0xe1f2,""},
            {(int)0xe1f3,""},
            {(int)0xe1f4,""},
            {(int)0xe1f5,""},
            {(int)0xe1f6,""},
            {(int)0xe1f7,""},
            {(int)0xe1f8,""},
            {(int)0xe1f9,""},
            {(int)0xe1fa,""},
            {(int)0xe1fb,""},
            {(int)0xe1fc,""},
            {(int)0xe1fd,""},
            {(int)0xe1fe,""},
            {(int)0xe1ff,""},
            {(int)0xe200,""},
            {(int)0xe201,""},
            {(int)0xe202,""},
            {(int)0xe203,""},
            {(int)0xe204,""},
            {(int)0xe205,""},
            {(int)0xe206,""},
            {(int)0xe207,""},
            {(int)0xe208,""},
            {(int)0xe209,""},
            {(int)0xe20a,""},
            {(int)0xe20b,""},
            {(int)0xe20c,""},
            {(int)0xe20d,""},
            {(int)0xe20e,""},
            {(int)0xe20f,""},
            {(int)0xe210,""},
            {(int)0xe211,""},
            {(int)0xe212,""},
            {(int)0xe213,""},
            {(int)0xe214,""},
            {(int)0xe215,""},
            {(int)0xe216,""},
            {(int)0xe217,""},
            {(int)0xe218,""},
            {(int)0xe219,""},
            {(int)0xe21a,""},
            {(int)0xe21b,""},
            {(int)0xe21c,""},
            {(int)0xe21d,""},
            {(int)0xe21e,""},
            {(int)0xe21f,""},
            {(int)0xe220,""},
            {(int)0xe221,""},
            {(int)0xe222,""},
            {(int)0xe223,""},
            {(int)0xe224,""},
            {(int)0xe225,""},
            {(int)0xe226,""},
            {(int)0xe227,""},
            {(int)0xe228,""},
            {(int)0xe229,""},
            {(int)0xe22a,""},
            {(int)0xe22b,""},
            {(int)0xe22c,""},
            {(int)0xe22d,""},
            {(int)0xe22e,""},
            {(int)0xe22f,""},
            {(int)0xe230,""},
            {(int)0xe231,""},
            {(int)0xe232,""},
            {(int)0xe233,""},
            {(int)0xe234,""},
            {(int)0xe235,""},
            {(int)0xe236,""},
            {(int)0xe237,""},
            {(int)0xe238,""},
            {(int)0xe239,""},
            {(int)0xe23a,""},
            {(int)0xe23b,""},
            {(int)0xe23c,""},
            {(int)0xe23d,""},
            {(int)0xe23e,""},
            {(int)0xe23f,""},
            {(int)0xe240,""},
            {(int)0xe241,""},
            {(int)0xe242,""},
            {(int)0xe243,""},
            {(int)0xe244,""},
            {(int)0xe245,""},
            {(int)0xe246,""},
            {(int)0xe247,""},
            {(int)0xe248,""},
            {(int)0xe249,""},
            {(int)0xe24a,""},
            {(int)0xe24b,""},
            {(int)0xe24c,""},
            {(int)0xe24d,""},
            {(int)0xe24e,""},
            {(int)0xe24f,""},
            {(int)0xe250,""},
            {(int)0xe251,""},
            {(int)0xe252,""},
            {(int)0xe253,""},
            {(int)0xe254,""},
            {(int)0xe255,""},
            {(int)0xe256,""},
            {(int)0xe257,""},
            {(int)0xe258,""},
            {(int)0xe259,""},
            {(int)0xe25a,""},
            {(int)0xe25b,""},
            {(int)0xe25c,""},
            {(int)0xe25d,""},
            {(int)0xe25e,""},
            {(int)0xe25f,""},
            {(int)0xe260,""},
            {(int)0xe261,""},
            {(int)0xe262,""},
            {(int)0xe263,""},
            {(int)0xe264,""},
            {(int)0xe265,""},
            {(int)0xe266,""},
            {(int)0xe267,""},
            {(int)0xe268,""},
            {(int)0xe269,""},
            {(int)0xe26a,""},
            {(int)0xe26b,""},
            {(int)0xe26c,""},
            {(int)0xe26d,""},
            {(int)0xe26e,""},
            {(int)0xe26f,""},
            {(int)0xe270,""},
            {(int)0xe271,""},
            {(int)0xe272,""},
            {(int)0xe273,""},
            {(int)0xe274,""},
            {(int)0xe275,""},
            {(int)0xe276,""},
            {(int)0xe277,""},
            {(int)0xe278,""},
            {(int)0xe279,""},
            {(int)0xe27a,""},
            {(int)0xe27b,""},
            {(int)0xe27c,""},
            {(int)0xe27d,""},
            {(int)0xe27e,""},
            {(int)0xe27f,""},
            {(int)0xe280,""},
            {(int)0xe281,""},
            {(int)0xe282,""},
            {(int)0xe283,""},
            {(int)0xe284,""},
            {(int)0xe285,""},
            {(int)0xe286,""},
            {(int)0xe287,""},
            {(int)0xe288,""},
            {(int)0xe289,""},
            {(int)0xe28a,""},
            {(int)0xe28b,""},
            {(int)0xe28c,""},
            {(int)0xe28d,""},
            {(int)0xe28e,""},
            {(int)0xe28f,""},
            {(int)0xe290,""},
            {(int)0xe291,""},
            {(int)0xe292,""},
            {(int)0xe293,""},
            {(int)0xe294,""},
            {(int)0xe295,""},
            {(int)0xe296,""},
            {(int)0xe297,""},
            {(int)0xe298,""},
            {(int)0xe299,""},
            {(int)0xe29a,""},
            {(int)0xe29b,""},
            {(int)0xe29c,""},
            {(int)0xe29d,""},
            {(int)0xe29e,""},
            {(int)0xe29f,""},
            {(int)0xe2a0,""},
            {(int)0xe2a1,""},
            {(int)0xe2a2,""},
            {(int)0xe2a3,""},
            {(int)0xe2a4,""},
            {(int)0xe2a5,""},
            {(int)0xe2a6,""},
            {(int)0xe2a7,""},
            {(int)0xe2a8,""},
            {(int)0xe2a9,""},
            {(int)0xe2aa,""},
            {(int)0xe2ab,""},
            {(int)0xe2ac,""},
            {(int)0xe2ad,""},
            {(int)0xe2ae,""},
            {(int)0xe2af,""},
            {(int)0xe2b0,""},
            {(int)0xe2b1,""},
            {(int)0xe2b2,""},
            {(int)0xe2b3,""},
            {(int)0xe2b4,""},
            {(int)0xe2b5,""},
            {(int)0xe2b6,""},
            {(int)0xe2b7,""},
            {(int)0xe2b8,""},
            {(int)0xe2b9,""},
            {(int)0xe2ba,""},
            {(int)0xe2bb,""},
            {(int)0xe2bc,""},
            {(int)0xe2bd,""},
            {(int)0xe2be,""},
            {(int)0xe2bf,""},
            {(int)0xe2c0,""},
            {(int)0xe2c1,""},
            {(int)0xe2c2,""},
            {(int)0xe2c3,""},
            {(int)0xe2c4,""},
            {(int)0xe2c5,""},
            {(int)0xe2c6,""},
            {(int)0xe2c7,""},
            {(int)0xe2c8,""},
            {(int)0xe2c9,""},
            {(int)0xe2ca,""},
            {(int)0xe2cb,""},
            {(int)0xe2cc,""},
            {(int)0xe2cd,""},
            {(int)0xe2ce,""},
            {(int)0xe2cf,""},
            {(int)0xe2d0,""},
            {(int)0xe2d1,""},
            {(int)0xe2d2,""},
            {(int)0xe2d3,""},
            {(int)0xe2d4,""},
            {(int)0xe2d5,""},
            {(int)0xe2d6,""},
            {(int)0xe2d7,""},
            {(int)0xe2d8,""},
            {(int)0xe2d9,""},
            {(int)0xe2da,""},
            {(int)0xe2db,""},
            {(int)0xe2dc,""},
            {(int)0xe2dd,""},
            {(int)0xe2de,""},
            {(int)0xe2df,""},
            {(int)0xe2e0,""},
            {(int)0xe2e1,""},
            {(int)0xe2e2,""},
            {(int)0xe2e3,""},
            {(int)0xe2e4,""},
            {(int)0xe2e5,""},
            {(int)0xe2e6,""},
            {(int)0xe2e7,""},
            {(int)0xe2e8,""},
            {(int)0xe2e9,""},
            {(int)0xe2ea,""},
            {(int)0xe2eb,""},
            {(int)0xe2ec,""},
            {(int)0xe2ed,""},
            {(int)0xe2ee,""},
            {(int)0xe2ef,""},
            {(int)0xe2f0,""},
            {(int)0xe2f1,""},
            {(int)0xe2f2,""},
            {(int)0xe2f3,""},
            {(int)0xe2f4,""},
            {(int)0xe2f5,""},
            {(int)0xe2f6,""},
            {(int)0xe2f7,""},
            {(int)0xe2f8,""},
            {(int)0xe2f9,""},
            {(int)0xe2fa,""},
            {(int)0xe2fb,""},
            {(int)0xe2fc,""},
            {(int)0xe2fd,""},
            {(int)0xe2fe,""},
            {(int)0xe2ff,""}
            #endregion
        };
        
        private void button_Convert_Click(object sender, EventArgs e)
        {
            ConvertImage();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Show the dialog.
        }

        private void button_Clipboard_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_Return.Text))
                Clipboard.SetText(textBox_Return.Text, TextDataFormat.UnicodeText);
        }

        private void linkLabel_Credits_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var creditsPopup = new popup_credits();
            creditsPopup.Show();
        }

        private void linkLabel_Dithering_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var popupForm = new DitheringPopup(1);
            popupForm.Show();
        }

        private void linkLabel_Dithering2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var popupForm = new DitheringPopup(2);
            popupForm.Show();
        }

        public class Color3
        {
            public int R;
            public int G;
            public int B;

            public Color3(int R, int G, int B)
            {
                this.R = R;
                this.G = G;
                this.B = B;
            }

            private int ClampColor(int value)
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

            public int Diff(Color3 otherColor)
            {
                return Math.Abs(R - otherColor.R) + Math.Abs(G - otherColor.G) + Math.Abs(B - otherColor.B);
            }

            public Color ToColor()
            {
                return Color.FromArgb(ClampColor(R), ClampColor(G), ClampColor(B));
            }

            public Color3 Add(Color3 colorToAdd)
            {
                return new Color3(R + colorToAdd.R, G + colorToAdd.G, B + colorToAdd.B);
            }

            public Color3 Subtract(Color3 colorToSub)
            {
                return new Color3(R - colorToSub.R, G - colorToSub.G, B - colorToSub.B);
            }

            public Color3 Multiply(float multiplier)
            {
                return new Color3((int)Math.Round(R * multiplier), (int)Math.Round(G * multiplier), (int)Math.Round(B * multiplier));
            }
        }

        private void ImagePreviewBox_Click(object sender, EventArgs e)
        {
            if (ImagePreviewBox.Image != null)
            {
                var popup_image = new popup_imagebox((Bitmap)ImagePreviewBox.Image);
                popup_image.Show();
            }
        }

        bool newImageLoaded = false;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            newImageLoaded = true;
            textBox_FileDirectory.Text = openFileDialog1.FileName;

            //reset comboboxes to initial values
            //combobox_dither.SelectedIndex = 0;
            //combobox_resize.SelectedIndex = 0;

            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            CacheImages(); //cache all image size
            DitherImage(); //initial image dithering
            newImageLoaded = false;
        }

        private void combobox_dither_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            if (!newImageLoaded)
                DitherImage();
        }

        private void combobox_resize_SelectedIndexChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();
            label_stringLength.Text = "String Length: 0";

            if (combobox_resize.SelectedIndex == 5)
            {
                var confirmResult = MessageBox.Show("Selecting '(None)' for the resizing option can cause the code to take longer than normal and can lead to unexpected crashes!\n\nContinue?", 
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.No)
                {
                    newImageLoaded = true; //this avoids double processing of the image
                    combobox_resize.SelectedIndex = 0; //reset selection index to a safe option
                    newImageLoaded = false;
                }
            }

            if (combobox_resize.SelectedIndex == 4)
            {
                var confirmResult = MessageBox.Show("Selecting '(Custom)' for the resizing option can cause the code to take longer than normal and can lead to unexpected crashes!\n\nContinue?",
                    "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (confirmResult == DialogResult.No)
                {
                    newImageLoaded = true; //this avoids double processing of the image
                    combobox_resize.SelectedIndex = 0; //reset selection index to a safe option
                    newImageLoaded = false;

                    //disable numeric sliders
                    numericUpDownWidth.Enabled = false;
                    numericUpDownHeight.Enabled = false;
                    buttonUpdateResolution.Enabled = false;
                }
                else
                {
                    //enable numeric sliders
                    numericUpDownWidth.Enabled = true;
                    numericUpDownHeight.Enabled = true;
                    buttonUpdateResolution.Enabled = true;
                }
            }
            else
            {
                //numericUpDownWidth.Value = 100;
                //numericUpDownHeight.Value = 100;
                numericUpDownWidth.Enabled = false;
                numericUpDownHeight.Enabled = false;
                buttonUpdateResolution.Enabled = false;
            }

            if (!newImageLoaded)
                DitherImage();
        }

        private void checkBox_aspectratio_CheckedChanged(object sender, EventArgs e)
        {
            //reset return string
            textBox_Return.Clear();

            //enable or disable background color selector
            button_background_color.Enabled = checkBox_aspectratio.Checked;
            pictureBox_background_color.Enabled = checkBox_aspectratio.Checked;

            CacheImages();
            DitherImage();
        }

        private void buttonRotateCCW_Click(object sender, EventArgs e)
        {
            RotateImage(false);
        }

        private void buttonRotateCW_Click(object sender, EventArgs e)
        {
            RotateImage(true);
        }

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

            CacheImages(false); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        private void buttonFlipHorizontal_Click(object sender, EventArgs e)
        {
            if (baseImage == null)
                return;

            baseImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

            CacheImages(false); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        private void buttonFlipVertical_Click(object sender, EventArgs e)
        {
            if (baseImage == null)
                return;

            baseImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

            CacheImages(false); //cache rotated images
            DitherImage(); //rotated image dithering
        }

        //bool abortLoad = false;
        void ImageLoadProgressBarClosed(object sender, FormClosedEventArgs e)
        {
            if (progressBarForm.DialogResult == DialogResult.Abort)
            {
                backgroundWorker1.CancelAsync();
                Close();
                //Application.Exit();
            }
        }

        #region Running the mathy crap in another thread

        void StartBackgroundWorker(int type)
        {
            this.Enabled = false;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync(type);

            progressBarForm = new ImageLoadProgressForm();
            progressBarForm.FormClosed += ImageLoadProgressBarClosed;
            progressBarForm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
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

            //e.Result = convertedColorArray;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBarForm.SetProgressBarValue(e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarForm.Close();
            this.Enabled = true;
            convertedImage = ArrayToBmp(convertedColorArray, imageWidth, imageHeight);
            ImagePreviewBox.Image = convertedImage;
        }
        #endregion

        private void buttonUpdateResolution_Click(object sender, EventArgs e)
        {
            if (combobox_resize.SelectedIndex == 4)
            {
                DitherImage(); //this will update our resolution and recompile the image
            }
        }

        private void button_background_color_Click(object sender, EventArgs e)
        {
            BackgroundColorButtonPressed();
        }

        private void pictureBox_background_color_Click(object sender, EventArgs e)
        {
            BackgroundColorButtonPressed();
        }

        void BackgroundColorButtonPressed()
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                backgroundColor = colorDialog1.Color;

                pictureBox_background_color.BackColor = backgroundColor;

                //reset return string
                textBox_Return.Clear();

                //Redraw image
                if (imageLoaded)
                {
                    CacheImages();
                    DitherImage();
                }
            }
        }
    }
}
