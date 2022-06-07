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
            if (Form1.adminFlag == true)
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnProfile.Visible = true;
            }
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

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            aboutScreen aboutUs = new aboutScreen();
            aboutUs.ShowDialog();
            aboutUs.TopMost = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfilePage pPage = new ProfilePage();
            pPage.ShowDialog();
            pPage.TopMost = true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            gamescreen playScreen = new gamescreen();
            playScreen.ShowDialog();
        }

        private void bttnHelp_Click(object sender, EventArgs e)
        {
            help help = new help();
            help.ShowDialog();
            help.TopMost = true;
        }
    }
}