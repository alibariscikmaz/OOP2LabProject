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

namespace App01
{
    public partial class ProfilePage : Form
    {

        string tempPassword = ""; 
        public ProfilePage()
        {
            InitializeComponent();
            SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
            string query = "SELECT Users.Username, Users.Password, Users.Email, Users.Phone, Users.NameSurname, Users.City, Users.Country, Users.Address FROM Users WHERE Users.UID = @uid";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.Add("@uid", SqlDbType.Int, 100).Value = Form1.UID;
            cmd.CommandText = query;
            cnn.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtUsername.Text = (rdr["Username"].ToString());
                txtPassword.Text = (rdr["Password"].ToString());
                txtEmail.Text = (rdr["Email"].ToString());
                txtPhone.Text = (rdr["Phone"].ToString());
                txtName.Text = (rdr["NameSurname"].ToString());
                txtCity.Text = (rdr["City"].ToString());
                txtCountry.Text = (rdr["Country"].ToString());
                txtAddress.Text = (rdr["Address"].ToString());
            }
            cnn.Close();
            tempPassword = txtPassword.Text;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // THIS BLOCK CHECKS IF THERE'S ANY EMPTY FIELDS IN THE FORM
            bool emptyFieldFlag = false;

            if (txtPassword.Text == "")
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

            if (txtUsername.Text != "" && txtPassword.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" && txtName.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtAddress.Text != "") { emptyFieldFlag = false; lbEmptyFieldError.Visible = false; }

            if (emptyFieldFlag == false)
            {
                string query;

                if (txtPassword.Text != tempPassword)
                {
                    query = "UPDATE Users SET Users.Password = @password, Users.Email = @email, Users.Phone = @phone, Users.NameSurname = @name, Users.City = @city, Users.Country = @Country, Users.Address = @address WHERE @username = Users.Username";
                }
                else
                {
                    query = "UPDATE Users SET Users.Email = @email, Users.Phone = @phone, Users.NameSurname = @name, Users.City = @city, Users.Country = @Country, Users.Address = @address WHERE @username = Users.Username";
                }

                SqlConnection cnn = new SqlConnection(@"workstation id = OOPProjectDBGp34.mssql.somee.com; packet size = 4096; user id = alibaris22_SQLLogin_1; pwd = rc4p9p3rkw; data source = OOPProjectDBGp34.mssql.somee.com; persist security info = False; initial catalog = OOPProjectDBGp34");
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 300).Value = Form1.toSHA256(txtPassword.Text);
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
                MessageBox.Show("User datas are updated!");
                tempPassword = Form1.toSHA256(txtPassword.Text);
            }
        }
    }
}
