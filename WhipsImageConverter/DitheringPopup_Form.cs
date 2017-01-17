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
    public partial class DitheringPopup : Form
    {
        public DitheringPopup(int mode)
        {
            InitializeComponent();
            ShowImages(mode);
        }

        private void ShowImages(int mode)
        {
            /*var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            using (var imgStream = assembly.GetManifestResourceStream("WhipsImageConverter.original.png"))
            {
                var img = new Bitmap(imgStream);
                OriginalBox.Image = img;
            }

            using (var imgStream = assembly.GetManifestResourceStream("WhipsImageConverter.dithering.png"))
            {
                var img = new Bitmap(imgStream);
                DitherBox.Image = img;
            }

            using (var imgStream = assembly.GetManifestResourceStream("WhipsImageConverter.nodithering.png"))
            {
                var img = new Bitmap(imgStream);
                NoDitherBox.Image = img;
            }*/

            Bitmap originalBmp;
            Bitmap ditheringBmp;
            Bitmap noditheringBmp;

            if (mode == 1)
            {
                originalBmp = new Bitmap(Properties.Resources.original);
                ditheringBmp = new Bitmap(Properties.Resources.dithering);
                noditheringBmp = new Bitmap(Properties.Resources.nodithering);
            }
            else
            {
                originalBmp = new Bitmap(Properties.Resources.nasa_original);
                ditheringBmp = new Bitmap(Properties.Resources.nasa_dither);
                noditheringBmp = new Bitmap(Properties.Resources.nasa_nodither);
            }

            OriginalBox.Image = originalBmp;
            DitherBox.Image = ditheringBmp;
            NoDitherBox.Image = noditheringBmp;
        }
    }
}
