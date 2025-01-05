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
            Registration RegForm = new Registration();
            this.Hide();
            RegForm.Show();
        }

        private void LoginEnterButton_Click(object sender, EventArgs e)
        {
            LoginErrorText.Text = "";
            LoginErrorText.Show();

            //Opens SQL connection
            Information.SqlCon.Open();

            string sqlUser = ("SELECT * FROM [Users] WHERE Username = @U COLLATE SQL_Latin1_General_CP1_CS_AS AND Password = @P COLLATE SQL_Latin1_General_CP1_CS_AS");

            //fills parameters with values from user input
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
                if (DT1.Rows.Count == 1)
                {
                    System.ComponentModel.TypeConverter convert = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));

                    //switches to menu form if details are valid
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
            LoginErrorText.Text = "Error: invalid login details";
            LoginErrorText.Show();
        }
    }
}
