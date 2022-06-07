namespace App01
{
    partial class help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help));
            this.lbAboutHeader = new System.Windows.Forms.Label();
            this.lbGameName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAboutHeader
            // 
            this.lbAboutHeader.AutoSize = true;
            this.lbAboutHeader.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAboutHeader.Location = new System.Drawing.Point(302, 45);
            this.lbAboutHeader.Name = "lbAboutHeader";
            this.lbAboutHeader.Size = new System.Drawing.Size(174, 37);
            this.lbAboutHeader.TabIndex = 1;
            this.lbAboutHeader.Text = "How to Play";
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGameName.Location = new System.Drawing.Point(124, 114);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(528, 252);
            this.lbGameName.TabIndex = 2;
            this.lbGameName.Text = resources.GetString("lbGameName.Text");
            // 
            // help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.lbAboutHeader);
            this.Name = "help";
            this.Text = "help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbAboutHeader;
        private Label lbGameName;
    }
}