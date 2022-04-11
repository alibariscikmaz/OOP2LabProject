namespace App01
{
    partial class adminpanel
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
            this.selectUserBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserbttn = new System.Windows.Forms.Button();
            this.updateBttn = new System.Windows.Forms.Button();
            this.deleteBttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectUserBox
            // 
            this.selectUserBox.FormattingEnabled = true;
            this.selectUserBox.Location = new System.Drawing.Point(33, 40);
            this.selectUserBox.Name = "selectUserBox";
            this.selectUserBox.Size = new System.Drawing.Size(121, 23);
            this.selectUserBox.TabIndex = 0;
            this.selectUserBox.SelectedIndexChanged += new System.EventHandler(this.selectUserBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select User";
            // 
            // addUserbttn
            // 
            this.addUserbttn.Location = new System.Drawing.Point(502, 415);
            this.addUserbttn.Name = "addUserbttn";
            this.addUserbttn.Size = new System.Drawing.Size(119, 23);
            this.addUserbttn.TabIndex = 2;
            this.addUserbttn.Text = "Add New User";
            this.addUserbttn.UseVisualStyleBackColor = true;
            // 
            // updateBttn
            // 
            this.updateBttn.Location = new System.Drawing.Point(650, 415);
            this.updateBttn.Name = "updateBttn";
            this.updateBttn.Size = new System.Drawing.Size(120, 23);
            this.updateBttn.TabIndex = 3;
            this.updateBttn.Text = "Update User Info";
            this.updateBttn.UseVisualStyleBackColor = true;
            this.updateBttn.Click += new System.EventHandler(this.updateBttn_Click);
            // 
            // deleteBttn
            // 
            this.deleteBttn.Location = new System.Drawing.Point(376, 415);
            this.deleteBttn.Name = "deleteBttn";
            this.deleteBttn.Size = new System.Drawing.Size(94, 23);
            this.deleteBttn.TabIndex = 4;
            this.deleteBttn.Text = "Delete User";
            this.deleteBttn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name-Surname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Country";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(618, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Address";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(33, 152);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(151, 23);
            this.txtUsername.TabIndex = 13;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(228, 152);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(151, 23);
            this.txtPw.TabIndex = 14;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(423, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(151, 23);
            this.txtEmail.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(618, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(151, 23);
            this.txtPhone.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(618, 247);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(151, 23);
            this.txtAddress.TabIndex = 20;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(423, 247);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(151, 23);
            this.txtCountry.TabIndex = 19;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(228, 247);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 23);
            this.txtCity.TabIndex = 18;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(33, 247);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 23);
            this.txtName.TabIndex = 17;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteBttn);
            this.Controls.Add(this.updateBttn);
            this.Controls.Add(this.addUserbttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectUserBox);
            this.Name = "adminpanel";
            this.Text = "adminpanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectUserBox;
        private Label label1;
        private Button addUserbttn;
        private Button updateBttn;
        private Button deleteBttn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtUsername;
        private TextBox txtPw;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtName;
    }
}