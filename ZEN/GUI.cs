using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEN
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();

            // Changes title to random string just once before timer starts
            this.Text = Utilities.RandomString(15);

            // Sets applications colors for dark style theme
            Theme();
        }

        private void Theme()
        {
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);

                label1.BackColor = Color.FromArgb(39, 49, 61);
                label1.ForeColor = Color.FromArgb(172, 176, 180);

                label2.BackColor = Color.FromArgb(39, 49, 61);
                label2.ForeColor = Color.FromArgb(172, 176, 180);

                Sep.BackColor = Color.FromArgb(39, 49, 61);
                Sep.FillColor = Color.FromArgb(172, 176, 180);

                Checkbox.BackColor = Color.FromArgb(39, 49, 61);
                Checkbox.UncheckedState.FillColor = Color.FromArgb(39, 49, 61);
                Checkbox.UncheckedState.BorderColor = Color.FromArgb(172, 176, 180);
                Checkbox.CheckedState.FillColor = Color.FromArgb(39, 49, 61);
                Checkbox.CheckedState.BorderColor = Color.FromArgb(172, 176, 180);
                Checkbox.CheckMarkColor = Color.FromArgb(172, 176, 180);

                slider1.BackColor = Color.FromArgb(39, 49, 61);
                slider1.ForeColor = Color.FromArgb(39, 49, 61);
                slider1.SliderBackColor = Color.FromArgb(172, 176, 180);
                slider1.SliderForeColor = Color.FromArgb(39, 49, 61);
                slider1.TextColor = Color.White;

                ThemeToggle.FillColor = Color.FromArgb(172, 176, 180);
                ThemeToggle.ForeColor = Color.FromArgb(39, 49, 61);
            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);

                label1.BackColor = Color.FromArgb(255, 255, 255);
                label1.ForeColor = Color.FromArgb(138, 144, 149);

                label2.BackColor = Color.FromArgb(255, 255, 255);
                label2.ForeColor = Color.FromArgb(138, 144, 149);

                Sep.BackColor = Color.FromArgb(255, 255, 255);
                Sep.FillColor = Color.FromArgb(138, 144, 149);

                Checkbox.BackColor = Color.FromArgb(255, 255, 255);
                Checkbox.UncheckedState.FillColor = Color.FromArgb(255, 255, 255);
                Checkbox.UncheckedState.BorderColor = Color.FromArgb(138, 144, 149);
                Checkbox.CheckedState.FillColor = Color.FromArgb(255, 255, 255);
                Checkbox.CheckedState.BorderColor = Color.FromArgb(138, 144, 149);
                Checkbox.CheckMarkColor = Color.FromArgb(138, 144, 149);

                slider1.BackColor = Color.FromArgb(255, 255, 255);
                slider1.ForeColor = Color.FromArgb(255, 255, 255);
                slider1.SliderBackColor = Color.FromArgb(138, 144, 149);
                slider1.SliderForeColor = Color.FromArgb(255, 255, 255);
                slider1.TextColor = Color.Black;

                ThemeToggle.FillColor = Color.FromArgb(138, 144, 149);
                ThemeToggle.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            title.Start();

            this.ActiveControl = label1;

            if (Properties.Settings.Default.Theme == "Dark")
            {
                ThemeToggle.Text = "TOGGLE THEME -> CURRENT: DARK";
            }
            else if (Properties.Settings.Default.Theme == "Light")
            {
                ThemeToggle.Text = "TOGGLE THEME -> CURRENT: LIGHT";
            }
        }

        private void title_Tick(object sender, EventArgs e)
        {
            // Generates random title every second
            this.Text = Utilities.RandomString(15);
        }

        private void GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ThemeToggle_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Theme == "Dark")
                Properties.Settings.Default.Theme = "Light";
            else if (Properties.Settings.Default.Theme == "Light")
                Properties.Settings.Default.Theme = "Dark";

            Theme();

            Properties.Settings.Default.Save();
        }
    }
}
