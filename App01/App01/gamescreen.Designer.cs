namespace App01
{
    partial class gamescreen
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
            this.startbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbttn
            // 
            this.startbttn.Location = new System.Drawing.Point(592, 35);
            this.startbttn.Name = "startbttn";
            this.startbttn.Size = new System.Drawing.Size(126, 71);
            this.startbttn.TabIndex = 0;
            this.startbttn.Text = "Start";
            this.startbttn.UseVisualStyleBackColor = true;
            this.startbttn.Click += new System.EventHandler(this.startbttn_Click);
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startbttn);
            this.Name = "gamescreen";
            this.Text = "gamescreen";
            this.Load += new System.EventHandler(this.gamescreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button startbttn;
    }
}