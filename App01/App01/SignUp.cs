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
    public partial class signUp : Form
    {
        public signUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // THIS BLOCK CHECKS IF THERE'S ANY EMPTY FIELDS IN THE FORM
            bool emptyFieldFlag = false;

            if (txtUsername.Text == "")
            {
                lbUsernameEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbUsernameEmpty.Visible = false;
            }

            if (txtPassword.Text == "")
            {
                lbPasswordEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbPasswordEmpty.Visible = false;
            }

            if (txtEmail.Text == "")
            {
                lbEmailEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbEmailEmpty.Visible = false;
            }

            if (txtPhoneNumber.Text == "")
            {
                lbPhoneEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbPhoneEmpty.Visible = false;
            }

            if (txtNameSurname.Text == "")
            {
                lbNameEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbNameEmpty.Visible = false;
            }

            if (txtCity.Text == "")
            {
                lbCityEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbCityEmpty.Visible = false;
            }

            if (txtCountry.Text == "")
            {
                lbCountryEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbCountryEmpty.Visible = false;
            }

            if (txtAddress.Text == "")
            {
                lbAddressEmpty.Visible = true;
                emptyFieldFlag = true;
            }
            else
            {
                lbAddressEmpty.Visible = false;
            }

            if (txtUsername.Text != "" && txtPassword.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "" && txtNameSurname.Text != "" && txtCity.Text != "" && txtCountry.Text != "" && txtAddress.Text != "") { emptyFieldFlag = false; }

            // IF THERE'S NOT ANY EMPTY FIELDS, IT WRITES THE DATAS TO THE DB
            if (emptyFieldFlag == false)
            {
                // This part connects the project with the MSSQL DB
                string connectionString;
                SqlConnection cnn;
                connectionString = @"workstation id=OOPProjectDBGp34.mssql.somee.com;packet size=4096;user id=alibaris22_SQLLogin_1;pwd=rc4p9p3rkw;data source=OOPProjectDBGp34.mssql.somee.com;persist security info=False;initial catalog=OOPProjectDBGp34";
                cnn = new SqlConnection(connectionString);

                SqlCommand cmd;

                string sql = "INSERT INTO Users (Username, Password, Email, Phone, NameSurname, City, Country, Address) " +
                    "VALUES (@username, @password, @email, @phone, @namesurname, @city, @country, @address)";

                // Open connection to insert data
                cnn.Open();

                cmd = new SqlCommand(sql, cnn);
                // Turning data field texts into parameters for readability of queries and prevent SQL injection attacks.
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = txtUsername.Text.ToString();
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 300).Value = toSHA256(txtPassword.Text);
                cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50).Value = txtEmail.Text;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar, 50).Value = txtPhoneNumber.Text;
                cmd.Parameters.Add("@namesurname", SqlDbType.NVarChar, 50).Value = txtNameSurname.Text;
                cmd.Parameters.Add("@city", SqlDbType.NVarChar, 50).Value = txtCity.Text;
                cmd.Parameters.Add("@country", SqlDbType.NVarChar, 50).Value = txtCountry.Text;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = txtAddress.Text;

                // Execute SQL Query to insert new user into DB
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                // Close connection after insertion
                cnn.Close();

                lbSignSuccess.Visible = true;
            }
        }

        public static string toSHA256(string s)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(s));

            var sb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();  
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
