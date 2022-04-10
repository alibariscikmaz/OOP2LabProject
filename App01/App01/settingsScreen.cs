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
            loadOptions();
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

            // Close xml file after writing
            settingsConfig.WriteEndElement();
            settingsConfig.Close();
            lbSaveSuccessful.Visible = true;
        }
        private void loadOptions()
        {
            // Open the saved settings xml file
            int checkedShapeCount = 0, checkedColorCount = 0;
            XmlTextReader reader = new XmlTextReader("settingsconfig.xml");

            // Start reading
            while(reader.Read())
            {
                // Read only elements
                if(reader.NodeType == XmlNodeType.Element)
                {
                    // If element name is difficulty, load the saved difficulty
                    if (reader.Name == "difficulty")
                    {
                        string difficultyValue = reader.ReadString().ToString();
                        if (difficultyValue == rbtnEasy.Text)
                            rbtnEasy.Checked = true;
                        if (difficultyValue == rbtnNormal.Text)
                            rbtnNormal.Checked = true;
                        if (difficultyValue == rbtnHard.Text)
                            rbtnHard.Checked = true;
                        if (difficultyValue == rbtnCustom.Text)
                            rbtnCustom.Checked = true;
                    }
                    
                    // If difficulty is custom, load the saved axis'
                    if (reader.Name == "xAxis")
                    {
                        string xValue = reader.ReadString().ToString();
                        if (rbtnCustom.Checked)
                        {
                           nmrcudXAxis.Text = xValue;
                        }
                    }

                    if (reader.Name == "yAxis")
                    {
                        string yValue = reader.ReadString().ToString();
                        if (rbtnCustom.Checked)
                        {
                            nmrcudYAxis.Text = yValue;
                        }
                    }

                    // Get shapeCount for the loop of controlling checked shape elements
                    if (reader.Name == "shapeCount") 
                        checkedShapeCount = Int32.Parse(reader.ReadString().ToString());

                    // Load checked shape elements in a loop
                    for (int i = 0; i < checkedShapeCount; i++)
                    {
                        if (reader.Name == "checkedShape" + i)
                        {
                            string shapeName = reader.ReadString().ToString();
                            if (shapeName == "Square")
                                chklbxShape.SetItemChecked(0, true);
                            if (shapeName == "Triangle")
                                chklbxShape.SetItemChecked(1, true);
                            if (shapeName == "Circle")
                                chklbxShape.SetItemChecked(2, true);
                        }
                    }

                    // Get colorCount for the loop of controlling checked color elements
                    if (reader.Name == "colorCount")
                        checkedColorCount = Int32.Parse(reader.ReadString().ToString());

                    // Load checked color elements in a loop
                    for (int i = 0; i < checkedColorCount; i++)
                    {
                        if (reader.Name == "checkedColor" + i)
                        {
                            string shapeName = reader.ReadString().ToString();
                            if (shapeName == "Red")
                                chklbxColor.SetItemChecked(0, true);
                            if (shapeName == "Green")
                                chklbxColor.SetItemChecked(1, true);
                            if (shapeName == "Blue")
                                chklbxColor.SetItemChecked(2, true);
                        }
                    }
                }
            }
            // Close xml file after reading
            reader.Close();
        }

        private void rbtnCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCustom.Checked)
            {
                nmrcudXAxis.Visible = true;
                nmrcudYAxis.Visible = true;
            }
            else
            {
                nmrcudXAxis.Visible = false;
                nmrcudYAxis.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
