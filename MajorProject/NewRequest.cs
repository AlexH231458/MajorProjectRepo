using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    public class NewRequest
    {
        public string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public NewRequest(DataRow DR)
        {
            _Username = DR["Username"].ToString();
        }
    }
}
