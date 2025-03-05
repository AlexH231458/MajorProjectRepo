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
    public partial class MenuFriend : UserControl
    {
        public NewFriend newFriend;
        private List<NewChat> chatList;
        public MenuFriend(NewFriend F)
        {
            InitializeComponent();
            newFriend = F;
            this.Load += MenuFriend_Load;

            //changes font to user setting
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }
        }

        private void MenuFriend_Load(object sender, EventArgs e)
        {
            //displays name of friend
            MFNameLabel.Text = newFriend.UsernameText;
        }

        private void MFChatButton_Click(object sender, EventArgs e)
        {
            //switches to chats form on button click
            Chat ChatForm = new Chat(chatList, newFriend);
            Control MenuForm = this.Parent.Parent;
            MenuForm.Hide();
            ChatForm.Show();
        }
    }
}
