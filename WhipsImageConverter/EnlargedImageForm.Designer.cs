namespace WhipsImageConverter
{
    partial class EnlargedImageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnlargedImageForm));
            this.picturebox_imagepopup = new System.Windows.Forms.PictureBox();
            this.button_saveimage = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_imagepopup)).BeginInit();
            this.SuspendLayout();
            // 
            // picturebox_imagepopup
            // 
            this.picturebox_imagepopup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturebox_imagepopup.Location = new System.Drawing.Point(9, 10);
            this.picturebox_imagepopup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picturebox_imagepopup.Name = "picturebox_imagepopup";
            this.picturebox_imagepopup.Size = new System.Drawing.Size(610, 362);
            this.picturebox_imagepopup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_imagepopup.TabIndex = 0;
            this.picturebox_imagepopup.TabStop = false;
            // 
            // button_saveimage
            // 
            this.button_saveimage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_saveimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_saveimage.Location = new System.Drawing.Point(266, 384);
            this.button_saveimage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_saveimage.Name = "button_saveimage";
            this.button_saveimage.Size = new System.Drawing.Size(94, 29);
            this.button_saveimage.TabIndex = 1;
            this.button_saveimage.Text = "Save Image";
            this.button_saveimage.UseVisualStyleBackColor = true;
            this.button_saveimage.Click += new System.EventHandler(this.OnButton1Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog.DefaultExt = "png";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OnSaveFileDialogFileOk);
            // 
            // popup_imagebox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 422);
            this.Controls.Add(this.button_saveimage);
            this.Controls.Add(this.picturebox_imagepopup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "popup_imagebox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Preview";
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_imagepopup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebox_imagepopup;
        private System.Windows.Forms.Button button_saveimage;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}