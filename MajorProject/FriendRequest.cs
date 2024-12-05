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

        public List<NewRequest> GetRequestList()
        {
            return RequestList;
        }

        public void displayRequest(DataRow RowIn, List<NewRequest> requestList)
        {
            Information.SqlCon.Open();

            string currentUser = Information.userID.ToString();

            //ChatGPT used
            string nameSQL = "SELECT Users.Username FROM Users INNER JOIN Friends ON Users.UserID = Friends.Friend1 WHERE Friends.Status = @Status AND Friends.Friend2 = @Friend2";
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
            Friends friendship = new Friends(RequestList);

        }
    }
}
