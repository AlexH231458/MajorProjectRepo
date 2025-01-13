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
            SettingsColourDialog.ShowDialog();
            //TeSettingsColourDialog.Font = Information.font;
            SettingsColourDialog.Color = Information.colour;
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

        private FontDialog fontDialog = new FontDialog();
        private void SettingsFontButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
            SettingsFontDialog.MaxSize = 8;
            SettingsFontDialog.MinSize = 8;
            //SettingsFontDialog.
            SettingsFontDialog.Color = Information.colour;
            DialogResult result = SettingsFontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Information.font = SettingsFontDialog.Font;

                System.ComponentModel.TypeConverter convert = System.ComponentModel.TypeDescriptor.GetConverter(typeof(Font));
                string fontName = (string)convert.ConvertToString(Information.font);

                Information.SqlCon.Open();
                string sql = "";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("", );
                Information.SqlCon.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
