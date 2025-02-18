using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajorProject
{
    public partial class Chat : Form
    {
        public List<NewChat> _ChatList = new List<NewChat>();
        public int friendID;
        public Chat(List<NewChat> chatList, NewFriend friend)
        {
            //check this may not work
            friendID = friend.FriendID;
            this._ChatList = chatList;
            InitializeComponent();
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }
            this.Load += Chat_Load;
        }

        private List<NewChat> Chats = new List<NewChat>();
        private FriendChat friendChat = new FriendChat();

        public void displayChats(List<NewChat> chatList)
        {
            ChatMessagesPanel.Controls.Clear();
            List<NewChat> currentChatList = chatList ?? _ChatList;
            if (currentChatList == null || currentChatList.Count == 0)
            {
                friendChat.displayChat(null, new List<NewChat>(), friendID);
                currentChatList = friendChat.GetChatList();
            }
            if (currentChatList != null && currentChatList.Count > 0)
            {
                int totalChats = 0;
                foreach (NewChat NC in currentChatList)
                {
                    Message M = new Message(NC);
                    M.Parent = ChatMessagesPanel;
                    M.Top = totalChats * M.Height;
                    ChatMessagesPanel.Controls.Add(M);
                    totalChats++;
                }
                ChatMessagesPanel.Refresh();
            }
            else
            {
                Label noChats = new Label();
                noChats.Text = "No messages have been found";
                noChats.Dock = DockStyle.Fill;
                noChats.TextAlign = ContentAlignment.MiddleCenter;
                ChatMessagesPanel.Controls.Add(noChats);
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            friendChat.displayChat(null, new List<NewChat>(), friendID);
            _ChatList = friendChat.GetChatList();
            displayChats(_ChatList);
        }

        private void ChatMessagesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChatNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void ChatReturnButton_Click(object sender, EventArgs e)
        {
            Menu MenuForm = new Menu();
            this.Hide();
            MenuForm.Show();
        }

        private void ChatMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChatSendButton_Click(object sender, EventArgs e)
        {

        }
    }
}
