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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MajorProject
{
    public partial class Friends : Form
    {
        public List<NewRequest> _RequestList = new List<NewRequest>();
        public List<NewFriend> _FriendsList = new List<NewFriend>();

        public Friends()
        {
            InitializeComponent();

            //changes colour and font to user settings
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }
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
            Information.SqlCon.Open();
            try
            {
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
            }
            catch
            {
                //error message displayed if invalid username is input
                FriendsErrorLabel.Text = "Error: no user selected";
            }
            //clears text box
            FriendsSearchBox.Text = "";
            Information.SqlCon.Close();
        }

        private List<NewFriend> UserFriends = new List<NewFriend>();
        private FriendDisplay individualFriend = new FriendDisplay();

        public void displayFriends(List<NewFriend> friendsList)
        {
            //clears panel, checks for friends then displays all current friends or relevant message
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
                noFriends.Font = new Font(Information.font.Name, 12);
                noFriends.Text = "You have no friends :(";
                noFriends.Dock = DockStyle.Fill;
                noFriends.TextAlign = ContentAlignment.MiddleCenter;
                FriendsFriendsPanel.Controls.Add(noFriends);
            }
        }

        private List<NewRequest> Requests = new List<NewRequest>();
        private FriendRequest friendRequest = new FriendRequest();

        public void displayRequests(List<NewRequest> requestList)
        {
            //clears panel, checks for requests then displays all requests or relevant message
            FriendsRequestsPanel.Controls.Clear();
            List<NewRequest> currentRequestList = requestList ?? _RequestList;
            if (currentRequestList == null || currentRequestList.Count == 0)
            {
                friendRequest.displayRequest(null, new List<NewRequest>());
                currentRequestList = friendRequest.GetRequestList();
            }
            if (currentRequestList != null && currentRequestList.Count > 0)
            {
                int totalRequests = 0;
                foreach (NewRequest R in currentRequestList)
                {
                    Requests NR = new Requests(R);
                    NR.Parent = FriendsRequestsPanel;
                    NR.Top = totalRequests * NR.Height;
                    FriendsRequestsPanel.Controls.Add(NR);
                    totalRequests++;
                }
                FriendsRequestsPanel.Refresh();
            }
            else
            {
                Label noFRequests = new Label();
                noFRequests.Font = new Font(Information.font.Name, 12);
                noFRequests.Text = "No friend requests have been found.";
                noFRequests.Dock = DockStyle.Fill;
                noFRequests.TextAlign = ContentAlignment.MiddleCenter;
                FriendsRequestsPanel.Controls.Add(noFRequests);
            }
        }

        private void Friends_Load(object sender, EventArgs e)
        {
            //populate and display requests
            friendRequest.displayRequest(null, new List<NewRequest>());
            _RequestList = friendRequest.GetRequestList();
            displayRequests(_RequestList);

            //populate and display friends
            individualFriend.displayFriend(null, new List<NewFriend>());
            _FriendsList = individualFriend.GetFriendsList();
            displayFriends(_FriendsList);

            //tries to find users that current user is not friends with to recommend
            try
            {
                List<int> userFriends = new List<int>();
                foreach (NewFriend friend in _FriendsList)
                {
                    userFriends.Add(friend.FriendID);
                }

                List<string> users = new List<string>();
                Information.SqlCon.Open();
                string sql = "SELECT UserID, Username FROM Users WHERE UserID != @u";
                SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
                cmd.Parameters.AddWithValue("@u", Information.userID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (!userFriends.Contains(Convert.ToInt32(dr["UserID"])))
                    {
                        users.Add(Convert.ToString(dr["Username"]));
                    }
                }
                Information.SqlCon.Close();

                //randomly displays a user from the list found
                Random rnd = new Random();
                int number = rnd.Next(users.Count);
                FriendsRecLabel.Text = "Recommended:    " + users[number];
            }
            catch
            {
                //message displayed if no users can be found
                FriendsRecLabel.Text = "Recommended:    No users found";
            }
        }

        private void Friends_Shown(object sender, EventArgs e)
        {

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

        private void FriendsRecLabel_Click(object sender, EventArgs e)
        {

        }

        private void FriendsRequestsLabel_Click(object sender, EventArgs e)
        {

        }

        private void FriendsFriendsLabel_Click(object sender, EventArgs e)
        {

        }

        private void FriendTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}