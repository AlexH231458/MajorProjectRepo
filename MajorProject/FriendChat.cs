using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;

namespace MajorProject
{
    internal class FriendChat
    {
        private List<NewChat> _ChatList = new List<NewChat>();

        internal List<NewChat> ChatList
        {
            get { return _ChatList; }
            set { _ChatList = value; }
        }

        public List<NewChat> displayChat(DataRow RowIn, List<NewChat> chatList, NewFriend friend)
        {
            int friendID = friend.FriendshipID;

            ChatList.Clear();

            Information.SqlCon.Open();
            string sql = "SELECT * FROM Messages WHERE Friendship = @F";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@F", friendID);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            Information.SqlCon.Close();

            foreach (DataRow DR in DT.Rows)
            {
                NewChat C = new NewChat(DR, friend);
                ChatList.Add(C);
            }

            return ChatList;
        }

        public List<NewChat> GetChatList()
        {
            return ChatList;
        }
    }
}
