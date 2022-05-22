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
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace App01
{
    public partial class Form1 : Form
    {
        public static bool adminFlag = false;
        public static string UID;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;

            // This part connects the project with the MSSQL DB
            string connectionString;
            SqlConnection cnn;
            connectionString = @"workstation id=OOPProjectDBGp34.mssql.somee.com;packet size=4096;user id=alibaris22_SQLLogin_1;pwd=rc4p9p3rkw;data source=OOPProjectDBGp34.mssql.somee.com;persist security info=False;initial catalog=OOPProjectDBGp34";
            cnn = new SqlConnection(connectionString);

            SqlCommand cmd;
            SqlDataReader rdr;

            string sql = "SELECT * " +
                "FROM Users " +
                "WHERE Users.Username = @username AND Users.Password = @password AND Users.IsDeleted != 1;";

            // Open connection to check data
            cnn.Open();

            cmd = new SqlCommand(sql, cnn);
            // Turning data field texts into parameters for readability of queries and prevent SQL injection attacks.
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtUsernameEntry.Text.ToString();
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 300).Value = toSHA256(txtPasswordEntry.Text);

            rdr = cmd.ExecuteReader();

            // if username and password exists, set loginFlag true
            if (rdr.HasRows) { loginFlag = true; }

            while (rdr.Read())
            {
                if (rdr.GetValue(9).ToString() == "1") { adminFlag = true; Form1.UID = rdr.GetValue(0).ToString(); }
                else { adminFlag = false; Form1.UID = rdr.GetValue(0).ToString(); }
            }
           
            // Close connection after check
            cmd.Dispose();
            cnn.Close();

            if (loginFlag)
            {
                MainMenu form2 = new MainMenu();
                form2.Show();
            }

            else
            {
                System.Windows.Forms.MessageBox.Show("Invalid username or password, please try again!", "TRY AGAIN", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        
        // This method prevents the entry of non-letters into username field
        private void txtUsernameEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void seepw_Click(object sender, EventArgs e)
        {
            if (txtPasswordEntry.PasswordChar == '*')
                txtPasswordEntry.PasswordChar = '\0';
            else
                txtPasswordEntry.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            signUp signform = new signUp();
            signform.Show();
        }
        public static string toSHA256(string s)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();

        }

        private void txtUsernameEntry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}