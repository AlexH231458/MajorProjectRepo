﻿using System;
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
            string sql1 = "SELECT FriendshipID, Friend1, Friend2 FROM Friends WHERE Status = @s AND (Friend1 = @u OR Friend2 = @u)";
            SqlCommand cmd1 = new SqlCommand(sql1, Information.SqlCon);
            cmd1.Parameters.AddWithValue("@s", "Accepted");
            cmd1.Parameters.AddWithValue("@u", Information.userID);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            Information.SqlCon.Close();

            foreach (DataRow row in dt1.Rows)
            {
                if (Convert.ToInt32(row["Friend1"]) == Information.userID)
                {
                    NewFriend F = new NewFriend(false, Convert.ToInt32(row["Friend2"]), Convert.ToInt32(row["FriendshipID"]));
                    FriendsList.Add(F);
                }
                else
                {
                    NewFriend F = new NewFriend(true, Convert.ToInt32(row["Friend1"]), Convert.ToInt32(row["FriendshipID"]));
                    FriendsList.Add(F);
                }
            }

            return FriendsList;
        }

        public List<NewFriend> GetFriendsList()
        {
            return FriendsList;
        }
    }
}
