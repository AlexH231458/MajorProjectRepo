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
    public partial class Requests : UserControl
    {
        public NewRequest NewRequest;

        public Requests(NewRequest R)
        {
            InitializeComponent();
            NewRequest = R;
        }


        public void Requests_Load(object sender, EventArgs e)
        {
            UsernameText.Text = NewRequest.UsernameText;
        }
    }
}
