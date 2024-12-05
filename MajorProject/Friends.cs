﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MajorProject
{
    public partial class Friends : Form
    {
        public List<NewRequest> _RequestList = new List<NewRequest>();
        public Friends(List<NewRequest> requestList)
        {
            this._RequestList = _RequestList;
            InitializeComponent();
        

            //open SQL connection
            Information.SqlCon.Open();
            string sql = ("SELECT Username FROM [Users] WHERE Users.UserID != @I");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.CommandType.ToString();
            cmd.Parameters.AddWithValue("@I", Information.userID);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int count = 0;
            

            //adds each username to the combobox
            foreach (DataRow dr in dt.Rows)
            {
                FriendSearchCombo.Items.Add(dt.Rows[count]["Username"].ToString());
                count++;
            }
            Information.SqlCon.Close();
            displayRequests();
        }

        private void FriendReturnButton_Click(object sender, EventArgs e)
        {
            //switches to menu form on button click
            Menu MenuForm = new Menu();
            this.Hide();
            MenuForm.Show();
        }

        private void FriendSearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void FriendRequestButton_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();

            //finds relevant userID for selected username
            string sql = ("SELECT UserID FROM Users WHERE Username = @U");
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.CommandType.ToString();
            cmd.Parameters.AddWithValue("@U", FriendSearchCombo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable DT = new DataTable();
            adapter.Fill(DT);
            int newFriend = Convert.ToInt32(DT.Rows[0]["UserID"]);

            //inserts new frienship data into Friends table
            string insert = "INSERT INTO Friends VALUES (@F1, @F2, @S)";
            SqlCommand Cmd = new SqlCommand(insert, Information.SqlCon);
            Cmd.Parameters.AddWithValue("@F1", Information.userID);
            Cmd.Parameters.AddWithValue("@F2", newFriend);
            Cmd.Parameters.AddWithValue("@S", "Requested");
            Cmd.ExecuteNonQuery();

            Information.SqlCon.Close();
        }

        private List<NewRequest> Requests = new List<NewRequest>();

        //ChatGPT used
        private FriendRequest friendRequest = new FriendRequest();

        public void displayRequests()
        {
            FriendsRequestsPanel.Controls.Clear();
    

            //ChatGPT used
            //friendRequest.displayRequest(null);

            //ChatGPT used
            friendRequest.GetRequestList();

            int totalRequests = 0;
            foreach (NewRequest R in _RequestList)
            {
                Requests NR = new Requests(R);
                NR.Parent = FriendsRequestsPanel;
                NR.Top = totalRequests * NR.Height;
                FriendsRequestsPanel.Controls.Add(NR);
                totalRequests++;
    
            }

            //ChatGPT used
            FriendsRequestsPanel.Refresh();
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            //ChatGPT used
            //Populates requestlist
            //friendRequest.displayRequest(null,
            //ChatGPT used
            //Populates requestlist
            friendRequest.GetRequestList();

            displayRequests();
        }

        //ChatGPT used
        private void Friends_Shown(object sender, EventArgs e)
        {
            // Ensure the form is visible, then populate data and display requests
            friendRequest.displayRequest(null,
            // Ensure the form is visible, then populate data and display requests
            friendRequest.GetRequestList());
            displayRequests();
        }

        private void FriendsRequestsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
