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
    static class Information
    {
        //SQL connection for relevant location of server

        //static public SqlConnection SqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Right Click\source\repos\MajorProjectRepo\MajorProject\AppData\Database.mdf;Integrated Security=True");
        static public SqlConnection SqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\alexh\source\repos\MajorProjectRepo\MajorProject\AppData\Database.mdf;Integrated Security = True");
        //static public SqlConnection SqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\AQ231458\source\repos\AlexH231458\MajorProjectRepo\MajorProject\AppData\Database.mdf;Integrated Security = True");


        static public string userName;
        static public int userID;
        static public bool autoShift;
        static public string font;
        static public string colour;
    }
}
