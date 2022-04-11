using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace App01
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void settingsbutton_Click(object sender, EventArgs e) // settings button click event
        {
            settingsScreen settings = new settingsScreen();
            settings.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminpanel admin = new adminpanel();
            admin.ShowDialog();
        }
    }
}