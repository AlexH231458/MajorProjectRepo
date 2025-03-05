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

            //changes font to user setting
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }
        }

        private void FCNicknameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriendControl_Load(object sender, EventArgs e)
        {
            //finds and displays actual username of friend
            Information.SqlCon.Open();
            string sql = "SELECT Username FROM Users WHERE UserID = @user";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@user", newFriend.FriendID);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            FCNameLabel.Text = dt.Rows[0]["Username"].ToString();
            Information.SqlCon.Close();

            //displays stored nickname of friend
            FCNicknameBox.Text = newFriend.UsernameText;
        }

        private void FCNicknameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FCRemoveButton_Click(object sender, EventArgs e)
        {
            //checks which user is pinned
            Information.SqlCon.Open();
            string sql = ("SELECT PinnedUser FROM Users WHERE UserID = @u");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@u", Information.userID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            try
            {
                int pin = Convert.ToInt32(dt.Rows[0]["PinnedUser"]);
                if (pin == newFriend.FriendshipID)
                {
                    //removes user if they are pinned
                    string Sql = "UPDATE Users SET PinnedUser = @n WHERE UserID = @u";
                    SqlCommand Cmd = new SqlCommand(Sql, Information.SqlCon);
                    Cmd.Parameters.AddWithValue("@n", System.DBNull.Value);
                    Cmd.Parameters.AddWithValue("@u", Information.userID);
                    Cmd.ExecuteNonQuery();
                }
            }
            catch
            {

            }

            //removes any messages for the friendship
            string sql1 = ("DELETE FROM Messages WHERE Friendship = @f");
            SqlCommand cmd1 = new SqlCommand(sql1, Information.SqlCon);
            cmd1.Parameters.AddWithValue("@f", newFriend.FriendshipID);
            cmd1.ExecuteNonQuery();

            //removes friendship
            string sql2 = ("DELETE FROM Friends WHERE FriendshipID = @F");
            SqlCommand cmd2 = new SqlCommand(sql2, Information.SqlCon);
            cmd2.Parameters.AddWithValue("@F", newFriend.FriendshipID);
            cmd2.ExecuteNonQuery();
            Information.SqlCon.Close();
            this.Hide();
        }

        private void FCPinButton_Click(object sender, EventArgs e)
        {
            //pins current friend and stores in database
            Information.SqlCon.Open();
            string sql = "UPDATE Users SET PinnedUser = @friend WHERE UserID = @user";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@friend", newFriend.FriendshipID);
            cmd.Parameters.AddWithValue("@user", Information.userID);
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
        }

        private void FCNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void FCChangeButton_Click(object sender, EventArgs e)
        {
            //stores new nickname in the relevant database attribute
            Information.SqlCon.Open();
            string sql;
            if (newFriend.IsFirstFriend == true)
            {
                sql = "UPDATE Friends SET NameFor1 = @nickname WHERE FriendshipID = @friendship";
            }
            else
            {
                sql = "UPDATE Friends SET NameFor2 = @nickname WHERE FriendshipID = @friendship";
            }
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@name", "NameFor1");
            cmd.Parameters.AddWithValue("@friendship", newFriend.FriendshipID);
            cmd.Parameters.AddWithValue("@nickname", FCNicknameBox.Text);
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
        }
    }
}
