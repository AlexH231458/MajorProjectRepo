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
    public class NewFriend
    {
        public string _UsernameText;
        public int _FriendID;
        public bool _IsFirstFriend;
        public int _FriendshipID;

        public int FriendshipID
        {
            get { return _FriendshipID; }
            set { _FriendshipID = value; }
        }

        public int FriendID
        {
            get { return _FriendID; }
            set { _FriendID = value; }
        }
        public bool IsFirstFriend
        {
            get { return _IsFirstFriend; }
            set { _IsFirstFriend = value; }
        }
        public string UsernameText
        {
            get { return _UsernameText; }
            set { _UsernameText = value; }
        }

        public NewFriend(bool first, int id, int friendship)
        {
            _FriendshipID = friendship;
            _FriendID = id;

            Information.SqlCon.Open();
            string sql = "SELECT Username FROM Users WHERE UserID = @u";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@u", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Information.SqlCon.Close();

            _UsernameText = dt.Rows[0]["Username"].ToString();
            if (first == true)
            {
                _IsFirstFriend = true;
            }
            if (first == false)
            {
                _IsFirstFriend = false;
            }
        }

    }
}
