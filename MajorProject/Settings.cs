using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MajorProject
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                control.Font = Information.font;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void SettingsColourButton_Click(object sender, EventArgs e)
        {
            SettingsColourDialog.ShowDialog();
            //TeSettingsColourDialog.Font = Information.font;
            SettingsColourDialog.Color = Information.colour;
        }

        private void SettingsReturnButton_Click(object sender, EventArgs e)
        {
            //switches to menu form on button click
            Menu MenuForm = new Menu();
            this.Hide();
            MenuForm.Show();
        }

        private void SettingsExitButton_Click(object sender, EventArgs e)
        {
            //switches to login form on button click
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.Show();
        }

        private void SettingsFontButton_Click(object sender, EventArgs e)
        {
            DialogResult result = SettingsFontDialog.ShowDialog();
            SettingsFontDialog.Font = Information.font;
            SettingsFontDialog.Color = Information.colour;
            if (result == DialogResult.OK)
            {
                newFont(this.SettingsFontButton, new System.EventArgs());
            }
        }

        private void newFont(object sender,System.EventArgs e)
        {
            Information.font = SettingsFontDialog.Font;
            label1.Text = Information.font.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
