using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class Requests : UserControl
    {
        public NewRequest NewRequest;
        public string ID;

        public Requests(NewRequest R)
        {
            InitializeComponent();
            NewRequest = R;
            //ChatGPT used
            this.Load += Requests_Load;
        }


        public void Requests_Load(object sender, EventArgs e)
        {
            RequestNameText.Text = NewRequest.UsernameText;

            Information.SqlCon.Open();
            string sql1 = ("SELECT UserID FROM Users WHERE Username = @U");
            SqlCommand Cmd = new SqlCommand(sql1, Information.SqlCon);
            Cmd.Parameters.AddWithValue("@U", NewRequest.UsernameText);
            SqlDataAdapter adapter = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            ID = dt.Rows[0]["UserID"].ToString();
            Information.SqlCon.Close();
        }

        private void RequestRemoveButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();
            string sql = ("DELETE FROM Friends WHERE Friend1 = @F1 AND Friend2 = @F2");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@F1", ID);
            cmd.Parameters.AddWithValue("@F2", Information.userID);
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
            this.Hide();
        }

        private void RequestAcceptButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();
            string sql1 = ("UPDATE Friends SET Status = @S WHERE Friend1 = @F");
            SqlCommand cmd1 = new SqlCommand(sql1, Information.SqlCon);
            cmd1.Parameters.AddWithValue("@S", "Accepted");
            cmd1.Parameters.AddWithValue("@F", ID);
            cmd1.ExecuteNonQuery();
            Information.SqlCon.Close();
            this.Hide();
        }
    }
}
