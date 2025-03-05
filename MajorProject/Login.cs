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
            //shows or hides characters displayed in password box
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
            Registration RegForm = new Registration();
            this.Hide();
            RegForm.Show();
        }

        private void LoginEnterButton_Click(object sender, EventArgs e)
        {
            //resets error text
            LoginErrorText.Text = "";
            LoginErrorText.Show();

            //finds username and password to check if user inputs are correct
            Information.SqlCon.Open();
            string sqlUser = ("SELECT * FROM [Users] WHERE Username = @U COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @P COLLATE SQL_Latin1_General_CP1_CS_AS");
            SqlCommand DataAdaptor1 = new SqlCommand(sqlUser, Information.SqlCon);
            DataAdaptor1.CommandType.ToString();
            DataAdaptor1.Parameters.AddWithValue("@U", LoginUsernameBox.Text);
            DataAdaptor1.Parameters.AddWithValue("@P", LoginPasswordBox.Text);

            SqlDataAdapter selectUser = new SqlDataAdapter(DataAdaptor1);
            DataTable DT1 = new DataTable();
            selectUser.Fill(DT1);
            Information.SqlCon.Close();
            foreach (DataRow row in DT1.Rows)
            {
                //switches to menu form if inputs are correct and stores user information
                if (DT1.Rows.Count == 1)
                {
                    System.ComponentModel.TypeConverter convert = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
                    Menu MenuForm = new Menu();
                    Information.userName = DT1.Rows[0]["Username"].ToString();
                    Information.userID = Convert.ToInt32(DT1.Rows[0]["UserID"]);
                    string fontName = DT1.Rows[0]["Font"].ToString();
                    Information.font = (Font) convert.ConvertFromString(fontName);
                    Information.autoShift = Convert.ToInt32(DT1.Rows[0]["Autoshift"]);
                    string colourName = DT1.Rows[0]["Colour"].ToString();
                    Information.colour = Color.FromName(colourName);
                    this.Hide();
                    MenuForm.Show();
                }
            }
            //if inputs are incorrect, displays error message
            LoginErrorText.Text = "Error: invalid login details";
        }

        private void LoginUsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginPasswordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
