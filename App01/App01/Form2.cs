using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;

            }

            else panel1.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            int count = checkedListBox1.Items.Count;//get checked item count
            for (int i = 0; i < count; i++)
            {
                //uncheck other items when another item is checked
                if (index != i)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}