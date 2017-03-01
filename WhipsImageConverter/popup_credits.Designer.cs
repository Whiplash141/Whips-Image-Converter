namespace WhipsImageConverter
{
    partial class popup_credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popup_credits));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.link_wiki = new System.Windows.Forms.LinkLabel();
            this.link_stackOverflow = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.link_tanner = new System.Windows.Forms.LinkLabel();
            this.link_efg2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dithering methods obtained from:\r\n                 ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Color3 method based off of StackExchange user dacwe\'s Java code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Additional help, testing, and debugging provided by:";
            // 
            // link_wiki
            // 
            this.link_wiki.AutoSize = true;
            this.link_wiki.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_wiki.Location = new System.Drawing.Point(22, 39);
            this.link_wiki.Name = "link_wiki";
            this.link_wiki.Size = new System.Drawing.Size(426, 17);
            this.link_wiki.TabIndex = 3;
            this.link_wiki.TabStop = true;
            this.link_wiki.Text = "https://en.wikipedia.org/wiki/Floyd%E2%80%93Steinberg_dithering\r\n";
            this.link_wiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_wiki_LinkClicked);
            // 
            // link_stackOverflow
            // 
            this.link_stackOverflow.AutoSize = true;
            this.link_stackOverflow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_stackOverflow.Location = new System.Drawing.Point(22, 136);
            this.link_stackOverflow.Name = "link_stackOverflow";
            this.link_stackOverflow.Size = new System.Drawing.Size(749, 17);
            this.link_stackOverflow.TabIndex = 4;
            this.link_stackOverflow.TabStop = true;
            this.link_stackOverflow.Text = "https://stackoverflow.com/questions/5940188/how-to-convert-a-24-bit-png-to-3-bit-" +
    "png-using-floyd-steinberg-dithering";
            this.link_stackOverflow.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_stackOverflow_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "Violinninja8\r\nDarkInferno\r\nJonnytaco";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // link_tanner
            // 
            this.link_tanner.AutoSize = true;
            this.link_tanner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_tanner.Location = new System.Drawing.Point(22, 60);
            this.link_tanner.Name = "link_tanner";
            this.link_tanner.Size = new System.Drawing.Size(492, 17);
            this.link_tanner.TabIndex = 6;
            this.link_tanner.TabStop = true;
            this.link_tanner.Text = "http://www.tannerhelland.com/4660/dithering-eleven-algorithms-source-code/";
            this.link_tanner.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_tanner_LinkClicked);
            // 
            // link_efg2
            // 
            this.link_efg2.AutoSize = true;
            this.link_efg2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.link_efg2.Location = new System.Drawing.Point(22, 81);
            this.link_efg2.Name = "link_efg2";
            this.link_efg2.Size = new System.Drawing.Size(401, 17);
            this.link_efg2.TabIndex = 7;
            this.link_efg2.TabStop = true;
            this.link_efg2.Text = "http://www.efg2.com/Lab/Library/ImageProcessing/DHALF.TXT";
            this.link_efg2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_efg2_LinkClicked);
            // 
            // popup_credits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 274);
            this.Controls.Add(this.link_efg2);
            this.Controls.Add(this.link_tanner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.link_stackOverflow);
            this.Controls.Add(this.link_wiki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "popup_credits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acknowledgements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel link_wiki;
        private System.Windows.Forms.LinkLabel link_stackOverflow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel link_tanner;
        private System.Windows.Forms.LinkLabel link_efg2;
    }
}