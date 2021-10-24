using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twitter.Properties;
using Twitter.Extentions.PictureboxAnimation;
using Twitter.Extentions.LabelAnimation;
using Twitter.Utils.OpacityUtils;
using System.Collections;
using Twitter.Utils.Controls;

namespace Twitter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Icon = Resources.icon;

            pictureBox1.SetCenter(this);

            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);            

            string cont = "";

            // コントロール全てを列挙
            List<Control> controls = ControlUtil.GetAllControls<Control>(this);
            System.Console.WriteLine("controls : " + controls.Count().ToString());
            foreach (var ctl in controls)
            {
                cont += ("control : " + ctl.Name) + Environment.NewLine;
                
                if (ctl.Name != "pictureBox1" && ctl.Name != "pictureBox2")
                {
                    this.Controls.Add(ctl);
                }
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(5000);

            pictureBox1.Fadeout("icon_42.png");
            pictureBox2.Fadeout("background.png");
        }

        private async void Form_Closing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            pictureBox1.Fadein("icon_42.png");
            pictureBox2.Fadein("background.png");

            await Task.Delay(2000);

            e.Cancel = false;

            Environment.Exit(1);
        }
    }
}
