namespace WhipsImageConverter
{
    partial class ImageLoadProgressForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageLoadProgressForm));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_progress = new System.Windows.Forms.Label();
            this.buttonCancelLoading = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(470, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // label_progress
            // 
            this.label_progress.AutoSize = true;
            this.label_progress.Location = new System.Drawing.Point(214, 9);
            this.label_progress.Name = "label_progress";
            this.label_progress.Size = new System.Drawing.Size(93, 17);
            this.label_progress.TabIndex = 1;
            this.label_progress.Text = "Progress: 0%";
            // 
            // buttonCancelLoading
            // 
            this.buttonCancelLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCancelLoading.BackgroundImage")));
            this.buttonCancelLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCancelLoading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelLoading.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelLoading.Location = new System.Drawing.Point(419, -2);
            this.buttonCancelLoading.Name = "buttonCancelLoading";
            this.buttonCancelLoading.Size = new System.Drawing.Size(63, 38);
            this.buttonCancelLoading.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonCancelLoading, "This will \"nuke\" the entire program! Using this will abort the loading process an" +
        "d close the program.");
            this.buttonCancelLoading.UseVisualStyleBackColor = true;
            this.buttonCancelLoading.Click += new System.EventHandler(this.buttonCancelLoading_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // ImageLoadProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancelLoading;
            this.ClientSize = new System.Drawing.Size(494, 69);
            this.ControlBox = false;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCancelLoading);
            this.Controls.Add(this.label_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageLoadProgressForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_progress;
        private System.Windows.Forms.Button buttonCancelLoading;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}