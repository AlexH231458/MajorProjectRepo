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
        public NewFriend friend;
        public Chat(NewFriend newF)
        {
            InitializeComponent();
            friend = newF;
            this.Load += Chat_Load;
        }

        private void Chat_Load(object sender, EventArgs e)
        {

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
