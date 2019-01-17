namespace WhipsImageConverter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.buttonUpdateResolution = new System.Windows.Forms.Button();
            this.button_background_color = new System.Windows.Forms.Button();
            this.pictureBox_background_color = new System.Windows.Forms.PictureBox();
            this.checkBoxTransparency = new System.Windows.Forms.CheckBox();
            this.button_DirBrowse = new System.Windows.Forms.Button();
            this.checkBox_isDirMode = new System.Windows.Forms.CheckBox();
            this.button_ConvertDir = new System.Windows.Forms.Button();
            this.backgroundWorkerDithering = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorkerUpdate = new System.ComponentModel.BackgroundWorker();
            this.linkLabel_GitHub = new System.Windows.Forms.LinkLabel();
            this.backgroundWorkerInvert = new System.ComponentModel.BackgroundWorker();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_DirPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePreviewBox
            // 
            this.ImagePreviewBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImagePreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePreviewBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImagePreviewBox.Location = new System.Drawing.Point(10, 23);
            this.ImagePreviewBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePreviewBox.Name = "ImagePreviewBox";
            this.ImagePreviewBox.Size = new System.Drawing.Size(285, 285);
            this.ImagePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImagePreviewBox.TabIndex = 1;
            this.ImagePreviewBox.TabStop = false;
            this.toolTipMaster.SetToolTip(this.ImagePreviewBox, "Click to enlarge");
            this.ImagePreviewBox.Click += new System.EventHandler(this.OnImagePreviewBoxClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Image Preview";
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.ForeColor = System.Drawing.Color.White;
            this.BrowseButton.Location = new System.Drawing.Point(595, 145);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(60, 29);
            this.BrowseButton.TabIndex = 7;
            this.BrowseButton.Text = "Browse";
            this.toolTipMaster.SetToolTip(this.BrowseButton, "Browse for file");
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // textBox_FileDirectory
            // 
            this.textBox_FileDirectory.BackColor = System.Drawing.Color.Black;
            this.textBox_FileDirectory.ForeColor = System.Drawing.Color.White;
            this.textBox_FileDirectory.Location = new System.Drawing.Point(319, 150);
            this.textBox_FileDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FileDirectory.Name = "textBox_FileDirectory";
            this.textBox_FileDirectory.ReadOnly = true;
            this.textBox_FileDirectory.Size = new System.Drawing.Size(268, 21);
            this.textBox_FileDirectory.TabIndex = 8;
            // 
            // textBox_Return
            // 
            this.textBox_Return.BackColor = System.Drawing.Color.Black;
            this.textBox_Return.ForeColor = System.Drawing.Color.White;
            this.textBox_Return.Location = new System.Drawing.Point(67, 397);
            this.textBox_Return.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Return.Multiline = true;
            this.textBox_Return.Name = "textBox_Return";
            this.textBox_Return.ReadOnly = true;
            this.textBox_Return.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Return.Size = new System.Drawing.Size(554, 65);
            this.textBox_Return.TabIndex = 9;
            this.textBox_Return.WordWrap = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Image Files|*.png;*.jpg;*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OnOpenFileDialogFileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Converted String";
            // 
            // button_Clipboard
            // 
            this.button_Clipboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_Clipboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Clipboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Clipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clipboard.ForeColor = System.Drawing.Color.White;
            this.button_Clipboard.Location = new System.Drawing.Point(210, 465);
            this.button_Clipboard.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clipboard.Name = "button_Clipboard";
            this.button_Clipboard.Size = new System.Drawing.Size(290, 38);
            this.button_Clipboard.TabIndex = 11;
            this.button_Clipboard.Text = "Convert and Copy to Clipboard";
            this.toolTipMaster.SetToolTip(this.button_Clipboard, "Convert the image to monospace and automatically copy to system clipboard");
            this.button_Clipboard.UseVisualStyleBackColor = false;
            this.button_Clipboard.Click += new System.EventHandler(this.OnButtonClipboardClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 499);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "Made by Whiplash141";
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Transparent;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.ForeColor = System.Drawing.Color.White;
            this.instructions.Location = new System.Drawing.Point(308, 23);
            this.instructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(358, 109);
            this.instructions.TabIndex = 13;
            this.instructions.Text = resources.GetString("instructions.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(316, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Instructions:";
            // 
            // linkLabel_Dithering
            // 
            this.linkLabel_Dithering.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Dithering.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Dithering.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.linkLabel_Dithering.Location = new System.Drawing.Point(459, 56);
            this.linkLabel_Dithering.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Dithering.Name = "linkLabel_Dithering";
            this.linkLabel_Dithering.Size = new System.Drawing.Size(107, 14);
            this.linkLabel_Dithering.TabIndex = 15;
            this.linkLabel_Dithering.TabStop = true;
            this.linkLabel_Dithering.Text = "Dithering Example 1";
            this.linkLabel_Dithering.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelDitheringClick);
            // 
            // linkLabel_Credits
            // 
            this.linkLabel_Credits.AutoSize = true;
            this.linkLabel_Credits.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Credits.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.linkLabel_Credits.Location = new System.Drawing.Point(61, 516);
            this.linkLabel_Credits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Credits.Name = "linkLabel_Credits";
            this.linkLabel_Credits.Size = new System.Drawing.Size(101, 12);
            this.linkLabel_Credits.TabIndex = 16;
            this.linkLabel_Credits.TabStop = true;
            this.linkLabel_Credits.Text = "Acknowledgements";
            this.linkLabel_Credits.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelCreditsClick);
            // 
            // linkLabel_Dithering2
            // 
            this.linkLabel_Dithering2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_Dithering2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel_Dithering2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.linkLabel_Dithering2.Location = new System.Drawing.Point(571, 56);
            this.linkLabel_Dithering2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Dithering2.Name = "linkLabel_Dithering2";
            this.linkLabel_Dithering2.Size = new System.Drawing.Size(107, 14);
            this.linkLabel_Dithering2.TabIndex = 17;
            this.linkLabel_Dithering2.TabStop = true;
            this.linkLabel_Dithering2.Text = "Dithering Example 2";
            this.linkLabel_Dithering2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelDithering2Click);
            // 
            // label_stringLength
            // 
            this.label_stringLength.AutoSize = true;
            this.label_stringLength.BackColor = System.Drawing.Color.Transparent;
            this.label_stringLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stringLength.ForeColor = System.Drawing.Color.White;
            this.label_stringLength.Location = new System.Drawing.Point(521, 364);
            this.label_stringLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stringLength.Name = "label_stringLength";
            this.label_stringLength.Size = new System.Drawing.Size(98, 13);
            this.label_stringLength.TabIndex = 18;
            this.label_stringLength.Text = "String Length: 0";
            // 
            // combobox_dither
            // 
            this.combobox_dither.BackColor = System.Drawing.Color.Black;
            this.combobox_dither.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_dither.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_dither.ForeColor = System.Drawing.Color.White;
            this.combobox_dither.FormattingEnabled = true;
            this.combobox_dither.Items.AddRange(new object[] {
            "(None)",
            "Floyd-Steinberg",
            "Ja-Ju-Ni",
            "Stucki",
            "Sierra-3",
            "Sierra-2",
            "Sierra Lite"});
            this.combobox_dither.Location = new System.Drawing.Point(505, 239);
            this.combobox_dither.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_dither.Name = "combobox_dither";
            this.combobox_dither.Size = new System.Drawing.Size(162, 20);
            this.combobox_dither.TabIndex = 19;
            this.toolTipMaster.SetToolTip(this.combobox_dither, "Select the error diffusion method to make images look smoother");
            this.combobox_dither.SelectedIndexChanged += new System.EventHandler(this.OnComboboxDitherSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(502, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dithering Mode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(65, 381);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(545, 12);
            this.label6.TabIndex = 21;
            this.label6.Text = "(This will look like jibberish. Simply copy and paste this into the Public Text o" +
    "f an LCD)";
            // 
            // combobox_resize
            // 
            this.combobox_resize.BackColor = System.Drawing.Color.Black;
            this.combobox_resize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combobox_resize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_resize.ForeColor = System.Drawing.Color.White;
            this.combobox_resize.FormattingEnabled = true;
            this.combobox_resize.Items.AddRange(new object[] {
            "Square (178x178)",
            "Wide (356x178)",
            "Large Grid Corner (178x27)",
            "Small Grid Corner (178x47)",
            "(Custom)",
            "(None)"});
            this.combobox_resize.Location = new System.Drawing.Point(319, 239);
            this.combobox_resize.Margin = new System.Windows.Forms.Padding(2);
            this.combobox_resize.Name = "combobox_resize";
            this.combobox_resize.Size = new System.Drawing.Size(162, 20);
            this.combobox_resize.TabIndex = 22;
            this.toolTipMaster.SetToolTip(this.combobox_resize, "Select the type of text panel to display the image on");
            this.combobox_resize.SelectedIndexChanged += new System.EventHandler(this.OnComboboxResizeSelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(317, 223);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "Resizing Option:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(317, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "Image File Path:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(119, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "(Click image to enlarge)";
            // 
            // checkBox_aspectratio
            // 
            this.checkBox_aspectratio.AutoSize = true;
            this.checkBox_aspectratio.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_aspectratio.Checked = true;
            this.checkBox_aspectratio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_aspectratio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_aspectratio.ForeColor = System.Drawing.Color.White;
            this.checkBox_aspectratio.Location = new System.Drawing.Point(319, 311);
            this.checkBox_aspectratio.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_aspectratio.Name = "checkBox_aspectratio";
            this.checkBox_aspectratio.Size = new System.Drawing.Size(150, 16);
            this.checkBox_aspectratio.TabIndex = 26;
            this.checkBox_aspectratio.Text = "Maintain Aspect Ratio";
            this.toolTipMaster.SetToolTip(this.checkBox_aspectratio, "Will use black bars to maintain the aspect ratio of an image");
            this.checkBox_aspectratio.UseVisualStyleBackColor = false;
            this.checkBox_aspectratio.CheckedChanged += new System.EventHandler(this.OnCheckBoxAspectRatioCheckedChanged);
            // 
            // buttonRotateCW
            // 
            this.buttonRotateCW.BackColor = System.Drawing.Color.White;
            this.buttonRotateCW.BackgroundImage = global::WhipsImageConverter.Properties.Resources.CW_arrow;
            this.buttonRotateCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotateCW.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotateCW.Location = new System.Drawing.Point(10, 282);
            this.buttonRotateCW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotateCW.Name = "buttonRotateCW";
            this.buttonRotateCW.Size = new System.Drawing.Size(26, 26);
            this.buttonRotateCW.TabIndex = 27;
            this.buttonRotateCW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipMaster.SetToolTip(this.buttonRotateCW, "Rotate clockwise");
            this.buttonRotateCW.UseVisualStyleBackColor = false;
            this.buttonRotateCW.Click += new System.EventHandler(this.OnButtonRotateCWClick);
            // 
            // buttonRotateCCW
            // 
            this.buttonRotateCCW.BackColor = System.Drawing.Color.White;
            this.buttonRotateCCW.BackgroundImage = global::WhipsImageConverter.Properties.Resources.CCW_arrow;
            this.buttonRotateCCW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotateCCW.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRotateCCW.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotateCCW.Location = new System.Drawing.Point(269, 282);
            this.buttonRotateCCW.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRotateCCW.Name = "buttonRotateCCW";
            this.buttonRotateCCW.Size = new System.Drawing.Size(26, 26);
            this.buttonRotateCCW.TabIndex = 28;
            this.toolTipMaster.SetToolTip(this.buttonRotateCCW, "Rotate counter-clockwise");
            this.buttonRotateCCW.UseVisualStyleBackColor = false;
            this.buttonRotateCCW.Click += new System.EventHandler(this.OnButtonRotateCCWClick);
            // 
            // buttonFlipHorizontal
            // 
            this.buttonFlipHorizontal.BackColor = System.Drawing.Color.White;
            this.buttonFlipHorizontal.BackgroundImage = global::WhipsImageConverter.Properties.Resources.Double_headed_arrow;
            this.buttonFlipHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipHorizontal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipHorizontal.Location = new System.Drawing.Point(135, 282);
            this.buttonFlipHorizontal.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFlipHorizontal.Name = "buttonFlipHorizontal";
            this.buttonFlipHorizontal.Size = new System.Drawing.Size(26, 26);
            this.buttonFlipHorizontal.TabIndex = 29;
            this.toolTipMaster.SetToolTip(this.buttonFlipHorizontal, "Flip horizontally");
            this.buttonFlipHorizontal.UseVisualStyleBackColor = false;
            this.buttonFlipHorizontal.Click += new System.EventHandler(this.OnButtonFlipHorizontalClick);
            // 
            // buttonFlipVertical
            // 
            this.buttonFlipVertical.BackColor = System.Drawing.Color.White;
            this.buttonFlipVertical.BackgroundImage = global::WhipsImageConverter.Properties.Resources.Double_headed_arrow_rotated;
            this.buttonFlipVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFlipVertical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFlipVertical.Location = new System.Drawing.Point(166, 282);
            this.buttonFlipVertical.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFlipVertical.Name = "buttonFlipVertical";
            this.buttonFlipVertical.Size = new System.Drawing.Size(26, 26);
            this.buttonFlipVertical.TabIndex = 30;
            this.toolTipMaster.SetToolTip(this.buttonFlipVertical, "Flip vertically");
            this.buttonFlipVertical.UseVisualStyleBackColor = false;
            this.buttonFlipVertical.Click += new System.EventHandler(this.OnButtonFlipVerticalClick);
            // 
            // buttonInvertColors
            // 
            this.buttonInvertColors.BackColor = System.Drawing.Color.White;
            this.buttonInvertColors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInvertColors.BackgroundImage")));
            this.buttonInvertColors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInvertColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInvertColors.Location = new System.Drawing.Point(105, 282);
            this.buttonInvertColors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInvertColors.Name = "buttonInvertColors";
            this.buttonInvertColors.Size = new System.Drawing.Size(26, 26);
            this.buttonInvertColors.TabIndex = 42;
            this.toolTipMaster.SetToolTip(this.buttonInvertColors, "Invert colors");
            this.buttonInvertColors.UseVisualStyleBackColor = false;
            this.buttonInvertColors.Click += new System.EventHandler(this.OnButtonInvertColorsClick);
            // 
            // buttonUpdateResolution
            // 
            this.buttonUpdateResolution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.buttonUpdateResolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateResolution.Enabled = false;
            this.buttonUpdateResolution.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateResolution.ForeColor = System.Drawing.Color.White;
            this.buttonUpdateResolution.Location = new System.Drawing.Point(435, 281);
            this.buttonUpdateResolution.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateResolution.Name = "buttonUpdateResolution";
            this.buttonUpdateResolution.Size = new System.Drawing.Size(106, 25);
            this.buttonUpdateResolution.TabIndex = 37;
            this.buttonUpdateResolution.Text = "Update Resolution";
            this.toolTipMaster.SetToolTip(this.buttonUpdateResolution, "Update preview with custom resolution");
            this.buttonUpdateResolution.UseVisualStyleBackColor = false;
            this.buttonUpdateResolution.Click += new System.EventHandler(this.OnButtonUpdateResolutionClick);
            // 
            // button_background_color
            // 
            this.button_background_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_background_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_background_color.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_background_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_background_color.ForeColor = System.Drawing.Color.White;
            this.button_background_color.Location = new System.Drawing.Point(514, 315);
            this.button_background_color.Margin = new System.Windows.Forms.Padding(2);
            this.button_background_color.Name = "button_background_color";
            this.button_background_color.Size = new System.Drawing.Size(152, 25);
            this.button_background_color.TabIndex = 38;
            this.button_background_color.Text = "Change Background Color";
            this.toolTipMaster.SetToolTip(this.button_background_color, "Change color of the background");
            this.button_background_color.UseVisualStyleBackColor = false;
            this.button_background_color.Click += new System.EventHandler(this.OnButtonBackgroundColorClick);
            // 
            // pictureBox_background_color
            // 
            this.pictureBox_background_color.BackColor = System.Drawing.Color.Black;
            this.pictureBox_background_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_background_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_background_color.Location = new System.Drawing.Point(485, 315);
            this.pictureBox_background_color.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_background_color.Name = "pictureBox_background_color";
            this.pictureBox_background_color.Size = new System.Drawing.Size(24, 25);
            this.pictureBox_background_color.TabIndex = 39;
            this.pictureBox_background_color.TabStop = false;
            this.toolTipMaster.SetToolTip(this.pictureBox_background_color, "Change color of aspect ratio bars");
            this.pictureBox_background_color.Click += new System.EventHandler(this.OnPictureBoxBackgroundColorClick);
            // 
            // checkBoxTransparency
            // 
            this.checkBoxTransparency.AutoSize = true;
            this.checkBoxTransparency.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxTransparency.Checked = true;
            this.checkBoxTransparency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTransparency.ForeColor = System.Drawing.Color.White;
            this.checkBoxTransparency.Location = new System.Drawing.Point(319, 333);
            this.checkBoxTransparency.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTransparency.Name = "checkBoxTransparency";
            this.checkBoxTransparency.Size = new System.Drawing.Size(150, 16);
            this.checkBoxTransparency.TabIndex = 43;
            this.checkBoxTransparency.Text = "Preserve Transparency";
            this.toolTipMaster.SetToolTip(this.checkBoxTransparency, "Preserve source image\'s transparent pixels");
            this.checkBoxTransparency.UseVisualStyleBackColor = false;
            this.checkBoxTransparency.CheckedChanged += new System.EventHandler(this.OnCheckBoxTransparencyCheckedChanged);
            // 
            // button_DirBrowse
            // 
            this.button_DirBrowse.BackColor = System.Drawing.Color.Gray;
            this.button_DirBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DirBrowse.Enabled = false;
            this.button_DirBrowse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_DirBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DirBrowse.ForeColor = System.Drawing.Color.White;
            this.button_DirBrowse.Location = new System.Drawing.Point(595, 193);
            this.button_DirBrowse.Margin = new System.Windows.Forms.Padding(2);
            this.button_DirBrowse.Name = "button_DirBrowse";
            this.button_DirBrowse.Size = new System.Drawing.Size(60, 29);
            this.button_DirBrowse.TabIndex = 46;
            this.button_DirBrowse.Text = "Browse";
            this.toolTipMaster.SetToolTip(this.button_DirBrowse, "Browse for file");
            this.button_DirBrowse.UseVisualStyleBackColor = false;
            this.button_DirBrowse.Click += new System.EventHandler(this.button_DirBrowse_Click);
            // 
            // checkBox_isDirMode
            // 
            this.checkBox_isDirMode.AutoSize = true;
            this.checkBox_isDirMode.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_isDirMode.ForeColor = System.Drawing.Color.White;
            this.checkBox_isDirMode.Location = new System.Drawing.Point(319, 355);
            this.checkBox_isDirMode.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_isDirMode.Name = "checkBox_isDirMode";
            this.checkBox_isDirMode.Size = new System.Drawing.Size(156, 16);
            this.checkBox_isDirMode.TabIndex = 47;
            this.checkBox_isDirMode.Text = "Directory Convert Mode";
            this.toolTipMaster.SetToolTip(this.checkBox_isDirMode, "Preserve source image\'s transparent pixels");
            this.checkBox_isDirMode.UseVisualStyleBackColor = false;
            this.checkBox_isDirMode.CheckedChanged += new System.EventHandler(this.checkBox_isDirMode_CheckedChanged);
            // 
            // button_ConvertDir
            // 
            this.button_ConvertDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_ConvertDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ConvertDir.Enabled = false;
            this.button_ConvertDir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_ConvertDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ConvertDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConvertDir.ForeColor = System.Drawing.Color.White;
            this.button_ConvertDir.Location = new System.Drawing.Point(210, 465);
            this.button_ConvertDir.Margin = new System.Windows.Forms.Padding(2);
            this.button_ConvertDir.Name = "button_ConvertDir";
            this.button_ConvertDir.Size = new System.Drawing.Size(290, 38);
            this.button_ConvertDir.TabIndex = 48;
            this.button_ConvertDir.Text = "Convert and Open Directory";
            this.toolTipMaster.SetToolTip(this.button_ConvertDir, "Convert the image to monospace and automatically copy to system clipboard");
            this.button_ConvertDir.UseVisualStyleBackColor = false;
            this.button_ConvertDir.Visible = false;
            this.button_ConvertDir.Click += new System.EventHandler(this.button_ConvertDir_Click);
            // 
            // backgroundWorkerDithering
            // 
            this.backgroundWorkerDithering.WorkerReportsProgress = true;
            this.backgroundWorkerDithering.WorkerSupportsCancellation = true;
            this.backgroundWorkerDithering.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnBackgroundWorkerDitheringDoWork);
            this.backgroundWorkerDithering.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.OnBackgroundWorkerDitheringProgressChanged);
            this.backgroundWorkerDithering.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnBackgroundWorkerDitheringRunWorkerCompleted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(317, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 12);
            this.label10.TabIndex = 33;
            this.label10.Text = "Custom Resoultion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(370, 287);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "x";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.BackColor = System.Drawing.Color.Black;
            this.numericUpDownWidth.Enabled = false;
            this.numericUpDownWidth.ForeColor = System.Drawing.Color.White;
            this.numericUpDownWidth.Location = new System.Drawing.Point(319, 285);
            this.numericUpDownWidth.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownWidth.Size = new System.Drawing.Size(46, 21);
            this.numericUpDownWidth.TabIndex = 35;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.BackColor = System.Drawing.Color.Black;
            this.numericUpDownHeight.Enabled = false;
            this.numericUpDownHeight.ForeColor = System.Drawing.Color.White;
            this.numericUpDownHeight.Location = new System.Drawing.Point(384, 285);
            this.numericUpDownHeight.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownHeight.Size = new System.Drawing.Size(46, 21);
            this.numericUpDownHeight.TabIndex = 36;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // backgroundWorkerUpdate
            // 
            this.backgroundWorkerUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnBackgroundWorkerUpdateDoWork);
            // 
            // linkLabel_GitHub
            // 
            this.linkLabel_GitHub.AutoSize = true;
            this.linkLabel_GitHub.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_GitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.linkLabel_GitHub.Location = new System.Drawing.Point(13, 516);
            this.linkLabel_GitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(41, 12);
            this.linkLabel_GitHub.TabIndex = 40;
            this.linkLabel_GitHub.TabStop = true;
            this.linkLabel_GitHub.Text = "GitHub";
            this.linkLabel_GitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelGitHubClicked);
            // 
            // backgroundWorkerInvert
            // 
            this.backgroundWorkerInvert.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OnBackgroundWorkerInvertDoWork);
            this.backgroundWorkerInvert.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnBackgroundWorkerInvertRunWorkerCompleted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(317, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 12);
            this.label12.TabIndex = 44;
            this.label12.Text = "Images Directory:";
            // 
            // textBox_DirPath
            // 
            this.textBox_DirPath.BackColor = System.Drawing.Color.Gray;
            this.textBox_DirPath.Enabled = false;
            this.textBox_DirPath.ForeColor = System.Drawing.Color.White;
            this.textBox_DirPath.Location = new System.Drawing.Point(319, 198);
            this.textBox_DirPath.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DirPath.Name = "textBox_DirPath";
            this.textBox_DirPath.ReadOnly = true;
            this.textBox_DirPath.Size = new System.Drawing.Size(268, 21);
            this.textBox_DirPath.TabIndex = 45;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(690, 541);
            this.Controls.Add(this.button_ConvertDir);
            this.Controls.Add(this.checkBox_isDirMode);
            this.Controls.Add(this.button_DirBrowse);
            this.Controls.Add(this.textBox_DirPath);
            this.Controls.Add(this.label12);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Whip\'s Image Converter (Version <num> - <date>) - Mod by stpog";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnMainFormPaint);
            ((System.ComponentModel.ISupportInitialize)(this.ImagePreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_background_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_DirPath;
        private System.Windows.Forms.Button button_DirBrowse;
        private System.Windows.Forms.CheckBox checkBox_isDirMode;
        private System.Windows.Forms.Button button_ConvertDir;
    }
}

