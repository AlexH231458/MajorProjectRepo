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
    public class NewChat
    {
        public DateTime _Time;
        public NewFriend _Friend;
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }
        public NewFriend Friend
        {
            get { return _Friend; }
            set { _Friend = value; }
        }

        public NewChat(DataRow DR, NewFriend f)
        {
            _Time = Convert.ToDateTime(DR["TimeStamp"]);
            _Friend = f;
        }
    }
}
