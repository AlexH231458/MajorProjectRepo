using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void SettingsColourButton_Click(object sender, EventArgs e)
        {
            var colour = SettingsColourDialog.ShowDialog();
        }

        private void SettingsReturnButton_Click(object sender, EventArgs e)
        {
            //switches to menu form on button click
            Menu temp = new Menu();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void SettingsExitButton_Click(object sender, EventArgs e)
        {
            //switches to login form on button click
            Login temp = new Login();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void SettingsFontButton_Click(object sender, EventArgs e)
        {
            var font = SettingsFontDialog.ShowDialog();
        }
    }
}
