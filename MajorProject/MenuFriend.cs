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
    public partial class MenuFriend : UserControl
    {
        public NewFriend newFriend;
        private List<NewChat> chatList;
        public MenuFriend(NewFriend F)
        {
            InitializeComponent();
            newFriend = F;
            this.Load += MenuFriend_Load;
        }

        private void MenuFriend_Load(object sender, EventArgs e)
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
                MFNameLabel.Text = dt.Rows[0]["NameFor1"].ToString();
            }
            else
            {
                string sql = "SELECT NameFor2 FROM Friends WHERE FriendshipID = @friend";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("@friend", newFriend.FriendshipID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MFNameLabel.Text = dt.Rows[0]["NameFor2"].ToString();
            }
            Information.SqlCon.Close();

            MFNameLabel.Text = newFriend.UsernameText;
        }

        private void MFChatButton_Click(object sender, EventArgs e)
        {
            Chat ChatForm = new Chat(chatList, newFriend);
            Control MenuForm = this.Parent.Parent;
            MenuForm.Hide();
            ChatForm.Show();
        }
    }
}
