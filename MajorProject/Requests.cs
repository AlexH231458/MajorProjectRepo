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
        }

        private void RequestRemoveButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();

            string sql1 = ("SELECT UserID FROM Users WHERE Username = @U");
            SqlCommand Cmd = new SqlCommand(sql1, Information.SqlCon);
            Cmd.Parameters.AddWithValue("@U", NewRequest.UsernameText);

            string sql = ("UPDATE Friends SET Status = @S WHERE Friend1 = @F");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@S", "Accepted");
            cmd.Parameters.AddWithValue("@F", );
            cmd.ExecuteNonQuery();

            Information.SqlCon.Close();
        }

        private void RequestAcceptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
