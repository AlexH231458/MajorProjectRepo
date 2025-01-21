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
            string sql = "SELECT Username FROM Users WHERE UserID IN(SELECT Friend1 FROM Friends WHERE Status = @Status AND Friend2 = @Friend2)";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@Status", "Accepted");
            cmd.Parameters.AddWithValue("@Friend2", Information.userID);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            foreach (DataRow DR in DT.Rows)
            {
                NewFriend F = new NewFriend(DR);
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
