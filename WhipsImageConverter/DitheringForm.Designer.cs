namespace WhipsImageConverter
{
    partial class DitheringForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DitheringForm));
            this.OriginalBox = new System.Windows.Forms.PictureBox();
            this.NoDitherBox = new System.Windows.Forms.PictureBox();
            this.DitherBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoDitherBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DitherBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginalBox
            // 
            this.OriginalBox.Location = new System.Drawing.Point(29, 32);
            this.OriginalBox.Name = "OriginalBox";
            this.OriginalBox.Size = new System.Drawing.Size(340, 340);
            this.OriginalBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.OriginalBox.TabIndex = 2;
            this.OriginalBox.TabStop = false;
            // 
            // NoDitherBox
            // 
            this.NoDitherBox.Location = new System.Drawing.Point(430, 32);
            this.NoDitherBox.Name = "NoDitherBox";
            this.NoDitherBox.Size = new System.Drawing.Size(340, 340);
            this.NoDitherBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NoDitherBox.TabIndex = 1;
            this.NoDitherBox.TabStop = false;
            // 
            // DitherBox
            // 
            this.DitherBox.Location = new System.Drawing.Point(831, 32);
            this.DitherBox.Name = "DitherBox";
            this.DitherBox.Size = new System.Drawing.Size(340, 340);
            this.DitherBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DitherBox.TabIndex = 0;
            this.DitherBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "No Dithering";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(955, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dithering";
            // 
            // DitheringPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 392);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OriginalBox);
            this.Controls.Add(this.NoDitherBox);
            this.Controls.Add(this.DitherBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DitheringPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dithering Example";
            ((System.ComponentModel.ISupportInitialize)(this.OriginalBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoDitherBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DitherBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DitherBox;
        private System.Windows.Forms.PictureBox NoDitherBox;
        private System.Windows.Forms.PictureBox OriginalBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}