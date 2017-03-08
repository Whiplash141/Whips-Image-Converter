using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhipsImageConverter
{
    public partial class ImageLoadProgressForm : Form
    {
        //string labelText = "Progress: 0%";
        //int progressValue = 0;

        public ImageLoadProgressForm()
        {
            InitializeComponent();
        }

        public void SetProgressBarValue(int inputValue)
        {
            progressBar1.Value = inputValue;
            label_progress.Text = $"Progress: {inputValue}%";
            Update();
        }

        private void buttonCancelLoading_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Abort;
        }
        /*
            this.Close();
            this.DialogResult = DialogResult.Abort;
         */
    }
}
