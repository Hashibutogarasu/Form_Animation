using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Twitter.Utils.RegexUtils;
using Twitter.Utils.ImageUtils;
using Twitter.Utils.OpacityUtils;

namespace Twitter.Extentions.PictureboxAnimation
{
    public static class PictureBoxExtensions
    {
        /// <summary>
        /// PicturBoxをフェードアウトします。
        /// </summary>
        public static async void Fadeout(this PictureBox pictureBox, string imagepath, float Start = 1F, float End = 0F, float decrease = 0.1F, int delay = 10)
        {
            for (float i = Start; i >= End; i -= decrease)
            {
                pictureBox.Opacity_change(imagepath, i);

                await Task.Delay(delay);
            }

            pictureBox.Opacity_change(imagepath, End);

            pictureBox.Visible = false;
        }

        /// <summary>
        /// PicturBoxをフェードインします。
        /// </summary>
        public static async void Fadein(this PictureBox pictureBox, string imagepath)
        {
            pictureBox.Visible = true;

            for (int i = 1; i <= 10; i++)
            {
                //半透明で画像を描画
                pictureBox.Opacity_change(imagepath, i * 0.1F);
                //一時停止
                await Task.Delay(10);
            }
        }
    }
}
