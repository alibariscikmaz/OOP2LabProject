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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
            createUsers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            int userCount = getUserCount();

                XDocument doc = XDocument.Load(currentpath + "\\userInfo.xml");
            var newElement = new XElement("User" + userCount.ToString(),
                 new XElement("username", txtUsername.Text),
                 new XElement("password", txtPassword.Text),
                 new XElement("email", txtEmail.Text),
                 new XElement("phone", txtPhoneNumber.Text),
                 new XElement("name", txtNameSurname.Text),
                 new XElement("city", txtCity.Text),
                 new XElement("country", txtCountry.Text),
                 new XElement("address", txtAddress.Text)
                 );
            doc.Element("Users").Add(newElement);
            doc.Save(currentpath + "\\userInfo.xml");

            StreamWriter txt = new StreamWriter(currentpath + "\\userCount.txt");
            txt.WriteLine(userCount + 1);
            txt.Close();
        }

        private int getUserCount()
        {
            int userCount = 0;
            string currentpath = System.IO.Directory.GetCurrentDirectory();

            if (!File.Exists(currentpath + "\\userCount.txt"))
            {
                StreamWriter txt = new StreamWriter(currentpath + "\\userCount.txt");
                txt.WriteLine(userCount);
                txt.Close();
            }

            else
            {
                StreamReader txt = new StreamReader(currentpath + "\\userCount.txt");
                userCount = Int32.Parse(txt.ReadLine());
                txt.Close();
            }

            return userCount;
        }

        private void createUsers()
        {
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            if (!File.Exists(currentpath + "\\userInfo.xml"))
            {
                XDocument doc = new XDocument(
                    new XElement("Users"));
                doc.Save(currentpath + "\\userInfo.xml");
            }
        }

    }
}
