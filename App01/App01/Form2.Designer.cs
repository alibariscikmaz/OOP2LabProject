namespace App01
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            this.settingsbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.bttnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsbutton
            // 
            this.settingsbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsbutton.Location = new System.Drawing.Point(303, 329);
            this.settingsbutton.Name = "settingsbutton";
            this.settingsbutton.Size = new System.Drawing.Size(195, 45);
            this.settingsbutton.TabIndex = 0;
            this.settingsbutton.Text = "Settings";
            this.settingsbutton.UseVisualStyleBackColor = false;
            this.settingsbutton.Click += new System.EventHandler(this.settingsbutton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 53);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin Panel";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAboutUs.Location = new System.Drawing.Point(303, 388);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(195, 45);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(303, 270);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(195, 45);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(713, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 53);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Visible = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // bttnHelp
            // 
            this.bttnHelp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnHelp.Location = new System.Drawing.Point(713, 71);
            this.bttnHelp.Name = "bttnHelp";
            this.bttnHelp.Size = new System.Drawing.Size(75, 62);
            this.bttnHelp.TabIndex = 5;
            this.bttnHelp.Text = "Help";
            this.bttnHelp.UseVisualStyleBackColor = false;
            this.bttnHelp.Click += new System.EventHandler(this.bttnHelp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App01.Properties.Resources.oop2bg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttnHelp);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnAboutUs);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.settingsbutton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button settingsbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAdmin;
        private Button btnAboutUs;
        private Button btnPlay;
        private Button btnProfile;
        private Button bttnHelp;
    }
}