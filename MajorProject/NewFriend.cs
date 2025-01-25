using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Remoting.Messaging;

namespace MajorProject
{
    public class NewFriend
    {
        public string _UsernameText;
        public int _FriendID;
        public bool _IsFirstFriend;

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

        public NewFriend(DataRow DR, bool first, int id)
        {
            _UsernameText = DR["Username"].ToString();
            _FriendID = id;
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
