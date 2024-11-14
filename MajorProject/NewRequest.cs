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
        public string _UsernameText;

        public string UsernameText
        {
            get { return _UsernameText; }
            set { _UsernameText = value; }
        }

        public NewRequest(DataRow DR)
        {
            _UsernameText = DR["Username"].ToString();
        }
    }
}
