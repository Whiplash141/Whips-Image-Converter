namespace WhipsImageConverter
{
    partial class ImageToLCD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageToLCD));
            this.ImagePreviewBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.textBox_FileDirectory = new System.Windows.Forms.TextBox();
            this.textBox_Return = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Clipboard = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel_Dithering = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Credits = new System.Windows.Forms.LinkLabel();
            this.linkLabel_Dithering2 = new System.Windows.Forms.LinkLabel();
            this.label_stringLength = new System.Windows.Forms.Label();
            this.combobox_dither = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.combobox_resize = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox_aspectratio = new System.Windows.Forms.CheckBox();
            this.buttonRotateCW = new System.Windows.Forms.Button();
            this.buttonRotateCCW = new System.Windows.Forms.Button();
            this.toolTipMaster = new System.Windows.Forms.ToolTip(this.components);
            this.buttonFlipHorizontal = new System.Windows.Forms.Button();
            this.buttonFlipVertical = new System.Windows.Forms.Button();
            this.buttonInvertColors = new System.Windows.Forms.Button();
            this.backgroundWorkerDithering = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdateResolution = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button_background_color = new System.Windows.Forms.Button();
            this.pictureBox_background_color = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.backgroundWorkerInvert = new System.ComponentModel.BackgroundWorker();
            this.checkBoxTransparency = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background_color)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreviewBox
            // 
            this.ImagePreviewBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImagePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreviewBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagePreviewBox.Location = new System.Drawing.Point(12, 29);
            this.ImagePreviewBox.Name = "ImagePreviewBox";
            this.ImagePreviewBox.Size = new System.Drawing.Size(356, 356);
            this.ImagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewBox.TabIndex = 1;
            this.ImagePreviewBox.TabStop = false;
            this.toolTipMaster.SetToolTip(this.ImagePreviewBox, "Click to enlarge");
            this.ImagePreviewBox.Click += new System.EventHandler(this.ImagePreviewBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image Preview";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Location = new System.Drawing.Point(744, 181);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 36);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.toolTipMaster.SetToolTip(this.BrowseButton, "Browse for file");
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox_FileDirectory
            // 
            this.textBox_FileDirectory.Location = new System.Drawing.Point(399, 188);
            this.textBox_FileDirectory.Name = "textBox_FileDirectory";
            this.textBox_FileDirectory.ReadOnly = true;
            this.textBox_FileDirectory.Size = new System.Drawing.Size(334, 22);
            this.textBox_FileDirectory.TabIndex = 8;
            // 
            // textBox_Return
            // 
            this.textBox_Return.Location = new System.Drawing.Point(84, 442);
            this.textBox_Return.Multiline = true;
            this.textBox_Return.Name = "textBox_Return";
            this.textBox_Return.ReadOnly = true;
            this.textBox_Return.Size = new System.Drawing.Size(692, 80);
            this.textBox_Return.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Image Files|*.png;*.jpg;*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Converted String";
            // 
            // button_Clipboard
            // 
            this.button_Clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clipboard.Location = new System.Drawing.Point(263, 528);
            this.button_Clipboard.Name = "button_Clipboard";
            this.button_Clipboard.Size = new System.Drawing.Size(362, 47);
            this.button_Clipboard.TabIndex = 11;
            this.button_Clipboard.Text = "Convert and Copy to Clipboard";
            this.toolTipMaster.SetToolTip(this.button_Clipboard, "Convert the image to monospace and automatically copy to system clipboard");
            this.button_Clipboard.UseVisualStyleBackColor = true;
            this.button_Clipboard.Click += new System.EventHandler(this.button_Clipboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 586);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Made by Whiplash141";
            // 
            // instructions
            // 
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(385, 29);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(447, 136);
            this.instructions.TabIndex = 13;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(395, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Instructions:";
            // 
            // linkLabel_Dithering
            // 
            this.linkLabel_Dithering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Dithering.Location = new System.Drawing.Point(569, 65);
            this.linkLabel_Dithering.Name = "linkLabel_Dithering";
            this.linkLabel_Dithering.Size = new System.Drawing.Size(134, 17);
            this.linkLabel_Dithering.TabIndex = 15;
            this.linkLabel_Dithering.TabStop = true;
            this.linkLabel_Dithering.Text = "Dithering Example 1";
            this.linkLabel_Dithering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Dithering_LinkClicked);
            // 
            // linkLabel_Credits
            // 
            this.linkLabel_Credits.AutoSize = true;
            this.linkLabel_Credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Credits.Location = new System.Drawing.Point(72, 603);
            this.linkLabel_Credits.Name = "linkLabel_Credits";
            this.linkLabel_Credits.Size = new System.Drawing.Size(129, 17);
            this.linkLabel_Credits.TabIndex = 16;
            this.linkLabel_Credits.TabStop = true;
            this.linkLabel_Credits.Text = "Acknowledgements";
            this.linkLabel_Credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Credits_LinkClicked);
            // 
            // linkLabel_Dithering2
            // 
            this.linkLabel_Dithering2.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel_Dithering2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Dithering2.Location = new System.Drawing.Point(709, 65);
            this.linkLabel_Dithering2.Name = "linkLabel_Dithering2";
            this.linkLabel_Dithering2.Size = new System.Drawing.Size(134, 17);
            this.linkLabel_Dithering2.TabIndex = 17;
            this.linkLabel_Dithering2.TabStop = true;
            this.linkLabel_Dithering2.Text = "Dithering Example 2";
            this.linkLabel_Dithering2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Dithering2_LinkClicked);
            // 
            // label_stringLength
            // 
            this.label_stringLength.AutoSize = true;
            this.label_stringLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stringLength.Location = new System.Drawing.Point(614, 422);
            this.label_stringLength.Name = "label_stringLength";
            this.label_stringLength.Size = new System.Drawing.Size(125, 17);
            this.label_stringLength.TabIndex = 18;
            this.label_stringLength.Text = "String Length: 0";
            // 
            // combobox_dither
            // 
            this.combobox_dither.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_dither.FormattingEnabled = true;
            this.combobox_dither.Items.AddRange(new object[] {
            "(None)",
            "Floyd-Steinberg",
            "Ja-Ju-Ni",
            "Stucki",
            "Sierra-3",
            "Sierra-2",
            "Sierra Lite"});
            this.combobox_dither.Location = new System.Drawing.Point(631, 245);
            this.combobox_dither.Name = "combobox_dither";
            this.combobox_dither.Size = new System.Drawing.Size(202, 24);
            this.combobox_dither.TabIndex = 19;
            this.toolTipMaster.SetToolTip(this.combobox_dither, "Select the error diffusion method to make images look smoother");
            this.combobox_dither.SelectedIndexChanged += new System.EventHandler(this.combobox_dither_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dithering Mode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "(Copy and paste this into the Public Text of an LCD)";
            // 
            // combobox_resize
            // 
            this.combobox_resize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_resize.FormattingEnabled = true;
            this.combobox_resize.Items.AddRange(new object[] {
            "Square (178x178)",
            "Wide (356x178)",
            "Large Grid Corner (178x27)",
            "Small Grid Corner (178x47)",
            "(Custom)",
            "(None)"});
            this.combobox_resize.Location = new System.Drawing.Point(399, 245);
            this.combobox_resize.Name = "combobox_resize";
            this.combobox_resize.Size = new System.Drawing.Size(202, 24);
            this.combobox_resize.TabIndex = 22;
            this.toolTipMaster.SetToolTip(this.combobox_resize, "Select the type of text panel to display the image on");
            this.combobox_resize.SelectedIndexChanged += new System.EventHandler(this.combobox_resize_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Resizing Option:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Image File Path:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "(Click image to enlarge)";
            // 
            // checkBox_aspectratio
            // 
            this.checkBox_aspectratio.AutoSize = true;
            this.checkBox_aspectratio.Checked = true;
            this.checkBox_aspectratio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_aspectratio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_aspectratio.Location = new System.Drawing.Point(399, 335);
            this.checkBox_aspectratio.Name = "checkBox_aspectratio";
            this.checkBox_aspectratio.Size = new System.Drawing.Size(167, 21);
            this.checkBox_aspectratio.TabIndex = 26;
            this.checkBox_aspectratio.Text = "Maintain Aspect Ratio";
            this.toolTipMaster.SetToolTip(this.checkBox_aspectratio, "Will use black bars to maintain the aspect ratio of an image");
            this.checkBox_aspectratio.UseVisualStyleBackColor = true;
            this.checkBox_aspectratio.CheckedChanged += new System.EventHandler(this.checkBox_aspectratio_CheckedChanged);
            // 
            // buttonRotateCW
            // 
            this.buttonRotateCW.BackgroundImage = global::WhipsImageConverter.Properties.Resources.CW_arrow;
            this.buttonRotateCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotateCW.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotateCW.Location = new System.Drawing.Point(12, 353);
            this.buttonRotateCW.Name = "buttonRotateCW";
            this.buttonRotateCW.Size = new System.Drawing.Size(32, 32);
            this.buttonRotateCW.TabIndex = 27;
            this.buttonRotateCW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipMaster.SetToolTip(this.buttonRotateCW, "Rotate clockwise");
            this.buttonRotateCW.UseVisualStyleBackColor = true;
            this.buttonRotateCW.Click += new System.EventHandler(this.buttonRotateCW_Click);
            // 
            // buttonRotateCCW
            // 
            this.buttonRotateCCW.BackgroundImage = global::WhipsImageConverter.Properties.Resources.CCW_arrow;
            this.buttonRotateCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateCCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotateCCW.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotateCCW.Location = new System.Drawing.Point(336, 353);
            this.buttonRotateCCW.Name = "buttonRotateCCW";
            this.buttonRotateCCW.Size = new System.Drawing.Size(32, 32);
            this.buttonRotateCCW.TabIndex = 28;
            this.toolTipMaster.SetToolTip(this.buttonRotateCCW, "Rotate counter-clockwise");
            this.buttonRotateCCW.UseVisualStyleBackColor = true;
            this.buttonRotateCCW.Click += new System.EventHandler(this.buttonRotateCCW_Click);
            // 
            // buttonFlipHorizontal
            // 
            this.buttonFlipHorizontal.BackgroundImage = global::WhipsImageConverter.Properties.Resources.Double_headed_arrow;
            this.buttonFlipHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipHorizontal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipHorizontal.Location = new System.Drawing.Point(152, 353);
            this.buttonFlipHorizontal.Name = "buttonFlipHorizontal";
            this.buttonFlipHorizontal.Size = new System.Drawing.Size(32, 32);
            this.buttonFlipHorizontal.TabIndex = 29;
            this.toolTipMaster.SetToolTip(this.buttonFlipHorizontal, "Flip horizontally");
            this.buttonFlipHorizontal.UseVisualStyleBackColor = true;
            this.buttonFlipHorizontal.Click += new System.EventHandler(this.buttonFlipHorizontal_Click);
            // 
            // buttonFlipVertical
            // 
            this.buttonFlipVertical.BackgroundImage = global::WhipsImageConverter.Properties.Resources.Double_headed_arrow_rotated;
            this.buttonFlipVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipVertical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipVertical.Location = new System.Drawing.Point(190, 353);
            this.buttonFlipVertical.Name = "buttonFlipVertical";
            this.buttonFlipVertical.Size = new System.Drawing.Size(32, 32);
            this.buttonFlipVertical.TabIndex = 30;
            this.toolTipMaster.SetToolTip(this.buttonFlipVertical, "Flip vertically");
            this.buttonFlipVertical.UseVisualStyleBackColor = true;
            this.buttonFlipVertical.Click += new System.EventHandler(this.buttonFlipVertical_Click);
            // 
            // buttonInvertColors
            // 
            this.buttonInvertColors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInvertColors.BackgroundImage")));
            this.buttonInvertColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInvertColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvertColors.Location = new System.Drawing.Point(114, 353);
            this.buttonInvertColors.Name = "buttonInvertColors";
            this.buttonInvertColors.Size = new System.Drawing.Size(32, 32);
            this.buttonInvertColors.TabIndex = 42;
            this.toolTipMaster.SetToolTip(this.buttonInvertColors, "Invert colors");
            this.buttonInvertColors.UseVisualStyleBackColor = true;
            this.buttonInvertColors.Click += new System.EventHandler(this.buttonInvertColors_Click);
            // 
            // backgroundWorkerDithering
            // 
            this.backgroundWorkerDithering.WorkerReportsProgress = true;
            this.backgroundWorkerDithering.WorkerSupportsCancellation = true;
            this.backgroundWorkerDithering.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerDithering_DoWork);
            this.backgroundWorkerDithering.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerDithering_ProgressChanged);
            this.backgroundWorkerDithering.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerDithering_RunWorkerCompleted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Custom Resoultion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 17);
            this.label11.TabIndex = 34;
            this.label11.Text = "x";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Enabled = false;
            this.numericUpDownWidth.Location = new System.Drawing.Point(399, 303);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownWidth.TabIndex = 35;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Enabled = false;
            this.numericUpDownHeight.Location = new System.Drawing.Point(480, 303);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(58, 22);
            this.numericUpDownHeight.TabIndex = 36;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonUpdateResolution
            // 
            this.buttonUpdateResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateResolution.Enabled = false;
            this.buttonUpdateResolution.Location = new System.Drawing.Point(544, 298);
            this.buttonUpdateResolution.Name = "buttonUpdateResolution";
            this.buttonUpdateResolution.Size = new System.Drawing.Size(133, 31);
            this.buttonUpdateResolution.TabIndex = 37;
            this.buttonUpdateResolution.Text = "Update Resolution";
            this.toolTipMaster.SetToolTip(this.buttonUpdateResolution, "Update preview with custom resolution");
            this.buttonUpdateResolution.UseVisualStyleBackColor = true;
            this.buttonUpdateResolution.Click += new System.EventHandler(this.buttonUpdateResolution_Click);
            // 
            // button_background_color
            // 
            this.button_background_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_background_color.Location = new System.Drawing.Point(631, 340);
            this.button_background_color.Name = "button_background_color";
            this.button_background_color.Size = new System.Drawing.Size(227, 31);
            this.button_background_color.TabIndex = 38;
            this.button_background_color.Text = "Change Aspect Ratio Bar Color";
            this.toolTipMaster.SetToolTip(this.button_background_color, "Change color of aspect ratio bars");
            this.button_background_color.UseVisualStyleBackColor = true;
            this.button_background_color.Click += new System.EventHandler(this.button_background_color_Click);
            // 
            // pictureBox_background_color
            // 
            this.pictureBox_background_color.BackColor = System.Drawing.Color.Black;
            this.pictureBox_background_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_background_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_background_color.Location = new System.Drawing.Point(595, 340);
            this.pictureBox_background_color.Name = "pictureBox_background_color";
            this.pictureBox_background_color.Size = new System.Drawing.Size(30, 31);
            this.pictureBox_background_color.TabIndex = 39;
            this.pictureBox_background_color.TabStop = false;
            this.toolTipMaster.SetToolTip(this.pictureBox_background_color, "Change color of aspect ratio bars");
            this.pictureBox_background_color.Click += new System.EventHandler(this.pictureBox_background_color_Click);
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUpdate_DoWork);
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.AutoSize = true;
            this.linkLabel_GitHub.Location = new System.Drawing.Point(13, 603);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(52, 17);
            this.linkLabel_GitHub.TabIndex = 40;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "GitHub";
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_GitHub_LinkClicked);
            // 
            // backgroundWorkerInvert
            // 
            this.backgroundWorkerInvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerInvert_DoWork);
            this.backgroundWorkerInvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerInvert_RunWorkerCompleted);
            // 
            // checkBoxTransparency
            // 
            this.checkBoxTransparency.AutoSize = true;
            this.checkBoxTransparency.Location = new System.Drawing.Point(399, 363);
            this.checkBoxTransparency.Name = "checkBoxTransparency";
            this.checkBoxTransparency.Size = new System.Drawing.Size(179, 21);
            this.checkBoxTransparency.TabIndex = 43;
            this.checkBoxTransparency.Text = "Preserve Transparency";
            this.toolTipMaster.SetToolTip(this.checkBoxTransparency, "Preserve source image\'s transparent pixels");
            this.checkBoxTransparency.UseVisualStyleBackColor = true;
            this.checkBoxTransparency.CheckedChanged += new System.EventHandler(this.checkBoxTransparency_CheckedChanged);
            // 
            // ImageToLCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(862, 623);
            this.Controls.Add(this.checkBoxTransparency);
            this.Controls.Add(this.buttonInvertColors);
            this.Controls.Add(this.linkLabel_GitHub);
            this.Controls.Add(this.pictureBox_background_color);
            this.Controls.Add(this.button_background_color);
            this.Controls.Add(this.buttonUpdateResolution);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonFlipVertical);
            this.Controls.Add(this.buttonFlipHorizontal);
            this.Controls.Add(this.buttonRotateCCW);
            this.Controls.Add(this.buttonRotateCW);
            this.Controls.Add(this.checkBox_aspectratio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.combobox_resize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combobox_dither);
            this.Controls.Add(this.label_stringLength);
            this.Controls.Add(this.linkLabel_Dithering2);
            this.Controls.Add(this.linkLabel_Credits);
            this.Controls.Add(this.linkLabel_Dithering);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Clipboard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Return);
            this.Controls.Add(this.textBox_FileDirectory);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImagePreviewBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ImageToLCD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whip\'s Image Converter (Version <num> - <date>)";
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ImagePreviewBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox textBox_FileDirectory;
        private System.Windows.Forms.TextBox textBox_Return;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Clipboard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel_Dithering;
        private System.Windows.Forms.LinkLabel linkLabel_Credits;
        private System.Windows.Forms.LinkLabel linkLabel_Dithering2;
        private System.Windows.Forms.Label label_stringLength;
        private System.Windows.Forms.ComboBox combobox_dither;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox combobox_resize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_aspectratio;
        private System.Windows.Forms.Button buttonRotateCW;
        private System.Windows.Forms.ToolTip toolTipMaster;
        private System.Windows.Forms.Button buttonRotateCCW;
        private System.Windows.Forms.Button buttonFlipHorizontal;
        private System.Windows.Forms.Button buttonFlipVertical;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDithering;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownHeight;
        private System.Windows.Forms.Button buttonUpdateResolution;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_background_color;
        private System.Windows.Forms.PictureBox pictureBox_background_color;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUpdate;
        private System.Windows.Forms.LinkLabel linkLabel_GitHub;
        private System.Windows.Forms.Button buttonInvertColors;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInvert;
        private System.Windows.Forms.CheckBox checkBoxTransparency;
    }
}

