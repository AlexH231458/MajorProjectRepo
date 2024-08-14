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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void RegUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegDateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RegShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            //hides characters displayed in password box if checkbox is false
            if (RegShowCheck.Checked == true)
            {
                RegPasswordBox.UseSystemPasswordChar = false;
            }
            if (RegShowCheck.Checked == false)
            {
                RegPasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void RegReturnButton_Click(object sender, EventArgs e)
        {
            //switches to login form on button click
            Login temp = new Login();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void RegEnterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
