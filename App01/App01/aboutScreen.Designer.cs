namespace App01
{
    partial class aboutScreen
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
            this.lbAboutHeader = new System.Windows.Forms.Label();
            this.lbGameName = new System.Windows.Forms.Label();
            this.lbCredits = new System.Windows.Forms.Label();
            this.lbAboutAli = new System.Windows.Forms.Label();
            this.lbAboutHuseyin = new System.Windows.Forms.Label();
            this.lbDevDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAboutHeader
            // 
            this.lbAboutHeader.AutoSize = true;
            this.lbAboutHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAboutHeader.Location = new System.Drawing.Point(316, 31);
            this.lbAboutHeader.Name = "lbAboutHeader";
            this.lbAboutHeader.Size = new System.Drawing.Size(169, 46);
            this.lbAboutHeader.TabIndex = 0;
            this.lbAboutHeader.Text = "About Us";
            this.lbAboutHeader.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGameName.Location = new System.Drawing.Point(40, 109);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(264, 28);
            this.lbGameName.TabIndex = 1;
            this.lbGameName.Text = "Game Name: Geometry Dash";
            // 
            // lbCredits
            // 
            this.lbCredits.AutoSize = true;
            this.lbCredits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCredits.Location = new System.Drawing.Point(40, 148);
            this.lbCredits.Name = "lbCredits";
            this.lbCredits.Size = new System.Drawing.Size(389, 28);
            this.lbCredits.TabIndex = 2;
            this.lbCredits.Text = "Developers: Ali Barış Çıkmaz, Hüseyin Koçer";
            // 
            // lbAboutAli
            // 
            this.lbAboutAli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAboutAli.Location = new System.Drawing.Point(40, 187);
            this.lbAboutAli.Name = "lbAboutAli";
            this.lbAboutAli.Size = new System.Drawing.Size(682, 65);
            this.lbAboutAli.TabIndex = 3;
            this.lbAboutAli.Text = "Ali Barış Çıkmaz - 3rd Year Computer Engineering student with a passion for softw" +
    "are developement and cybersecurity.";
            this.lbAboutAli.Click += new System.EventHandler(this.lbAboutDevs_Click);
            // 
            // lbAboutHuseyin
            // 
            this.lbAboutHuseyin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAboutHuseyin.Location = new System.Drawing.Point(40, 263);
            this.lbAboutHuseyin.Name = "lbAboutHuseyin";
            this.lbAboutHuseyin.Size = new System.Drawing.Size(682, 65);
            this.lbAboutHuseyin.TabIndex = 4;
            this.lbAboutHuseyin.Text = "Hüseyin Koçer - 3rd Year Computer Engineering student who\'s interested in MetaVer" +
    "se and WEB3.";
            // 
            // lbDevDate
            // 
            this.lbDevDate.AutoSize = true;
            this.lbDevDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDevDate.Location = new System.Drawing.Point(200, 366);
            this.lbDevDate.Name = "lbDevDate";
            this.lbDevDate.Size = new System.Drawing.Size(400, 28);
            this.lbDevDate.TabIndex = 5;
            this.lbDevDate.Text = "Under developement (03/2022-04/2022)";
            this.lbDevDate.Click += new System.EventHandler(this.lbDevDate_Click);
            // 
            // aboutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDevDate);
            this.Controls.Add(this.lbAboutHuseyin);
            this.Controls.Add(this.lbAboutAli);
            this.Controls.Add(this.lbCredits);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.lbAboutHeader);
            this.Name = "aboutScreen";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAboutHeader;
        private Label lbGameName;
        private Label lbCredits;
        private Label lbAboutAli;
        private Label lbAboutHuseyin;
        private Label lbDevDate;
    }
}