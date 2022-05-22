namespace App01
{
    partial class signUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.lbNameSurname = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lbCity = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.lbCountry = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lbUsernameEmpty = new System.Windows.Forms.Label();
            this.lbPasswordEmpty = new System.Windows.Forms.Label();
            this.lbEmailEmpty = new System.Windows.Forms.Label();
            this.lbPhoneEmpty = new System.Windows.Forms.Label();
            this.lbNameEmpty = new System.Windows.Forms.Label();
            this.lbCityEmpty = new System.Windows.Forms.Label();
            this.lbCountryEmpty = new System.Windows.Forms.Label();
            this.lbAddressEmpty = new System.Windows.Forms.Label();
            this.lbSignSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.Location = new System.Drawing.Point(12, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 33);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(308, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 33);
            this.txtPassword.TabIndex = 1;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(9, 28);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(60, 15);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(308, 28);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(57, 15);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(12, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 33);
            this.txtEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(9, 125);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(81, 15);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "Email Address";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameSurname.Location = new System.Drawing.Point(9, 240);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(265, 33);
            this.txtNameSurname.TabIndex = 4;
            // 
            // lbNameSurname
            // 
            this.lbNameSurname.AutoSize = true;
            this.lbNameSurname.Location = new System.Drawing.Point(9, 222);
            this.lbNameSurname.Name = "lbNameSurname";
            this.lbNameSurname.Size = new System.Drawing.Size(112, 15);
            this.lbNameSurname.TabIndex = 7;
            this.lbNameSurname.Text = "Name and Surname";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(308, 143);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(265, 33);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(308, 125);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(88, 15);
            this.lbPhoneNumber.TabIndex = 9;
            this.lbPhoneNumber.Text = "Phone Number";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCity.Location = new System.Drawing.Point(308, 240);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(265, 33);
            this.txtCity.TabIndex = 5;
            // 
            // lbCity
            // 
            this.lbCity.AutoSize = true;
            this.lbCity.Location = new System.Drawing.Point(308, 222);
            this.lbCity.Name = "lbCity";
            this.lbCity.Size = new System.Drawing.Size(28, 15);
            this.lbCity.TabIndex = 11;
            this.lbCity.Text = "City";
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCountry.Location = new System.Drawing.Point(9, 328);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(265, 33);
            this.txtCountry.TabIndex = 6;
            // 
            // lbCountry
            // 
            this.lbCountry.AutoSize = true;
            this.lbCountry.Location = new System.Drawing.Point(9, 310);
            this.lbCountry.Name = "lbCountry";
            this.lbCountry.Size = new System.Drawing.Size(50, 15);
            this.lbCountry.TabIndex = 13;
            this.lbCountry.Text = "Country";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(308, 328);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(265, 33);
            this.txtAddress.TabIndex = 7;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(308, 310);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(49, 15);
            this.lbAddress.TabIndex = 15;
            this.lbAddress.Text = "Address";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.Location = new System.Drawing.Point(223, 408);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(137, 46);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lbUsernameEmpty
            // 
            this.lbUsernameEmpty.AutoSize = true;
            this.lbUsernameEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsernameEmpty.Location = new System.Drawing.Point(12, 82);
            this.lbUsernameEmpty.Name = "lbUsernameEmpty";
            this.lbUsernameEmpty.Size = new System.Drawing.Size(163, 15);
            this.lbUsernameEmpty.TabIndex = 17;
            this.lbUsernameEmpty.Text = "Username cannot be empty.";
            this.lbUsernameEmpty.Visible = false;
            // 
            // lbPasswordEmpty
            // 
            this.lbPasswordEmpty.AutoSize = true;
            this.lbPasswordEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPasswordEmpty.Location = new System.Drawing.Point(308, 82);
            this.lbPasswordEmpty.Name = "lbPasswordEmpty";
            this.lbPasswordEmpty.Size = new System.Drawing.Size(158, 15);
            this.lbPasswordEmpty.TabIndex = 18;
            this.lbPasswordEmpty.Text = "Password cannot be empty.";
            this.lbPasswordEmpty.Visible = false;
            // 
            // lbEmailEmpty
            // 
            this.lbEmailEmpty.AutoSize = true;
            this.lbEmailEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmailEmpty.Location = new System.Drawing.Point(12, 179);
            this.lbEmailEmpty.Name = "lbEmailEmpty";
            this.lbEmailEmpty.Size = new System.Drawing.Size(180, 15);
            this.lbEmailEmpty.TabIndex = 19;
            this.lbEmailEmpty.Text = "Email address cannot be empty.";
            this.lbEmailEmpty.Visible = false;
            // 
            // lbPhoneEmpty
            // 
            this.lbPhoneEmpty.AutoSize = true;
            this.lbPhoneEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPhoneEmpty.Location = new System.Drawing.Point(308, 179);
            this.lbPhoneEmpty.Name = "lbPhoneEmpty";
            this.lbPhoneEmpty.Size = new System.Drawing.Size(188, 15);
            this.lbPhoneEmpty.TabIndex = 20;
            this.lbPhoneEmpty.Text = "Phone number cannot be empty.";
            this.lbPhoneEmpty.Visible = false;
            // 
            // lbNameEmpty
            // 
            this.lbNameEmpty.AutoSize = true;
            this.lbNameEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNameEmpty.Location = new System.Drawing.Point(9, 276);
            this.lbNameEmpty.Name = "lbNameEmpty";
            this.lbNameEmpty.Size = new System.Drawing.Size(213, 15);
            this.lbNameEmpty.TabIndex = 21;
            this.lbNameEmpty.Text = "Name and surname cannot be empty.";
            this.lbNameEmpty.Visible = false;
            // 
            // lbCityEmpty
            // 
            this.lbCityEmpty.AutoSize = true;
            this.lbCityEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCityEmpty.Location = new System.Drawing.Point(308, 276);
            this.lbCityEmpty.Name = "lbCityEmpty";
            this.lbCityEmpty.Size = new System.Drawing.Size(127, 15);
            this.lbCityEmpty.TabIndex = 22;
            this.lbCityEmpty.Text = "City cannot be empty.";
            this.lbCityEmpty.Visible = false;
            // 
            // lbCountryEmpty
            // 
            this.lbCountryEmpty.AutoSize = true;
            this.lbCountryEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCountryEmpty.Location = new System.Drawing.Point(9, 364);
            this.lbCountryEmpty.Name = "lbCountryEmpty";
            this.lbCountryEmpty.Size = new System.Drawing.Size(150, 15);
            this.lbCountryEmpty.TabIndex = 23;
            this.lbCountryEmpty.Text = "Country cannot be empty.";
            this.lbCountryEmpty.Visible = false;
            // 
            // lbAddressEmpty
            // 
            this.lbAddressEmpty.AutoSize = true;
            this.lbAddressEmpty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddressEmpty.Location = new System.Drawing.Point(308, 364);
            this.lbAddressEmpty.Name = "lbAddressEmpty";
            this.lbAddressEmpty.Size = new System.Drawing.Size(150, 15);
            this.lbAddressEmpty.TabIndex = 24;
            this.lbAddressEmpty.Text = "Address cannot be empty.";
            this.lbAddressEmpty.Visible = false;
            // 
            // lbSignSuccess
            // 
            this.lbSignSuccess.AutoSize = true;
            this.lbSignSuccess.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSignSuccess.ForeColor = System.Drawing.Color.Green;
            this.lbSignSuccess.Location = new System.Drawing.Point(224, 457);
            this.lbSignSuccess.Name = "lbSignSuccess";
            this.lbSignSuccess.Size = new System.Drawing.Size(134, 15);
            this.lbSignSuccess.TabIndex = 25;
            this.lbSignSuccess.Text = "Signed up successfully!";
            this.lbSignSuccess.Visible = false;
            this.lbSignSuccess.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // signUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 486);
            this.Controls.Add(this.lbSignSuccess);
            this.Controls.Add(this.lbAddressEmpty);
            this.Controls.Add(this.lbCountryEmpty);
            this.Controls.Add(this.lbCityEmpty);
            this.Controls.Add(this.lbNameEmpty);
            this.Controls.Add(this.lbPhoneEmpty);
            this.Controls.Add(this.lbEmailEmpty);
            this.Controls.Add(this.lbPasswordEmpty);
            this.Controls.Add(this.lbUsernameEmpty);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.lbCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lbNameSurname);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "signUp";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtNameSurname;
        private Label lbNameSurname;
        private TextBox txtPhoneNumber;
        private Label lbPhoneNumber;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtCountry;
        private Label lbCountry;
        private TextBox txtAddress;
        private Label lbAddress;
        private Button btnSignUp;
        private Label lbUsernameEmpty;
        private Label lbPasswordEmpty;
        private Label lbEmailEmpty;
        private Label lbPhoneEmpty;
        private Label lbNameEmpty;
        private Label lbCityEmpty;
        private Label lbCountryEmpty;
        private Label lbAddressEmpty;
        private Label lbSignSuccess;
    }
}