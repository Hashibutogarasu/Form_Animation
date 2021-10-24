using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitter.Utils.RegexUtils;
using Twitter.Utils.ImageUtils;

namespace Twitter.Utils.OpacityUtils
{
    public static class PictureBoxExtensions
    {
        public static void Opacity_change(this PictureBox pictureBox, string imagepath, Single Matrix33)
        {
            Bitmap canvas = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(canvas);

            if (RegexUtil.IsUrl(imagepath))
            {
                Image img = ImageUtil.loadImageFromURL(imagepath);

                System.Drawing.Imaging.ColorMatrix cm =
                new System.Drawing.Imaging.ColorMatrix();
                cm.Matrix00 = 1;
                cm.Matrix11 = 1;
                cm.Matrix22 = 1;
                cm.Matrix33 = Matrix33;
                cm.Matrix44 = 1;

                System.Drawing.Imaging.ImageAttributes ia =
                    new System.Drawing.Imaging.ImageAttributes();
                ia.SetColorMatrix(cm);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                    0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                img.Dispose();
                g.Dispose();

                pictureBox.Image = canvas;
            }
            else
            {
                Image img = Image.FromFile(imagepath);
                
                System.Drawing.Imaging.ColorMatrix cm =
                new System.Drawing.Imaging.ColorMatrix();
                cm.Matrix00 = 1;
                cm.Matrix11 = 1;
                cm.Matrix22 = 1;
                cm.Matrix33 = Matrix33;
                cm.Matrix44 = 1;

                System.Drawing.Imaging.ImageAttributes ia =
                    new System.Drawing.Imaging.ImageAttributes();
                ia.SetColorMatrix(cm);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height),
                    0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                img.Dispose();
                g.Dispose();

                pictureBox.Image = canvas;
            }
        }
    }
}
