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

        public ImageLoadProgressForm()
        {
            InitializeComponent();
            label_progress.Text = "Progress: 0%";
            progressBar1.Value = 0;
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
    }
}
