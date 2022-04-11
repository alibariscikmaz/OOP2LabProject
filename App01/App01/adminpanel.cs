using System;
using System.Collections.Generic;
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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
            var xDoc = XDocument.Load("userInfo.xml");
            var userNames = xDoc.Elements("User").Elements("username").Select(e => e.Value);

            foreach (var name in userNames)
            {
                selectUserBox.Items.Add(name.ToString());
            }
        }

        private void selectUserBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updateBttn_Click(object sender, EventArgs e)
        {

        }
    }
}
