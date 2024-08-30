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
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.Show();
        }

        public bool checkPassword(string text)
        {
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
            RegErrorText.Text = "";
            RegErrorText.Show();
            //sets variables from user input
            string userName = RegUsernameBox.Text;
            string password = RegPasswordBox.Text;
            DateTime DoB = DateTime.Parse(RegDateBox.Text);

            //Opens SQL connection
            SqlConnection SqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Right Click\source\repos\MajorProjectRepo\MajorProject\AppData\Database.mdf;Integrated Security=True");
            SqlCon.Open();

            string sqlUser = ("SELECT * FROM [Users] WHERE Username = @U COLLATE SQL_Latin1_General_CP1_CS_AS");

            //fills parameters with values from user input
            SqlCommand DataAdaptor1 = new SqlCommand(sqlUser, SqlCon);
            DataAdaptor1.CommandType.ToString();
            DataAdaptor1.Parameters.AddWithValue("@U", userName);

            SqlDataAdapter selectUser = new SqlDataAdapter(DataAdaptor1);
            DataTable DT1 = new DataTable();
            selectUser.Fill(DT1);
            SqlCon.Close();

            bool userFound = false;
            foreach (DataRow row in DT1.Rows)
            {
                //checks that username is unique
                if (DT1.Rows.Count == 1)
                {
                    userFound = true;
                    RegErrorText.Text = "Error: Username already exists";
                    RegErrorText.Show();
                }
            }

            if (userFound == false)
            {
                //checks that the password has lower case, upper case and numbers
                if (checkPassword(password) == false)
                {
                    RegErrorText.Text = "Error: Password is not secure";
                    RegErrorText.Show();
                }

                //checks that the user is over 13 years old
                else if (DoB.AddYears(13) >= DateTime.Today)
                {
                    RegErrorText.Text = "Error: Users must be over 13";
                    RegErrorText.Show();
                }

                //adds the new user to the databse then returns to the login form
                else
                {
                    SqlCon.Open();
                    string isql = "INSERT INTO Users VALUES (@Username, @Password)";
                    SqlCommand cmd = new SqlCommand(isql, SqlCon);
                    cmd.Parameters.AddWithValue("@Username", userName);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.ExecuteNonQuery();
                    SqlCon.Close();

                    Login LoginForm = new Login();
                    this.Hide();
                    LoginForm.Show();
                }
            }
        }
    }
}
