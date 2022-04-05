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

namespace App01
{
    public partial class settingsScreen : Form
    {
        public settingsScreen()
        {
            InitializeComponent();
        }

        private void settingsScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create the xml file for saving settings
            XmlTextWriter settingsConfig = new XmlTextWriter("settingsconfig.xml", Encoding.UTF8);
            settingsConfig.Formatting = Formatting.Indented;
            settingsConfig.WriteStartDocument();
            settingsConfig.WriteStartElement("savedSettings");

            // Save difficulty settings to xml file
            if (rbtnEasy.Checked){
                settingsConfig.WriteElementString("difficulty", rbtnEasy.Text);
                settingsConfig.WriteElementString("xAxis", "5");
                settingsConfig.WriteElementString("yAxis", "5");
            }
            if (rbtnNormal.Checked){
                settingsConfig.WriteElementString("difficulty", rbtnNormal.Text);
                settingsConfig.WriteElementString("xAxis", "10");
                settingsConfig.WriteElementString("yAxis", "10");
            }
            if (rbtnHard.Checked){
                settingsConfig.WriteElementString("difficulty", rbtnHard.Text);
                settingsConfig.WriteElementString("xAxis", "15");
                settingsConfig.WriteElementString("yAxis", "15");
            }
            if (rbtnCustom.Checked){
                settingsConfig.WriteElementString("difficulty", rbtnCustom.Text);
                settingsConfig.WriteElementString("xAxis", nmrcudXAxis.Text);
                settingsConfig.WriteElementString("yAxis", nmrcudYAxis.Text);
            }

            // Save each shape setting selected to xml file with checked shape count
            settingsConfig.WriteElementString("shapeCount", chklbxShape.CheckedItems.Count.ToString());
            for (int i = 0; i < chklbxShape.CheckedItems.Count; i++)
            {
                settingsConfig.WriteElementString("checkedShape" + i, chklbxShape.CheckedItems[i].ToString());
            }

            // Save each color setting selected to xml file with checked color count
            settingsConfig.WriteElementString("colorCount", chklbxColor.CheckedItems.Count.ToString());
            for (int i = 0; i < chklbxColor.CheckedItems.Count; i++)
            {
                settingsConfig.WriteElementString("checkedColor" + i, chklbxColor.CheckedItems[i].ToString());
            }

            settingsConfig.WriteEndElement();
            settingsConfig.Close();
        }
    }
}
