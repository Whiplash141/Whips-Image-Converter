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
            this.comboBoxDither = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxBlock = new System.Windows.Forms.ComboBox();
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
            this.comboBoxSurface = new System.Windows.Forms.ComboBox();
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
            this.textBox_FileDirectory.Size = new System.Drawing.Size(268, 20);
            this.textBox_FileDirectory.TabIndex = 8;
            // 
            // textBox_Return
            // 
            this.textBox_Return.BackColor = System.Drawing.Color.Black;
            this.textBox_Return.ForeColor = System.Drawing.Color.White;
            this.textBox_Return.Location = new System.Drawing.Point(65, 358);
            this.textBox_Return.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Return.Multiline = true;
            this.textBox_Return.Name = "textBox_Return";
            this.textBox_Return.ReadOnly = true;
            this.textBox_Return.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Return.Size = new System.Drawing.Size(714, 65);
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
            this.label1.Location = new System.Drawing.Point(55, 322);
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
            this.button_Clipboard.Location = new System.Drawing.Point(285, 427);
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
            this.label3.Location = new System.Drawing.Point(11, 460);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
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
            this.instructions.Size = new System.Drawing.Size(523, 109);
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
            this.linkLabel_Credits.Location = new System.Drawing.Point(59, 477);
            this.linkLabel_Credits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_Credits.Name = "linkLabel_Credits";
            this.linkLabel_Credits.Size = new System.Drawing.Size(100, 13);
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
            this.label_stringLength.Location = new System.Drawing.Point(681, 342);
            this.label_stringLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_stringLength.Name = "label_stringLength";
            this.label_stringLength.Size = new System.Drawing.Size(98, 13);
            this.label_stringLength.TabIndex = 18;
            this.label_stringLength.Text = "String Length: 0";
            // 
            // comboBoxDither
            // 
            this.comboBoxDither.BackColor = System.Drawing.Color.Black;
            this.comboBoxDither.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxDither.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDither.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDither.ForeColor = System.Drawing.Color.White;
            this.comboBoxDither.FormattingEnabled = true;
            this.comboBoxDither.Items.AddRange(new object[] {
            "(None)",
            "Floyd-Steinberg",
            "Ja-Ju-Ni",
            "Stucki",
            "Sierra-3",
            "Sierra-2",
            "Sierra Lite"});
            this.comboBoxDither.Location = new System.Drawing.Point(669, 200);
            this.comboBoxDither.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDither.MaxDropDownItems = 15;
            this.comboBoxDither.Name = "comboBoxDither";
            this.comboBoxDither.Size = new System.Drawing.Size(161, 21);
            this.comboBoxDither.TabIndex = 19;
            this.toolTipMaster.SetToolTip(this.comboBoxDither, "Select the error diffusion method to make images look smoother");
            this.comboBoxDither.SelectedIndexChanged += new System.EventHandler(this.OnComboboxDitherSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(666, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Dithering Mode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(63, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(409, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "(This will look like jibberish. Simply copy and paste this into the Public Text o" +
    "f an LCD)";
            // 
            // comboBoxBlock
            // 
            this.comboBoxBlock.BackColor = System.Drawing.Color.Black;
            this.comboBoxBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxBlock.ForeColor = System.Drawing.Color.White;
            this.comboBoxBlock.FormattingEnabled = true;
            this.comboBoxBlock.Items.AddRange(new object[] {
            "Square (178x178)",
            "Wide (356x178)",
            "Large Grid Corner (178x27)",
            "Small Grid Corner (178x47)",
            "(Custom)",
            "(None)"});
            this.comboBoxBlock.Location = new System.Drawing.Point(320, 200);
            this.comboBoxBlock.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBlock.MaxDropDownItems = 15;
            this.comboBoxBlock.Name = "comboBoxBlock";
            this.comboBoxBlock.Size = new System.Drawing.Size(162, 21);
            this.comboBoxBlock.TabIndex = 22;
            this.toolTipMaster.SetToolTip(this.comboBoxBlock, "Select the type of text panel to display the image on");
            this.comboBoxBlock.SelectedIndexChanged += new System.EventHandler(this.OnComboboxResizeSelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(318, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Surface Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(317, 132);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
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
            this.label9.Size = new System.Drawing.Size(117, 13);
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
            this.checkBox_aspectratio.Location = new System.Drawing.Point(495, 258);
            this.checkBox_aspectratio.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_aspectratio.Name = "checkBox_aspectratio";
            this.checkBox_aspectratio.Size = new System.Drawing.Size(130, 17);
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
            this.buttonRotateCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonRotateCCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRotateCCW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.buttonFlipHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonFlipVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonInvertColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonUpdateResolution.Location = new System.Drawing.Point(320, 279);
            this.buttonUpdateResolution.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdateResolution.Name = "buttonUpdateResolution";
            this.buttonUpdateResolution.Size = new System.Drawing.Size(124, 25);
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
            this.button_background_color.Location = new System.Drawing.Point(678, 260);
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
            this.pictureBox_background_color.Location = new System.Drawing.Point(649, 260);
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
            this.checkBoxTransparency.Location = new System.Drawing.Point(495, 280);
            this.checkBoxTransparency.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxTransparency.Name = "checkBoxTransparency";
            this.checkBoxTransparency.Size = new System.Drawing.Size(136, 17);
            this.checkBoxTransparency.TabIndex = 43;
            this.checkBoxTransparency.Text = "Preserve Transparency";
            this.toolTipMaster.SetToolTip(this.checkBoxTransparency, "Preserve source image\'s transparent pixels");
            this.checkBoxTransparency.UseVisualStyleBackColor = false;
            this.checkBoxTransparency.CheckedChanged += new System.EventHandler(this.OnCheckBoxTransparencyCheckedChanged);
            // 
            // comboBoxSurface
            // 
            this.comboBoxSurface.BackColor = System.Drawing.Color.Black;
            this.comboBoxSurface.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSurface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSurface.ForeColor = System.Drawing.Color.White;
            this.comboBoxSurface.FormattingEnabled = true;
            this.comboBoxSurface.Items.AddRange(new object[] {
            "Square (178x178)",
            "Wide (356x178)",
            "Large Grid Corner (178x27)",
            "Small Grid Corner (178x47)",
            "(Custom)",
            "(None)"});
            this.comboBoxSurface.Location = new System.Drawing.Point(495, 200);
            this.comboBoxSurface.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSurface.MaxDropDownItems = 15;
            this.comboBoxSurface.Name = "comboBoxSurface";
            this.comboBoxSurface.Size = new System.Drawing.Size(162, 21);
            this.comboBoxSurface.TabIndex = 44;
            this.toolTipMaster.SetToolTip(this.comboBoxSurface, "Select the type of text panel to display the image on");
            this.comboBoxSurface.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSurface_SelectedIndexChanged);
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
            this.label10.Location = new System.Drawing.Point(317, 239);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Resoultion:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(370, 257);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "x";
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.BackColor = System.Drawing.Color.Black;
            this.numericUpDownWidth.Enabled = false;
            this.numericUpDownWidth.ForeColor = System.Drawing.Color.White;
            this.numericUpDownWidth.Location = new System.Drawing.Point(320, 255);
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
            this.numericUpDownWidth.Size = new System.Drawing.Size(60, 20);
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
            this.numericUpDownHeight.Location = new System.Drawing.Point(384, 255);
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
            this.numericUpDownHeight.Size = new System.Drawing.Size(60, 20);
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
            this.linkLabel_GitHub.Location = new System.Drawing.Point(11, 477);
            this.linkLabel_GitHub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel_GitHub.Name = "linkLabel_GitHub";
            this.linkLabel_GitHub.Size = new System.Drawing.Size(40, 13);
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
            this.label12.Location = new System.Drawing.Point(493, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Surface Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(849, 503);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBoxSurface);
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
            this.Controls.Add(this.comboBoxBlock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDither);
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
            this.Text = "Whip\'s Image Converter (Version <num> - <date>)";
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
        private System.Windows.Forms.ComboBox comboBoxDither;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxBlock;
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
        private System.Windows.Forms.ComboBox comboBoxSurface;
    }
}

