using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            Theme();
        }

        private void Theme()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);
                label1.ForeColor = Color.FromArgb(172, 176, 180);
                label1.Location = new Point(6, 15);
                label1.Text = "Initializing loader please wait...";
            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);
                label1.ForeColor = Color.FromArgb(138, 144, 149);
                label1.Location = new Point(6, 15);
                label1.Text = "Initializing loader please wait...";
            }
        }

        public enum Loader
        {
            wait,
            start,
            close
        }

        private Splash.Loader action;

        private int x, y;

        private void fade_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case Loader.wait:
                    fade.Interval = 3000;
                    action = Loader.close;
                    break;
                case Splash.Loader.start:
                    this.fade.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = Splash.Loader.wait;
                        }
                    }
                    break;
                case Loader.close:
                    fade.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "loader" + i.ToString();
                Splash frm = (Splash)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;

            this.Show();
            this.action = Loader.start;
            this.fade.Interval = 1;
            this.fade.Start();
        }
    }
}
