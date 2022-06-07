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

namespace App01
{
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();

            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT U.Username, US.highestScore " +
                "FROM Users AS U, UserSettings AS US " +
                "WHERE US.UID = U.UID;";
            SqlCommand cmd = new SqlCommand(query, cnn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cnn.Open();
            adapter.Fill(dt);
            dgwLeaderBoard.DataSource = dt;
            cnn.Close();
        }
    }
}
