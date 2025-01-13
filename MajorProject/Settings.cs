using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
