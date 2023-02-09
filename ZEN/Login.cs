using KeyAuth;
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
    public partial class Login : Form
    {
        public static api KeyAuthApp = new api(
            name: "",
            ownerid: "",
            secret: "",
            version: "1.0"
        );

        public Login()
        {
            InitializeComponent();

            // Converts lower case string to uppsercase
            Utilities.UpperCase(Utilities.RandomString(5));

            // Changes title of window to below info
            this.Text = "ZEN: - SESSION ID: " + Utilities.UpperReturn;

            // Load theme settings
            Theme();
        }

        private void Theme()
        {
            // Sets applications colors for dark style theme
            if (Properties.Settings.Default.Theme == "Dark")
            {
                this.BackColor = Color.FromArgb(39, 49, 61);

                uixParticles1.BackColor = Color.FromArgb(39, 49, 61);
                uixParticles1.ParticleColor = Color.White;

                Username.ForeColor = Color.FromArgb(172, 176, 180);
                Username.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Username.FillColor = Color.FromArgb(39, 49, 61);
                Username.BorderColor = Color.FromArgb(172, 176, 180);
                Username.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Username.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                Password.ForeColor = Color.FromArgb(172, 176, 180);
                Password.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Password.FillColor = Color.FromArgb(39, 49, 61);
                Password.BorderColor = Color.FromArgb(172, 176, 180);
                Password.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Password.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                Key.ForeColor = Color.FromArgb(172, 176, 180);
                Key.PlaceholderForeColor = Color.FromArgb(172, 176, 180);
                Key.FillColor = Color.FromArgb(39, 49, 61);
                Key.BorderColor = Color.FromArgb(172, 176, 180);
                Key.FocusedState.BorderColor = Color.FromArgb(172, 176, 180);
                Key.HoverState.BorderColor = Color.FromArgb(172, 176, 180);

                LoginBtn.FillColor = Color.FromArgb(172, 176, 180);
                LoginBtn.ForeColor = Color.FromArgb(39, 49, 61);

                RegisterBtn.FillColor = Color.FromArgb(172, 176, 180);
                RegisterBtn.ForeColor = Color.FromArgb(39, 49, 61);
            }
            // Sets applications colors for light style theme
            else if (Properties.Settings.Default.Theme == "Light")
            {
                this.BackColor = Color.FromArgb(255, 255, 255);

                uixParticles1.BackColor = Color.FromArgb(255, 255, 255);
                uixParticles1.ParticleColor = Color.FromArgb(138, 144, 149);

                Username.ForeColor = Color.FromArgb(138, 144, 149);
                Username.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Username.FillColor = Color.FromArgb(255, 255, 255);
                Username.BorderColor = Color.FromArgb(138, 144, 149);
                Username.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Username.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                Password.ForeColor = Color.FromArgb(138, 144, 149);
                Password.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Password.FillColor = Color.FromArgb(255, 255, 255);
                Password.BorderColor = Color.FromArgb(138, 144, 149);
                Password.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Password.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                Key.ForeColor = Color.FromArgb(138, 144, 149);
                Key.PlaceholderForeColor = Color.FromArgb(138, 144, 149);
                Key.FillColor = Color.FromArgb(255, 255, 255);
                Key.BorderColor = Color.FromArgb(138, 144, 149);
                Key.FocusedState.BorderColor = Color.FromArgb(138, 144, 149);
                Key.HoverState.BorderColor = Color.FromArgb(138, 144, 149);

                LoginBtn.FillColor = Color.FromArgb(138, 144, 149);
                LoginBtn.ForeColor = Color.FromArgb(255, 255, 255);

                RegisterBtn.FillColor = Color.FromArgb(138, 144, 149);
                RegisterBtn.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Init shit auth api
            KeyAuthApp.init();

            // Perform a trash auth autism check
            if (!KeyAuthApp.response.success)
            {
                Message_Box msg = new Message_Box("Auth Error", KeyAuthApp.response.message, 300, 75);
                msg.ShowDialog();

                Application.Exit();
            }

            // Loading of eo may take so time on some computers we avoid the issue of lag on some users
            // computer we will load a splash screen for 5seconds so the form has fully been loaded
            Splash sp = new Splash();
            sp.ShowDialog();

            // Load username and password for config builder
            Username.Text = Properties.Settings.Default.Username;
            Password.Text = Properties.Settings.Default.Password;

            KeyAuthApp.check();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(Username.Text, Password.Text);

            if (KeyAuthApp.response.success)
            {
                // After response message above show main form where your tool / cheat is
                GUI uI = new GUI();
                uI.Show();

                // Once main gui is shown hide this one
                this.Hide();

                // Update username and password if login was a go
                Properties.Settings.Default.Username = Username.Text;
                Properties.Settings.Default.Password = Password.Text;

                Properties.Settings.Default.Save();
            }
            else
            {
                // Display error message, well that's if an error is found after logging in...
                Message_Box msg = new Message_Box("LOGIN ERROR", "ERROR WHILE TRYING TO LOGIN!", 235, 75);
                msg.ShowDialog();
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(Username.Text, Password.Text, Key.Text);

            if (KeyAuthApp.response.success)
            {
                // Show response message if login successfull -> Note you may remove this if you like its not needed
                Message_Box msg = new Message_Box("REGISTER SUCCESSFULL", "LOGGING IN NOW, PLEASE WAIT...", 245, 75);
                msg.ShowDialog();

                // After response message above show main form where your tool / cheat is
                GUI uI = new GUI();
                uI.Show();

                // Once main gui is shown hide this one
                this.Hide();
            }
            else
            {
                // Display error message, well that's if an error is found after logging in...
                Message_Box msg = new Message_Box("REGISTER ERROR", "ERROR WHILE TRYING TO REGISTER!", 250, 75);
                msg.ShowDialog();
            }
        }
    }
}
