namespace App01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsernameEntry = new System.Windows.Forms.TextBox();
            this.txtPasswordEntry = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.seepw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsernameEntry
            // 
            this.txtUsernameEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsernameEntry.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsernameEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.txtUsernameEntry.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtUsernameEntry.Location = new System.Drawing.Point(172, 200);
            this.txtUsernameEntry.Name = "txtUsernameEntry";
            this.txtUsernameEntry.PlaceholderText = "e.g. astroBoy";
            this.txtUsernameEntry.Size = new System.Drawing.Size(665, 71);
            this.txtUsernameEntry.TabIndex = 0;
            this.txtUsernameEntry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsernameEntry_KeyPress);
            // 
            // txtPasswordEntry
            // 
            this.txtPasswordEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPasswordEntry.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPasswordEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.txtPasswordEntry.Location = new System.Drawing.Point(172, 359);
            this.txtPasswordEntry.Name = "txtPasswordEntry";
            this.txtPasswordEntry.PasswordChar = '*';
            this.txtPasswordEntry.PlaceholderText = "e.g. ilovemangoos123!";
            this.txtPasswordEntry.Size = new System.Drawing.Size(665, 71);
            this.txtPasswordEntry.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(177)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.btnLogin.Location = new System.Drawing.Point(357, 502);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(294, 100);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.lblUsername.Location = new System.Drawing.Point(172, 132);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(342, 65);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Your username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(19)))), ((int)(((byte)(47)))));
            this.lblPassword.Location = new System.Drawing.Point(172, 291);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(336, 65);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Your password";
            // 
            // seepw
            // 
            this.seepw.Location = new System.Drawing.Point(868, 373);
            this.seepw.Name = "seepw";
            this.seepw.Size = new System.Drawing.Size(73, 48);
            this.seepw.TabIndex = 5;
            this.seepw.Text = "see password";
            this.seepw.UseVisualStyleBackColor = true;
            this.seepw.Click += new System.EventHandler(this.seepw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(164)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.seepw);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPasswordEntry);
            this.Controls.Add(this.txtUsernameEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtUsernameEntry;
        private TextBox txtPasswordEntry;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private Button seepw;
    }
}