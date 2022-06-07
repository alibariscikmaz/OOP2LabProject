namespace App01
{
    partial class LeaderBoard
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
            this.dgwLeaderBoard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLeaderBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwLeaderBoard
            // 
            this.dgwLeaderBoard.AllowDrop = true;
            this.dgwLeaderBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwLeaderBoard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwLeaderBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLeaderBoard.Location = new System.Drawing.Point(27, 27);
            this.dgwLeaderBoard.Name = "dgwLeaderBoard";
            this.dgwLeaderBoard.ReadOnly = true;
            this.dgwLeaderBoard.RowTemplate.Height = 25;
            this.dgwLeaderBoard.Size = new System.Drawing.Size(422, 467);
            this.dgwLeaderBoard.TabIndex = 0;
            // 
            // LeaderBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 526);
            this.Controls.Add(this.dgwLeaderBoard);
            this.Name = "LeaderBoard";
            this.Text = "LeaderBoard";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLeaderBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgwLeaderBoard;
    }
}