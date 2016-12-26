using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;

namespace WindowsForms2
{
    public partial class popup_imagebox : Form
    {
        public popup_imagebox(Bitmap convertedImage)
        {
            InitializeComponent();
            picturebox_imagepopup.Image = convertedImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
            saveFileDialog1.Title = "Save Converted Image File";
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string imageSavePath = saveFileDialog1.FileName;

            switch (saveFileDialog1.FilterIndex)
            {
                case 1:
                    picturebox_imagepopup.Image.Save(imageSavePath, ImageFormat.Png);
                    break;

                case 2:
                    picturebox_imagepopup.Image.Save(imageSavePath, ImageFormat.Bmp);
                    break;

                case 3:
                    picturebox_imagepopup.Image.Save(imageSavePath, ImageFormat.Jpeg);
                    break;
            }
        }
    }
}
