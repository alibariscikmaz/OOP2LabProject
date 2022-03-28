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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            config();

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

        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            
            //gets project's \bin\debug directory
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            StreamWriter txt = new StreamWriter(currentpath+"\\config.txt");
            if (radioButton1.Checked) txt.WriteLine("Hard");
            else txt.WriteLine("empty");
            if (radioButton2.Checked) txt.WriteLine("Normal");
            else txt.WriteLine("empty");
            if (radioButton3.Checked) txt.WriteLine("Easy");
            else txt.WriteLine("empty");
            if (radioButton4.Checked)
            {
                txt.WriteLine("Custom");
                txt.WriteLine(numericUpDown1.Value);
                txt.WriteLine(numericUpDown2.Value);
            }
            else 
            {
                txt.WriteLine("empty");
                txt.WriteLine("empty");
                txt.WriteLine("empty");
            }

            if (checkedListBox1.GetItemCheckState(0) == CheckState.Checked) txt.WriteLine("Square");
            else txt.WriteLine("empty");
            if (checkedListBox1.GetItemCheckState(1) == CheckState.Checked) txt.WriteLine("Triangle");
            else txt.WriteLine("empty");
            if (checkedListBox1.GetItemCheckState(2) == CheckState.Checked) txt.WriteLine("Circle");
            else txt.WriteLine("empty");

            txt.Close();
            
        }
        private void config()
        {
            string currentpath = System.IO.Directory.GetCurrentDirectory();
            if (!File.Exists(currentpath + "\\config.txt"))
            {
                StreamWriter txta = new StreamWriter(currentpath + "\\config.txt");
                txta.Close();
            }

            StreamReader txtb = new StreamReader(currentpath + "\\config.txt");

            while (!txt.EndOfStream)
            {
                if (txt.ReadLine() == "Hard") radioButton1.Checked = true;
                if (txt.ReadLine() == "Normal") radioButton2.Checked = true;
                if (txt.ReadLine() =="Easy") radioButton3.Checked = true;
                if (txt.ReadLine() == "Custom")
                {
                    radioButton4.Checked = true;
                    numericUpDown1.Value = Int32.Parse(txt.ReadLine());
                    numericUpDown2.Value = Int32.Parse(txt.ReadLine());
                }
                else
                {
                    txt.ReadLine();
                    txt.ReadLine();
                }
               

                if (txt.ReadLine() == "Square") checkedListBox1.SetItemChecked(0,true);
                if (txt.ReadLine() == "Triangle") checkedListBox1.SetItemChecked(1, true);
                if (txt.ReadLine() == "Circle") checkedListBox1.SetItemChecked(2, true);
                

            }
            txt.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked == true)
            {
                numericUpDown1.Visible = true;
                numericUpDown2.Visible = true;
            }
            else
            {
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
            }
        }
    }
}