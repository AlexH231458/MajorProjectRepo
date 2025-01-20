using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MajorProject
{
    public class NewFriend
    {
        public string _UsernameText;
        public string UsernameText
        {
            get { return _UsernameText; }
            set { _UsernameText = value; }
        }

        public NewFriend(DataRow DR)
        {
            _UsernameText = DR["Username"].ToString();
        }

    }
}
