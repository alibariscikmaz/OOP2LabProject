using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginFlag = false;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("userInfo.xml");
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Users/User");

            foreach (XmlNode node in nodeList)
            {
                if (node.SelectSingleNode("username").InnerText == txtUsernameEntry.Text && 
                    node.SelectSingleNode("password").InnerText == toSHA256(txtPasswordEntry.Text))
                {
                    loginFlag = true;
                }
            }



            if (loginFlag)
            {
                MainMenu form2 = new MainMenu();
                form2.Show();
            }

            else
                System.Windows.Forms.MessageBox.Show("Invalid username or password, please try again!", "TRY AGAIN", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

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
    }
}