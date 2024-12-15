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

        private List<NewRequest> _RequestList = new List<NewRequest>();

        internal List<NewRequest> RequestList
        {
            get { return _RequestList; }
            set { _RequestList = value; }
        }

        public List<NewRequest> displayRequest(DataRow RowIn, List<NewRequest> requestList)
        {
            // Clear any existing requests
            RequestList.Clear();

            Information.SqlCon.Open();
            //string nameSQL = "SELECT Users.Username FROM Users INNER JOIN Friends ON Users.UserID = Friends.Friend1 WHERE Friends.Status = @Status"; // AND Friends.Friend2 = @Friend2";
            string nameSQL = "SELECT Username FROM Users WHERE UserID IN (SELECT Friend1 FROM Friends WHERE Status = @Status AND Friend2 = @Friend2)";
            SqlCommand cmd = new SqlCommand(nameSQL, Information.SqlCon);
            cmd.Parameters.AddWithValue("@Status", "Requested");
            cmd.Parameters.AddWithValue("@Friend2", Information.userID);

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            DA.Fill(DT);
            Information.SqlCon.Close();

            foreach (DataRow DR in DT.Rows)
            {
                NewRequest R = new NewRequest(DR);
                RequestList.Add(R);
            }

            // Return the populated friends list
            return RequestList;
        }

        public List<NewRequest> GetRequestList()
        {
            return RequestList;
        }
    }
}
