using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter.Utils.Controls
{
    class ControlUtil
    {
        /// <summary>
        /// 指定のコントロール上の全てのジェネリック型 Tコントロールを取得する。
        /// </summary>
        /// <typeparam name="T">対象となる型</typeparam>
        /// <param name="top">指定のコントロール</param>
        /// <returns>指定のコントロール上の全てのジェネリック型 Tコントロールのインスタンス</returns>
        public static List<T> GetAllControls<T>(Control top) where T : Control
        {
            List<T> buf = new List<T>();
            foreach (Control ctrl in top.Controls)
            {
                if (ctrl is T) buf.Add((T)ctrl);
                buf.AddRange(GetAllControls<T>(ctrl));
            }
            return buf;
        }
    }

    public static class PictureBoxExtensions
    {
        /// <summary>
        /// PicturBoxを中央に配置します。
        /// </summary>
        /// <typeparam Form="this">フォームのコントロール</typeparam>
        /// <returns>PictureBoxの中央のPoint値</returns>
        public static Point SetCenter(this PictureBox pictureBox,Form form)
        {
            pictureBox.Anchor = AnchorStyles.None;

            Point point = new Point((form.ClientSize.Width / 2) - (pictureBox.Width / 2), (form.ClientSize.Height / 2) - (pictureBox.Height / 2));

            pictureBox.Location = point;

            return pictureBox.Location;
        }
    }
}
