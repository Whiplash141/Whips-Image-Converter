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

namespace WhipsImageConverter
{
    public partial class EnlargedImageForm : Form
    {
        public EnlargedImageForm(Bitmap convertedImage)
        {
            InitializeComponent();
            picturebox_imagepopup.Image = convertedImage;
        }

        private void OnButton1Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PNG Image|*.png|Bitmap Image|*.bmp|JPEG Image|*.jpg";
            saveFileDialog.Title = "Save Converted Image File";
            saveFileDialog.ShowDialog();
        }

        private void OnSaveFileDialogFileOk(object sender, CancelEventArgs e)
        {
            string imageSavePath = saveFileDialog.FileName;

            switch (saveFileDialog.FilterIndex)
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
