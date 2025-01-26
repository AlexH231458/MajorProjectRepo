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
    public partial class FriendControl : UserControl
    {
        public NewFriend newFriend;
        public FriendControl(NewFriend F)
        {
            InitializeComponent();
            newFriend = F;
            this.Load += FriendControl_Load;
        }

        private void FCNicknameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriendControl_Load(object sender, EventArgs e)
        {
            Information.SqlCon.Open();

            if (newFriend.IsFirstFriend == true)
            {
                string sql = "SELECT NameFor1 FROM Friends WHERE FriendshipID = @friend";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("@friend", newFriend.FriendshipID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FCNicknameBox.Text = dt.Rows[0]["NameFor1"].ToString();
            }
            else
            {
                string sql = "SELECT NameFor2 FROM Friends WHERE FriendshipID = @friend";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("@friend", newFriend.FriendshipID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                FCNicknameBox.Text = dt.Rows[0]["NameFor2"].ToString();
            }
            Information.SqlCon.Close();

            FCNameLabel.Text = newFriend.UsernameText;

        }

        private void FCNicknameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FCRemoveButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();
            string sql = ("DELETE FROM Friends WHERE Friend1 = @F1 AND Friend2 = @F2");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);

            if (newFriend.IsFirstFriend == true)
            {
                cmd.Parameters.AddWithValue("@F1", newFriend.FriendID);
                cmd.Parameters.AddWithValue("@F2", Information.userID);
            }
            else
            {
                cmd.Parameters.AddWithValue("@F2", newFriend.FriendID);
                cmd.Parameters.AddWithValue("@F1", Information.userID);
            }
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
            this.Hide();
        }

        private void FCPinButton_Click(object sender, EventArgs e)
        {

        }

        private void FCNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FCChangeButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();
            string sql = "UPDATE Friends SET @name = @nickname WHERE FriendshipID = @friendship";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@friendship", newFriend.FriendshipID);
            cmd.Parameters.AddWithValue("@nickname", FCNicknameBox.Text);
            if (newFriend.IsFirstFriend == true)
            {
                cmd.Parameters.AddWithValue("@name", "NameFor1");
            }
            else
            {
                cmd.Parameters.AddWithValue("@name", "NameFor2");
            }
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
        }
    }
}
