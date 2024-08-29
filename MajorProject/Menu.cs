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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            //switches to settings form on button click
            Settings SettingsForm = new Settings();
            this.Hide();
            SettingsForm.Show();
        }
    }
}
