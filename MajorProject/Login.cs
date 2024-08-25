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
            //Opens SQL connection
            SqlConnection SqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Right Click\source\repos\MajorProjectRepo\MajorProject\AppData\Database.mdf;Integrated Security=True");
            SqlCon.Open();

            string sqlUser = ("SELECT * FROM [Users] WHERE Username = @U AND Password = @P");

            //fills parameters with values from user input
            SqlCommand DataAdaptor1 = new SqlCommand(sqlUser, SqlCon);
            DataAdaptor1.CommandType.ToString();
            DataAdaptor1.Parameters.AddWithValue("@U", LoginUsernameBox.Text);
            DataAdaptor1.Parameters.AddWithValue("@P", LoginPasswordBox.Text);

            SqlDataAdapter selectUser = new SqlDataAdapter(DataAdaptor1);
            DataTable DT1 = new DataTable();
            selectUser.Fill(DT1);
            SqlCon.Close();

            foreach (DataRow row in DT1.Rows)
            {
                if (DT1.Rows.Count == 1)
                {
                    //switches to menu form if details are valid
                    Menu Menu = new Menu();
                    //Menu.Username = DT1.Rows[0]["Username"].ToString();
                    this.Hide();
                    Menu.Show();
                }
                else
                {
                    LoginErrorText.Text = "Error: invalid login details";
                    LoginErrorText.Show();
                }
            }
        }
    }
}
