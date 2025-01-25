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
        //public int ID;
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
            FCNameLabel.Text = newFriend.UsernameText;
            //Information.SqlCon.Open();
            //string sql = ("SELECT Friend1, Friend2 FROM Friends WHERE Status = @S AND (Friend1 = @U OR Friend2 = @U)");
            //SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            //cmd.Parameters.AddWithValue("@S", "Accepted");
            //cmd.Parameters.AddWithValue("@U", Information.userID);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //Information.SqlCon.Close();
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
            if (newFriend.IsFirstFriend == false)
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

        }
    }
}
