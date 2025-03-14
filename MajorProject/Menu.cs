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

namespace MajorProject
{
    public partial class Menu : Form
    {
        public List<NewFriend> FriendsList = new List<NewFriend>();
        private FriendDisplay individualFriend = new FriendDisplay();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //changes colour and font to user setting
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }

            //populate and display friends
            individualFriend.displayFriend(null, new List<NewFriend>());
            FriendsList = individualFriend.GetFriendsList();
            displayFriends(FriendsList);
        }

        private void MenuSettingsButton_Click(object sender, EventArgs e)
        {
            //switches to settings form on button click
            Settings SettingsForm = new Settings();
            this.Hide();
            SettingsForm.Show();
        }

        private void MenuFriendsButton_Click(object sender, EventArgs e)
        {
            //switches to friends form on button click
            Friends FriendsForm = new Friends();
            this.Hide();
            FriendsForm.Show();
        }


        public void displayFriends(List<NewFriend> friendsList)
        {
            //finds which user is pinned to display at the top
            Information.SqlCon.Open();
            string sql = "SELECT PinnedUser FROM Users WHERE UserID = @U";
            SqlCommand cmd1 = new SqlCommand(sql, Information.SqlCon);
            cmd1.Parameters.AddWithValue("@U", Information.userID);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            int pin = 0;
            try
            {
                pin = Convert.ToInt32(dt1.Rows[0]["PinnedUser"]);
            }
            catch
            {
                //message displayed if no pinned user can be found
                Label noPin = new Label();
                noPin.Font = new Font(Information.font.Name, 12);
                noPin.Text = "Pin a user in Friends";
                noPin.Dock = DockStyle.Fill;
                noPin.TextAlign = ContentAlignment.MiddleCenter;
                MenuPinnedPanel.Controls.Add(noPin);
            }
            Information.SqlCon.Close();

            //clears panel, checks for friends then displays all current friends or relevant message
            MenuAllPanel.Controls.Clear();
            List<NewFriend> currentFriendsList = friendsList ?? FriendsList;
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
                    MenuFriend NF = new MenuFriend(friend);
                    if (friend.FriendshipID == pin)
                    {
                        NF.Parent = MenuPinnedPanel;
                    }
                    else
                    {
                        NF.Parent = MenuAllPanel;
                        NF.Top = totalFriends * NF.Height;
                        MenuAllPanel.Controls.Add(NF);
                        totalFriends++;
                    }
                }
                MenuAllPanel.Refresh();
            }
            else
            {
                Label noFriends = new Label();
                noFriends.Font = new Font(Information.font.Name, 12);
                noFriends.Text = "You have no friends :(";
                noFriends.Dock = DockStyle.Fill;
                noFriends.TextAlign = ContentAlignment.MiddleCenter;
                MenuAllPanel.Controls.Add(noFriends);
            }
        }

        private void MenuAllPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPinnedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPinnedLabel_Click(object sender, EventArgs e)
        {

        }

        private void MenuAllLabel_Click(object sender, EventArgs e)
        {

        }

        private void MenuHeadingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
