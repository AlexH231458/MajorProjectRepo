using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            //shows or hides characters displayed in password box
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
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.Show();
        }

        public bool checkPassword(string text)
        {
            //checks that user input contains numbers, upper case and lower case characters
            bool allNumbers;
            int tempNumber;
            try
            {
                tempNumber = int.Parse(text);
                allNumbers = true;
            }
            catch
            {
                allNumbers = false;
            }

            if (text.ToUpper() != text && text.ToLower() != text)
            {
                bool numberFound = false;
                foreach (char C in text)
                {
                    try
                    {
                        tempNumber = int.Parse(C.ToString());
                        numberFound = true;
                    }
                    catch
                    {

                    }
                }
                if (numberFound == true && allNumbers == false)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void RegEnterButton_Click(object sender, EventArgs e)
        {
            //resets error text
            RegErrorText.Text = "";
            RegErrorText.Show();
            //sets variables from user input
            string userName = RegUsernameBox.Text;
            string password = RegPasswordBox.Text;
            DateTime DoB = DateTime.Parse(RegDateBox.Text);

            //Searches for username in database
            Information.SqlCon.Open();
            string sqlUser = ("SELECT * FROM [Users] WHERE Username = @U COLLATE SQL_Latin1_General_CP1_CS_AS");
            SqlCommand DataAdaptor1 = new SqlCommand(sqlUser, Information.SqlCon);
            DataAdaptor1.CommandType.ToString();
            DataAdaptor1.Parameters.AddWithValue("@U", userName);
            SqlDataAdapter selectUser = new SqlDataAdapter(DataAdaptor1);
            DataTable DT1 = new DataTable();
            selectUser.Fill(DT1);
            Information.SqlCon.Close();

            bool userFound = false;
            foreach (DataRow row in DT1.Rows)
            {
                if (DT1.Rows.Count == 1)
                {
                    userFound = true;
                    RegErrorText.Text = "Error: Username already exists";
                }
            }

            if (userFound == false)
            {
                //checks for secure password
                if (checkPassword(password) == false)
                {
                    RegErrorText.Text = "Error: Password is not secure";
                }

                //checks that the user is over 13 years old
                else if (DoB.AddYears(13) > DateTime.Today)
                {
                    RegErrorText.Text = "Error: Users must be over 13";
                }

                //adds the new user to the database then returns to the login form
                else
                {
                    Information.SqlCon.Open();
                    string isql = "INSERT INTO Users VALUES (@Username, @Password, @Autoshift, @Font, @Colour, @Pin)";
                    SqlCommand cmd = new SqlCommand(isql, Information.SqlCon);
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Autoshift", 0);
                    cmd.Parameters.AddWithValue("@Font", "Microsoft Sans Serif");
                    cmd.Parameters.AddWithValue("@Colour", "Control");
                    cmd.Parameters.AddWithValue("@Pin", System.DBNull.Value);
                    cmd.ExecuteNonQuery();
                    Information.SqlCon.Close();
                    Login LoginForm = new Login();
                    this.Hide();
                    LoginForm.Show();
                }
            }
        }

        private void RegUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void RegErrorText_Click(object sender, EventArgs e)
        {

        }
    }
}
