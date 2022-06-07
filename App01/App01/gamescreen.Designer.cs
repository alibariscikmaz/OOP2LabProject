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
            this.lblScore = new System.Windows.Forms.Label();
            this.lbHighest = new System.Windows.Forms.Label();
            this.btnLeaderBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(12, 59);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(121, 50);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lbHighest
            // 
            this.lbHighest.AutoSize = true;
            this.lbHighest.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHighest.Location = new System.Drawing.Point(12, 9);
            this.lbHighest.Name = "lbHighest";
            this.lbHighest.Size = new System.Drawing.Size(156, 50);
            this.lbHighest.TabIndex = 1;
            this.lbHighest.Text = "Highest:";
            // 
            // btnLeaderBoard
            // 
            this.btnLeaderBoard.Location = new System.Drawing.Point(928, 12);
            this.btnLeaderBoard.Name = "btnLeaderBoard";
            this.btnLeaderBoard.Size = new System.Drawing.Size(67, 57);
            this.btnLeaderBoard.TabIndex = 2;
            this.btnLeaderBoard.Text = "Leader Board";
            this.btnLeaderBoard.UseVisualStyleBackColor = true;
            this.btnLeaderBoard.Click += new System.EventHandler(this.btnLeaderBoard_Click);
            // 
            // gamescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 687);
            this.Controls.Add(this.btnLeaderBoard);
            this.Controls.Add(this.lbHighest);
            this.Controls.Add(this.lblScore);
            this.Name = "gamescreen";
            this.Text = "gamescreen";
            this.Load += new System.EventHandler(this.gamescreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblScore;
        private Label lbHighest;
        private Button btnLeaderBoard;
    }
}