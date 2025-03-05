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
    //class stores data for each new friend
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

        public NewFriend(bool first, int id, int friendship, string nickname)
        {
            //assigns data from database
            _FriendshipID = friendship;
            _FriendID = id;
            _UsernameText = nickname;
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
