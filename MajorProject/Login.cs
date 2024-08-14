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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginUsernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginPasswordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            //hides characters displayed in password box if checkbox is false
            if (LoginShowCheck.Checked == true)
            {
                LoginPasswordBox.UseSystemPasswordChar = false;
            }
            if (LoginShowCheck.Checked == false)
            {
                LoginPasswordBox.UseSystemPasswordChar = true;
            }
        }

        private void LoginNewButton_Click(object sender, EventArgs e)
        {
            //switches to registration form on button click
            Registration temp = new Registration();
            temp.Region = this.Region;
            temp.Show();
            this.Hide();
        }

        private void LoginEnterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
