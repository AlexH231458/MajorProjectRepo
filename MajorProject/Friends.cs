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
        public List<NewFriend> _FriendsList = new List<NewFriend>();

        public Friends(List<NewRequest> requestList)
        {
            //check parameters... not needed?

            // Assign the passed list
            this._RequestList = requestList;
            InitializeComponent();
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }

            //displayRequests(_RequestList);
        }

        private void FriendReturnButton_Click(object sender, EventArgs e)
        {
            //switches to menu form on button click
            Menu MenuForm = new Menu();
            this.Hide();
            MenuForm.Show();
        }

        private void FriendRequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                Information.SqlCon.Open();

                //finds relevant userID for selected username
                string sql = ("SELECT UserID FROM Users WHERE Username = @U");
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.CommandType.ToString();
                cmd.Parameters.AddWithValue("@U", FriendsSearchBox.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable DT = new DataTable();
                adapter.Fill(DT);
                int newFriend = Convert.ToInt32(DT.Rows[0]["UserID"]);

                //inserts new frienship data into Friends table
                string insert = "INSERT INTO Friends VALUES (@F1, @F2, @N1, @N2, @S, @L)";
                SqlCommand Cmd = new SqlCommand(insert, Information.SqlCon);
                Cmd.Parameters.AddWithValue("@F1", Information.userID);
                Cmd.Parameters.AddWithValue("@N1", Information.userName);
                Cmd.Parameters.AddWithValue("N2", FriendsSearchBox.Text);
                Cmd.Parameters.AddWithValue("@F2", newFriend);
                Cmd.Parameters.AddWithValue("@S", "Requested");
                Cmd.Parameters.AddWithValue("@L", System.DBNull.Value);
                Cmd.ExecuteNonQuery();

                Information.SqlCon.Close();
            }
            catch
            {
                FriendsErrorLabel.Text = "Error: no user selected";
            }
        }

        private List<NewFriend> UserFriends = new List<NewFriend>();
        private FriendDisplay individualFriend = new FriendDisplay();

        public void displayFriends(List<NewFriend> friendsList)
        {
            FriendsFriendsPanel.Controls.Clear();
            List<NewFriend> currentFriendsList = friendsList ?? _FriendsList;
            if (currentFriendsList == null || currentFriendsList.Count == 0)
            {
                individualFriend.displayFriend(null, new List<NewFriend>());
                currentFriendsList = individualFriend.GetFriendsList();
            }
            if (currentFriendsList != null && currentFriendsList.Count > 0)
            {
                int totalFriends = 0;
                foreach (NewFriend friend in currentFriendsList)
                {
                    FriendControl NF = new FriendControl(friend);
                    NF.Parent = FriendsFriendsPanel;
                    NF.Top = totalFriends * NF.Height;
                    FriendsFriendsPanel.Controls.Add(NF);
                    totalFriends++;
                }
                FriendsFriendsPanel.Refresh();
            }
            else
            {
                Label noFriends = new Label();
                noFriends.Text = "You have no friends :(";
                noFriends.Dock = DockStyle.Fill;
                noFriends.TextAlign = ContentAlignment.MiddleCenter;
                FriendsFriendsPanel.Controls.Add(noFriends);
            }
        }

        private List<NewRequest> Requests = new List<NewRequest>();
        private FriendRequest friendRequest = new FriendRequest();

        // display requests to return a list of friend requests
        public void displayRequests(List<NewRequest> requestList)
        {
            // Clear existing  panel
            FriendsRequestsPanel.Controls.Clear();
            // Create a new _RequestList
            List<NewRequest> currentRequestList = requestList ?? _RequestList;
            // Make sure the request list has data in it
            if (currentRequestList == null || currentRequestList.Count == 0)
            {
                // Try to get requests if none in list
                friendRequest.displayRequest(null, new List<NewRequest>());
                currentRequestList = friendRequest.GetRequestList();
            }
            // Check if we have any requests
            if (currentRequestList != null && currentRequestList.Count > 0)
            {
                int totalRequests = 0;
                foreach (NewRequest R in currentRequestList)
                {
                    // Create a new Requests control for each friend request
                    Requests NR = new Requests(R);
                    NR.Parent = FriendsRequestsPanel;
                    NR.Top = totalRequests * NR.Height;
                    FriendsRequestsPanel.Controls.Add(NR);
                    totalRequests++;
                }
                // Refresh the panel so it updates
                FriendsRequestsPanel.Refresh();
            }
            else
            {
                // Add a label or message if no freind requests exist
                Label noFRequests = new Label();
                noFRequests.Text = "No friend requests have been found.";
                noFRequests.Dock = DockStyle.Fill;
                noFRequests.TextAlign = ContentAlignment.MiddleCenter;
                FriendsRequestsPanel.Controls.Add(noFRequests);
            }
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            // Populate and display requests
            friendRequest.displayRequest(null, new List<NewRequest>());
            _RequestList = friendRequest.GetRequestList();
            displayRequests(_RequestList);

            individualFriend.displayFriend(null, new List<NewFriend>());
            _FriendsList = individualFriend.GetFriendsList();
            displayFriends(_FriendsList);
        }

        private void Friends_Shown(object sender, EventArgs e)
        {
            // Additional refresh if needed
            //displayRequests(_RequestList);
        }

        private void FriendsRequestsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FriendsFriendsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FriendsErrorLabel_Click(object sender, EventArgs e)
        {

        }

        private void FriendsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
//Cmd.Parameters.AddWithValue("@UN", Information.userName);
//string sql1 = "SELECT Users.Username FROM Users INNER JOIN Friends ON Users.UserID = Friends.Friend1 WHERE Friends.Status = @Status"; // AND Friends.Friend2 = @Friend2";
//string sql1 = "SELECT Username FROM Users WHERE UserID IN (SELECT Friend1 FROM Friends WHERE Status = @Status AND Friend2 = @Friend2)";
//Cmd1.CommandType.ToString();
//Cmd1.Parameters.AddWithValue("@U", FriendsRequestsPanel.Text);
//Cmd1.Parameters.AddWithValue("@F1", FriendsRequestsPanel.Text);
//Cmd1.Parameters.AddWithValue("@F2", FriendsRequestsPanel.Text);
//Cmd1.Parameters.AddWithValue("@S", FriendsRequestsPanel.Text);
////finds relevant friend requests for that username
//string sql1 = "SELECT * FROM Friends WHERE Friend2 = @UserID";
//SqlCommand Cmd1 = new SqlCommand(sql1, Information.SqlCon);
//Cmd1.Parameters.AddWithValue("@Status", "Requested");
//Cmd1.Parameters.AddWithValue("@Friend2", Information.userID);

////SqlCommand Cmd1 = new SqlCommand(sql1, Information.SqlCon);
//Cmd1.Parameters.AddWithValue("@UserID", Information.userID);

//SqlDataAdapter adapter1 = new SqlDataAdapter(cmd);
//DataTable DT1 = new DataTable();
//adapter1.Fill(DT);
