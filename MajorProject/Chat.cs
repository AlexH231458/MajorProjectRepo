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
using System.IO.Ports;
using System.Data.SqlClient;

namespace MajorProject
{
    public partial class Chat : Form
    {
        public List<NewChat> _ChatList = new List<NewChat>();
        public NewFriend friend;
        public Chat(NewFriend Friend)
        {
            friend = Friend;
            //_ChatList = chatList;
            InitializeComponent();
            this.Load += Chat_Load;

            //changes colour and font to user setting
            this.BackColor = Information.colour;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }

            //sets the text to the name of the friend
            ChatNameLabel.Text = Friend.UsernameText;
        }

        private List<NewChat> Chats = new List<NewChat>();
        private FriendChat friendChat = new FriendChat();

        public void displayChats(List<NewChat> chatList)
        {
            //clears panel, checks for chats then displays all chats or relevant message
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
                noChats.Font = new Font(Information.font.Name, 12);
                noChats.Text = "No messages have been found";
                noChats.Dock = DockStyle.Fill;
                noChats.TextAlign = ContentAlignment.MiddleCenter;
                ChatMessagesPanel.Controls.Add(noChats);
            }
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            //populate and display chats
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
            //switches to menu form on button click
            Menu MenuForm = new Menu();
            this.Hide();
            MenuForm.Show();
        }

        private void ChatMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChatSendButton_Click(object sender, EventArgs e)
        {
            //stores current time and text in text box
            DateTime currentTime = DateTime.Now;
            string text = ChatMessageBox.Text;

            //reads and stores a list of banned words from a text file
            List<string> banned = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader("Words.txt");
            while (file.EndOfStream == false)
            {
                banned.Add(file.ReadLine());
            }
            file.Close();

            //replaces banned words with ****
            foreach (string ban in banned)
            {
                text = text.Replace(ban, "****");
            }

            //autoshift capitalise the start of sentences if turned on from settings
            if (Information.autoShift == 1 && text.Length > 2)
            {
                string original = text;
                string newText = original.Substring(0, 1).ToUpper() + original.Substring(1, 1);

                for (int i = 2; i < original.Length; i++)
                {
                    if (original.Substring(i - 2, 2) == ". " || original.Substring(i - 2, 2) == "? " || original.Substring(i - 2, 2) == "! ")
                    {
                        newText = newText + original.Substring(i, 1).ToUpper();
                    }
                    else
                    {
                        newText = newText + original.Substring(i, 1);
                    }
                }
                text = newText;
            }

            //encrypts text using AES encryption
            string encryptedText;
            string keyString;
            string vectorString;
            using (Aes AES = Aes.Create())
            {
                encryptedText = Convert.ToBase64String(Encrypt(text, AES.Key, AES.IV));
                keyString = Convert.ToBase64String(AES.Key);
                vectorString = Convert.ToBase64String(AES.IV);
            }

            //adds encrypted message to the database
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

            //updates last message time in friends table to current time
            string sql2 = "UPDATE Friends SET LastMessage = @time WHERE FriendshipID = @ID";
            SqlCommand cmd2 = new SqlCommand(sql2, Information.SqlCon);
            cmd2.Parameters.AddWithValue("@time", currentTime);
            cmd2.Parameters.AddWithValue("@ID", friend.FriendshipID);
            cmd2.ExecuteNonQuery();
            Information.SqlCon.Close();

            //refreshes the chat form to show new chat
            Chat ChatForm = new Chat(friend);
            this.Hide();
            ChatForm.Show();
        }

        static byte[] Encrypt(string text, byte[] aesKey, byte[] aesVector)
        {
            byte[] encryptedText;
            using (Aes AES = Aes.Create())
            {
                //assigns key and initialisation vector
                AES.Key = aesKey;
                AES.IV = aesVector;

                //memory stream stores encrypted data
                using (MemoryStream memory = new MemoryStream())
                {
                    //cyrpto stream encrypts the data
                    using (CryptoStream crypto = new CryptoStream(memory, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        //streamwriter writes plain text to the cryptostream
                        using (StreamWriter writer = new StreamWriter(crypto))
                        {
                            writer.Write(text);
                        }
                        //converts to a byte array
                        encryptedText = memory.ToArray();
                    }
                }
            }
            return encryptedText;
        }

        //each button adds a different emoji to the text box
        private void ChatSmile_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "😀";
        }

        private void ChatFrown_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "🙁";
        }

        private void ChatSilly_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "😜";
        }

        private void ChatHeart_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "😍";
        }

        private void ChatAngry_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "😠";
        }

        private void ChatCool_Click(object sender, EventArgs e)
        {
            ChatMessageBox.Text = ChatMessageBox.Text + "😎";
        }
    }
}
