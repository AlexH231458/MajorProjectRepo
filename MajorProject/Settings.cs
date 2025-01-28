using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MajorProject
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            Information.SqlCon.Open();

            string sql = "SELECT Autoshift FROM Users WHERE UserID = @u";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@u", Information.userID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable DT1 = new DataTable();
            adapter.Fill(DT1);
            bool shift = Convert.ToBoolean(DT1.Rows[0]["Autoshift"]);

            Information.SqlCon.Close();

            if (shift == true)
            {
                SettingsAutoshiftBox.Text = "On";
            }
            else
            {
                SettingsAutoshiftBox.Text = "Off";
            }

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
            DialogResult result = SettingsColourDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Information.colour = SettingsColourDialog.Color;
                this.BackColor = Information.colour;
            }

            string colourName = Information.colour.Name.ToString();

            Information.SqlCon.Open();
            string sql = "UPDATE Users SET Colour = @Colour WHERE UserID = @ID";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@Colour", colourName);
            cmd.Parameters.AddWithValue("@ID", Information.userID);
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
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
            SettingsFontDialog.MaxSize = 8;
            SettingsFontDialog.MinSize = 8;
            DialogResult result = SettingsFontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Drawing.Font newFont = SettingsFontDialog.Font;
                newFont = new System.Drawing.Font(newFont, FontStyle.Regular);
                Information.font = newFont;

                foreach (Control control in this.Controls)
                {
                    control.Font = Information.font;
                }

                System.ComponentModel.TypeConverter convert = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
                string fontName = (string)convert.ConvertToString(Information.font);

                Information.SqlCon.Open();
                string sql = "UPDATE Users SET Font = @Font WHERE UserID = @ID";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("@Font", fontName);
                cmd.Parameters.AddWithValue("@ID", Information.userID);
                cmd.ExecuteNonQuery();
                Information.SqlCon.Close();
            }
        }

        private void SettingsShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (SettingsShowCheck.Checked == true)
            {
                SettingsOldBox.UseSystemPasswordChar = false;
                SettingsNewBox.UseSystemPasswordChar = false;
            }
            if (SettingsShowCheck.Checked == false)
            {
                SettingsOldBox.UseSystemPasswordChar = true;
                SettingsNewBox.UseSystemPasswordChar = true;
            }
        }

        private void SettingsErrorLabel_Click(object sender, EventArgs e)
        {

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

        private void SettingsPassButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();

            string sql = "SELECT Password FROM Users WHERE UserID = @u";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@u", Information.userID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            string password = dt.Rows[0]["Password"].ToString();

            if (password == SettingsOldBox.Text)
            {
                password = SettingsNewBox.Text;
                if (checkPassword(password) == false)
                {
                    SettingsErrorLabel.Text = "Error:\nPassword is not secure";
                    SettingsErrorLabel.Show();
                }
                else
                {
                    string sql1 = "UPDATE Users SET Password = @p WHERE UserID = @u";
                    SqlCommand cmd1 = new SqlCommand(sql1, Information.SqlCon);
                    cmd1.Parameters.AddWithValue("@p", password);
                    cmd1.Parameters.AddWithValue("@u", Information.userID);
                    cmd1.ExecuteNonQuery();
                }
            }
            else
            {
                SettingsErrorLabel.Text = "Error:\nIncorrect password";
                SettingsErrorLabel.Show();
            }

            Information.SqlCon.Close();
        }

        private void SettingsAutoshiftBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Information.SqlCon.Open();

            string sql = "UPDATE Users SET Autoshift = @a WHERE UserID = @u";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@u", Information.userID);
            if (SettingsAutoshiftBox.Text == "On")
            {
                cmd.Parameters.AddWithValue("@a", true);
            }
            else
            {
                cmd.Parameters.AddWithValue("@a", false);
            }
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
        }
    }
}
