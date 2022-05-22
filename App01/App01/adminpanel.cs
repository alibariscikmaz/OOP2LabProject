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
using System.Xml.Linq;
using System.Security.Cryptography;

namespace App01
{
    public partial class adminpanel : Form
    {
        string tempPassword = "";
        public adminpanel()
        {
            InitializeComponent();

            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT Users.Username FROM Users WHERE Users.Username != 'admin' AND Users.IsDeleted != 1";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                selectUserBox.Items.Add(rdr["Username"].ToString());
            }
            cnn.Close();
            selectUserBox.Items.Add("<New User>");
            tempPassword = txtPw.Text;
        }

        private void selectUserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectUserBox.SelectedItem.ToString() == "<New User>") txtUsername.Enabled = true;

            txtUsername.Text = "";
            txtPw.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtAddress.Text = "";

            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT Users.Username, Users.Password, Users.Email, Users.Phone, Users.NameSurname, Users.City, Users.Country, Users.Address FROM Users WHERE Users.Username != 'admin' AND Users.Username = @username AND Users.IsDeleted = 0";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = selectUserBox.SelectedItem.ToString();
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtUsername.Text = (rdr["Username"].ToString());
                txtPw.Text = (rdr["Password"].ToString());
                txtEmail.Text = (rdr["Email"].ToString());
                txtPhone.Text = (rdr["Phone"].ToString());
                txtName.Text = (rdr["NameSurname"].ToString());
                txtCity.Text = (rdr["City"].ToString());
                txtCountry.Text = (rdr["Country"].ToString());
                txtAddress.Text = (rdr["Address"].ToString());
            }
            cnn.Close();
        }

        private void updateBttn_Click(object sender, EventArgs e)
        {
            // THIS BLOCK CHECKS IF THERE'S ANY EMPTY FIELDS IN THE FORM
            bool emptyFieldFlag = false;

            if (txtPw.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtEmail.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtPhone.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtName.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtCity.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtCountry.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtAddress.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }

            if (txtUsername.Text != "" && txtPw.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtName.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtAddress.Text != "") { emptyFieldFlag = false; lbEmptyFieldError.Visible = false; }

            if (emptyFieldFlag == false)
            {
                string query;

                if (txtPw.Text != tempPassword)
                {
                    query = "UPDATE Users SET Users.Password = @password, Users.Email = @email, Users.Phone = @phone, Users.NameSurname = @name, Users.City = @city, Users.Country = @Country, Users.Address = @address WHERE @username = Users.Username";
                }
                else
                {
                    query = "UPDATE Users SET Users.Email = @email, Users.Phone = @phone, Users.NameSurname = @name, Users.City = @city, Users.Country = @Country, Users.Address = @address WHERE @username = Users.Username";
                }

                SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 300).Value = Form1.toSHA256(txtPw.Text);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = txtPhone.Text;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = txtName.Text;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = txtCity.Text;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = txtCountry.Text;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = txtAddress.Text;
                cmd.CommandText = query;
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();

                tempPassword = Form1.toSHA256(txtPw.Text);
                MessageBox.Show("User datas are updated!");
            }
        }

        private void deleteBttn_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "UPDATE Users SET Users.IsDeleted = 1 WHERE @username = Users.Username";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = selectUserBox.SelectedItem.ToString();
            cmd.CommandText = query;
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();

            txtUsername.Text = "";
            txtPw.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            txtCity.Text = "";
            txtCountry.Text = "";
            txtAddress.Text = "";

            selectUserBox.Text = "";
            selectUserBox.Items.Remove(selectUserBox.SelectedItem);
        }

        private void addUserbttn_Click(object sender, EventArgs e)
        {
            // THIS BLOCK CHECKS IF THERE'S ANY EMPTY FIELDS IN THE FORM
            bool emptyFieldFlag = false;

            if (txtUsername.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtPw.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtPhone.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtName.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtCity.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtCountry.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtAddress.Text == "")
            {
                lbEmptyFieldError.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmptyFieldError.Visible = false;
            }

            if (txtUsername.Text != "" && txtPw.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtName.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtAddress.Text != "") { emptyFieldFlag = false; }

            if (emptyFieldFlag == false)
            {
                if (selectUserBox.SelectedItem.ToString() == "<New User>")
                {
                    SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
                    string query = "INSERT INTO Users (Users.Username, Users.Password, Users.Email, Users.Phone, Users.NameSurname, Users.City, Users.Country, Users.Address) " +
                        "VALUES (@username, @password, @email, @phone, @name, @city, @country, @address)";
                    SqlCommand cmd = new SqlCommand(query, cnn);
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtUsername.Text;
                    cmd.Parameters.Add("@password", SqlDbType.NVarChar, 300).Value = Form1.toSHA256(txtPw.Text);
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = txtPhone.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = txtName.Text;
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = txtCity.Text;
                    cmd.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = txtCountry.Text;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = txtAddress.Text;
                    cmd.CommandText = query;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                }
            }
        }
    }
}
