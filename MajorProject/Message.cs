﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace MajorProject
{
    public partial class Message : UserControl
    {
        public NewChat NewMsg;
        public Message(NewChat C)
        {
            InitializeComponent();
            NewMsg = C;
            foreach (Control control in this.Controls)
            {
                float size = control.Font.Size;
                string fName = Information.font.Name.ToString(); ;
                Font font = new Font(fName, size);
                control.Font = font;
            }
            this.Load += Message_Load;
        }

        private void Message_Load(object sender, EventArgs e)
        {
            MessageUser.Font = new Font(MessageUser.Font, FontStyle.Bold);
            MessageTime.Text = NewMsg.Time.ToString("t");
            MessageUser.Text = NewMsg.Name;
            if (MessageUser.Text == "Me")
            {
                MessageUser.ForeColor = Color.MediumVioletRed;
            }
            else
            {
                MessageUser.ForeColor = Color.SteelBlue;
            }
            MessageText.Text = NewMsg.Text;
        }

        private void MessageTime_Click(object sender, EventArgs e)
        {

        }

        private void MessageDelete_Click(object sender, EventArgs e)
        {
            Information.SqlCon.Open();
            string sql = "DELETE FROM Messages WHERE MessageID = @m";
            SqlCommand cmd = new SqlCommand(sql, Information.SqlCon);
            cmd.Parameters.AddWithValue("@m", NewMsg.msgID);
            cmd.ExecuteNonQuery();
            Information.SqlCon.Close();
            this.Hide();
        }

        private void MessageText_Click(object sender, EventArgs e)
        {

        }

        private void MessageUser_Click(object sender, EventArgs e)
        {

        }
    }
}
