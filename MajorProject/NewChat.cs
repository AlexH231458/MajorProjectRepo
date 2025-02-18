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
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = value; }
        }

        public NewChat(DataRow DR)
        {
            _Time = Convert.ToDateTime(DR["TimeStamp"]);
        }
    }
}
