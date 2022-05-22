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

namespace App01
{
    public partial class settingsScreen : Form
    {
        public settingsScreen()
        {
            InitializeComponent();
            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT US.Difficulty, US.xSize, US.ySize, US.squareShapeTicked, US.triangleShapeTicked, us.circleShapeTicked, US.redColorTicked, US.greenColorTicked, US.blueColorTicked " +
                "FROM Users AS U, UserSettings AS US " +
                "WHERE U.UID = US.UID AND @uid = US.UID; ";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr["Difficulty"].ToString() == "Easy")
                {
                    rbtnEasy.Checked = true;
                }
                else if (rdr["Difficulty"].ToString() == "Normal")
                {
                    rbtnNormal.Checked = true;
                }
                else if (rdr["Difficulty"].ToString() == "Hard")
                {
                    rbtnHard.Checked = true;
                }
                else
                {
                    rbtnCustom.Checked = true;
                }

                if (rbtnCustom.Checked == true)
                {
                    nmrcudXAxis.Value = Int32.Parse(rdr["xSize"].ToString());
                    nmrcudYAxis.Value = Int32.Parse(rdr["ySize"].ToString());
                }

                if (rdr["squareShapeTicked"].ToString() == "1")
                {
                    chklbxShape.SetItemChecked(0, true);
                }
                if (rdr["triangleShapeTicked"].ToString() == "1")
                {
                    chklbxShape.SetItemChecked(1, true);
                }
                if (rdr["circleShapeTicked"].ToString() == "1")
                {
                    chklbxShape.SetItemChecked(2, true);
                }

                if (rdr["redColorTicked"].ToString() == "1")
                {
                    chklbxColor.SetItemChecked(0, true);
                }
                if (rdr["greenColorTicked"].ToString() == "1")
                {
                    chklbxColor.SetItemChecked(1, true);
                }
                if (rdr["blueColorTicked"].ToString() == "1")
                {
                    chklbxColor.SetItemChecked(2, true);
                }
            }
            cnn.Close();
        }

        private void settingsScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            SqlConnection cnn2 = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            SqlConnection cnn3 = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");

            string query = "SELECT US.UID " +
                "FROM Users AS U, UserSettings AS US " +
                "WHERE U.UID = US.UID AND @uid = US.UID; ";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            // UPDATE
            if (rdr.HasRows)
            {
                cnn.Close();
                string query2 = "UPDATE UserSettings " +
                    "SET Difficulty = @difficulty, xSize = @x, ySize = @y, squareShapeTicked = @square, triangleShapeTicked = @triangle, circleShapeTicked = @circle, redColorTicked = @red, greenColorTicked = @green, blueColorTicked = @blue " +
                    "WHERE UID = @uid";
                SqlCommand cmd2 = new SqlCommand(query2, cnn2);
                cmd2.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
                if (rbtnEasy.Checked == true)
                {
                    cmd2.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnEasy.Text;
                    cmd2.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "5";
                    cmd2.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "5";
                }
                else if (rbtnNormal.Checked == true)
                {
                    cmd2.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnNormal.Text;
                    cmd2.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "10";
                    cmd2.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "10";
                }
                else if (rbtnHard.Checked == true)
                {
                    cmd2.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnHard.Text;
                    cmd2.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "15";
                    cmd2.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "15";
                }
                else if (rbtnCustom.Checked == true)
                {
                    cmd2.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnCustom.Text;
                    cmd2.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = nmrcudXAxis.Value.ToString();
                    cmd2.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = nmrcudYAxis.Value.ToString();
                }

                if (chklbxShape.GetItemChecked(0))
                {
                    cmd2.Parameters.Add("@square", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@square", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxShape.GetItemChecked(1))
                {
                    cmd2.Parameters.Add("@triangle", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@triangle", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxShape.GetItemChecked(2))
                {
                    cmd2.Parameters.Add("@circle", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@circle", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(0))
                {
                    cmd2.Parameters.Add("@red", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@red", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(1))
                {
                    cmd2.Parameters.Add("@green", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@green", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(2))
                {
                    cmd2.Parameters.Add("@blue", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd2.Parameters.Add("@blue", SqlDbType.NVarChar, 50).Value = "0";
                }

                cnn2.Open();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                cnn2.Close();
            }
            //INSERT
            else
            {
                string query3 = "INSERT INTO UserSettings (UID, Difficulty, xSize, ySize, squareShapeTicked, triangleShapeTicked, circleShapeTicked, redColorTicked, greenColorTicked, blueColorTicked) " +
                    "VALUES (@uid, @difficulty, @x, @y, @square, @triangle, @circle, @red, @green, @blue);";
                SqlCommand cmd3 = new SqlCommand(query3, cnn3);
                cmd3.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
                if (rbtnEasy.Checked == true)
                {
                    cmd3.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnEasy.Text;
                    cmd3.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "5";
                    cmd3.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "5";
                }
                else if (rbtnNormal.Checked == true)
                {
                    cmd3.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnNormal.Text;
                    cmd3.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "10";
                    cmd3.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "10";
                }
                else if (rbtnHard.Checked == true)
                {
                    cmd3.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnHard.Text;
                    cmd3.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = "15";
                    cmd3.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = "15";
                }
                else if (rbtnCustom.Checked == true)
                {
                    cmd3.Parameters.Add("@difficulty", SqlDbType.NVarChar, 50).Value = rbtnCustom.Text;
                    cmd3.Parameters.Add("@x", SqlDbType.NVarChar, 50).Value = nmrcudXAxis.Value.ToString();
                    cmd3.Parameters.Add("@y", SqlDbType.NVarChar, 50).Value = nmrcudYAxis.Value.ToString();
                }

                if (chklbxShape.GetItemChecked(0))
                {
                    cmd3.Parameters.Add("@square", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@square", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxShape.GetItemChecked(1))
                {
                    cmd3.Parameters.Add("@triangle", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@triangle", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxShape.GetItemChecked(2))
                {
                    cmd3.Parameters.Add("@circle", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@circle", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(0))
                {
                    cmd3.Parameters.Add("@red", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@red", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(1))
                {
                    cmd3.Parameters.Add("@green", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@green", SqlDbType.NVarChar, 50).Value = "0";
                }

                if (chklbxColor.GetItemChecked(2))
                {
                    cmd3.Parameters.Add("@blue", SqlDbType.NVarChar, 50).Value = "1";
                }
                else
                {
                    cmd3.Parameters.Add("@blue", SqlDbType.NVarChar, 50).Value = "0";
                }

                cnn3.Open();
                cmd3.CommandText = query3;
                cmd3.ExecuteNonQuery();
                cnn3.Close();
            }
            lbSaveSuccessful.Visible = true;
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

        private void chklbxShape_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
