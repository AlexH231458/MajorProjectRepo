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
    public partial class FriendControl : UserControl
    {
        public NewFriend newFriend;
        public string ID;
        public FriendControl(NewFriend F)
        {
            InitializeComponent();
            newFriend = F;
            this.Load += FriendControl_Load;
        }

        private void FCNicknameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FriendControl_Load(object sender, EventArgs e)
        {
            FCNameLabel.Text = newFriend.UsernameText;
        }

        private void FCNicknameLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FCRemoveButton_Click(object sender, EventArgs e)
        {

        }

        private void FCPinButton_Click(object sender, EventArgs e)
        {

        }

        private void FCNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
