using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MajorProject
{
    internal class FriendDisplay
    {
        private List<NewFriend> _FriendsList = new List<NewFriend>();
        internal List<NewFriend> FriendsList
        {
            get { return _FriendsList; }
            set { _FriendsList = value; }
        }

        public List<NewFriend> displayFriend(DataRow RowIn, List<NewFriend> friendsList)
        {
            FriendsList.Clear();

            Information.SqlCon.Open();
            // ChatGPT used
            string sql1 = "SELECT Users.Username, Friends.Friend1, Friends.Friend2 FROM Users, Friends WHERE Users.UserID IN(SELECT Friend1 FROM Friends WHERE Status = @Status AND Friend2 = @User)";
            SqlCommand cmd = new SqlCommand(sql1, Information.SqlCon);
            cmd.Parameters.AddWithValue("@Status", "Accepted");
            cmd.Parameters.AddWithValue("@User", Information.userID);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);

            foreach (DataRow DR in DT.Rows)
            {
                NewFriend F = new NewFriend(DR, true, Convert.ToInt32(DR["Friend1"]));
                FriendsList.Add(F);
            }

            string sql2 = "SELECT Users.Username, Friends.Friend2 FROM Users, Friends WHERE Users.UserID IN(SELECT Friend2 FROM Friends WHERE Status = @Status AND Friend1 = @User)";
            cmd = new SqlCommand(sql1, Information.SqlCon);
            cmd.Parameters.AddWithValue("@Status", "Accepted");
            cmd.Parameters.AddWithValue("@User", Information.userID);

            DA = new SqlDataAdapter(cmd);
            DT = new DataTable();
            DA.Fill(DT);

            foreach (DataRow DR in DT.Rows)
            {
                NewFriend F = new NewFriend(DR, false, Convert.ToInt32(DR["Friend2"]));
                FriendsList.Add(F);
            }


            Information.SqlCon.Close();
            return FriendsList;
        }

        public List<NewFriend> GetFriendsList()
        {
            return FriendsList;
        }
    }
}
