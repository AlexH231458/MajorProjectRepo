using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorProject
{
    internal class FriendRequest
    {

        private List<Requests> _RequestList = new List<Requests>();

        internal List<Requests> RequestList
        {
            get { return _RequestList; }
            set { _RequestList = value; }
        }

        public void displayRequest(DataRow RowIn)
        {
            Information.SqlCon.Open();

            string currentUser = Information.userID.ToString();
            string nameSQL = "SELECT Users.Username FROM Users, Friends WHERE Users.UserID = Friends.Friend1ID AND Friends.Status = REQUESTED AND Friends.Friend2ID =" + currentUser;

            SqlDataAdapter DA = new SqlDataAdapter(nameSQL, Information.SqlCon);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            Information.SqlCon.Close();

            foreach (DataRow DR in DT.Rows)
            {
                NewRequest R = new NewRequest(DR);
                RequestList.Add(R);
            }
        }
    }
}
