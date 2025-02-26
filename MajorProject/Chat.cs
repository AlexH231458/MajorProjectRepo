using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Data.SqlClient;

namespace MajorProject
{
    public partial class Chat : Form
    {
        public List<NewChat> _ChatList = new List<NewChat>();
        public NewFriend friend;
        public Chat(List<NewChat> chatList, NewFriend Friend)
        {
            //check this may not work
            //friendID = friend.FriendshipID;
            friend = Friend;
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
                friendChat.displayChat(null, new List<NewChat>(), friend);
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
            friendChat.displayChat(null, new List<NewChat>(), friend);
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
            DateTime currentTime = DateTime.Now;
            string text = ChatMessageBox.Text;
            string encryptedText;
            string keyString;
            string vectorString;

            ChatMessageBox.Text = "";
            friendChat.displayChat(null, new List<NewChat>(), friend);
            _ChatList = friendChat.GetChatList();
            displayChats(_ChatList);

            using (Aes AES = Aes.Create())
            {
                encryptedText = Convert.ToBase64String(Encrypt(text, AES.Key, AES.IV));
                keyString = Convert.ToBase64String(AES.Key);
                vectorString = Convert.ToBase64String(AES.IV);
            }

            Information.SqlCon.Open();

            string sql = "INSERT into Messages VALUES (@T, @K, @V, @DT, @F, @S)";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@T", encryptedText);
            cmd.Parameters.AddWithValue("@K", keyString);
            cmd.Parameters.AddWithValue("@V", vectorString);
            cmd.Parameters.AddWithValue("@DT", currentTime);
            cmd.Parameters.AddWithValue(@"F", friend.FriendshipID);
            cmd.Parameters.AddWithValue("@S", Information.userID);
            cmd.ExecuteNonQuery();

            string sql2 = "UPDATE Friends SET LastMessage = @time WHERE FriendshipID = @ID";
            SqlCommand cmd2 = new SqlCommand(sql2, Information.SqlCon);
            cmd2.Parameters.AddWithValue("@time", currentTime);
            cmd2.Parameters.AddWithValue("@ID", friend.FriendshipID);
            cmd2.ExecuteNonQuery();
            
            Information.SqlCon.Close();
        }

        static byte[] Encrypt(string text, byte[] aesKey, byte[] aesVector)
        {
            byte[] encryptedText;

            using (Aes AES = Aes.Create())
            {
                AES.Key = aesKey;
                AES.IV = aesVector;

                using (MemoryStream memory = new MemoryStream())
                {
                    using (CryptoStream crypto = new CryptoStream(memory, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(crypto))
                        {
                            writer.Write(text);
                        }

                        encryptedText = memory.ToArray();
                    }
                }
            }

            return encryptedText;
        }
    }
}
