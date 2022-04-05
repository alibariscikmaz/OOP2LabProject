namespace App01
{
    partial class settingsScreen
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
            this.grpbxDifficulty = new System.Windows.Forms.GroupBox();
            this.nmrcudYAxis = new System.Windows.Forms.NumericUpDown();
            this.nmrcudXAxis = new System.Windows.Forms.NumericUpDown();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.grpbxShape = new System.Windows.Forms.GroupBox();
            this.chklbxShape = new System.Windows.Forms.CheckedListBox();
            this.grpbxColor = new System.Windows.Forms.GroupBox();
            this.chklbxColor = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudYAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudXAxis)).BeginInit();
            this.grpbxShape.SuspendLayout();
            this.grpbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxDifficulty
            // 
            this.grpbxDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.grpbxDifficulty.Controls.Add(this.nmrcudYAxis);
            this.grpbxDifficulty.Controls.Add(this.nmrcudXAxis);
            this.grpbxDifficulty.Controls.Add(this.rbtnCustom);
            this.grpbxDifficulty.Controls.Add(this.rbtnHard);
            this.grpbxDifficulty.Controls.Add(this.rbtnNormal);
            this.grpbxDifficulty.Controls.Add(this.rbtnEasy);
            this.grpbxDifficulty.Location = new System.Drawing.Point(28, 12);
            this.grpbxDifficulty.Name = "grpbxDifficulty";
            this.grpbxDifficulty.Size = new System.Drawing.Size(391, 149);
            this.grpbxDifficulty.TabIndex = 0;
            this.grpbxDifficulty.TabStop = false;
            this.grpbxDifficulty.Text = "Difficulty";
            // 
            // nmrcudYAxis
            // 
            this.nmrcudYAxis.Location = new System.Drawing.Point(181, 106);
            this.nmrcudYAxis.Name = "nmrcudYAxis";
            this.nmrcudYAxis.Size = new System.Drawing.Size(73, 23);
            this.nmrcudYAxis.TabIndex = 5;
            // 
            // nmrcudXAxis
            // 
            this.nmrcudXAxis.Location = new System.Drawing.Point(102, 106);
            this.nmrcudXAxis.Name = "nmrcudXAxis";
            this.nmrcudXAxis.Size = new System.Drawing.Size(73, 23);
            this.nmrcudXAxis.TabIndex = 4;
            // 
            // rbtnCustom
            // 
            this.rbtnCustom.AutoSize = true;
            this.rbtnCustom.Location = new System.Drawing.Point(19, 106);
            this.rbtnCustom.Name = "rbtnCustom";
            this.rbtnCustom.Size = new System.Drawing.Size(67, 19);
            this.rbtnCustom.TabIndex = 3;
            this.rbtnCustom.TabStop = true;
            this.rbtnCustom.Text = "Custom";
            this.rbtnCustom.UseVisualStyleBackColor = true;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(19, 81);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(51, 19);
            this.rbtnHard.TabIndex = 2;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Location = new System.Drawing.Point(19, 56);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(65, 19);
            this.rbtnNormal.TabIndex = 1;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Location = new System.Drawing.Point(19, 31);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(48, 19);
            this.rbtnEasy.TabIndex = 0;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // grpbxShape
            // 
            this.grpbxShape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.grpbxShape.Controls.Add(this.chklbxShape);
            this.grpbxShape.Location = new System.Drawing.Point(28, 178);
            this.grpbxShape.Name = "grpbxShape";
            this.grpbxShape.Size = new System.Drawing.Size(391, 113);
            this.grpbxShape.TabIndex = 1;
            this.grpbxShape.TabStop = false;
            this.grpbxShape.Text = "Shape";
            // 
            // chklbxShape
            // 
            this.chklbxShape.CheckOnClick = true;
            this.chklbxShape.FormattingEnabled = true;
            this.chklbxShape.Items.AddRange(new object[] {
            "Square",
            "Triangle",
            "Circle"});
            this.chklbxShape.Location = new System.Drawing.Point(17, 34);
            this.chklbxShape.Name = "chklbxShape";
            this.chklbxShape.Size = new System.Drawing.Size(355, 58);
            this.chklbxShape.TabIndex = 0;
            // 
            // grpbxColor
            // 
            this.grpbxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.grpbxColor.Controls.Add(this.chklbxColor);
            this.grpbxColor.Location = new System.Drawing.Point(28, 308);
            this.grpbxColor.Name = "grpbxColor";
            this.grpbxColor.Size = new System.Drawing.Size(391, 106);
            this.grpbxColor.TabIndex = 2;
            this.grpbxColor.TabStop = false;
            this.grpbxColor.Text = "Color";
            // 
            // chklbxColor
            // 
            this.chklbxColor.CheckOnClick = true;
            this.chklbxColor.FormattingEnabled = true;
            this.chklbxColor.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.chklbxColor.Location = new System.Drawing.Point(17, 28);
            this.chklbxColor.Name = "chklbxColor";
            this.chklbxColor.Size = new System.Drawing.Size(355, 58);
            this.chklbxColor.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(142, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(167, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // settingsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(451, 499);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpbxColor);
            this.Controls.Add(this.grpbxShape);
            this.Controls.Add(this.grpbxDifficulty);
            this.Name = "settingsScreen";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsScreen_Load);
            this.grpbxDifficulty.ResumeLayout(false);
            this.grpbxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudYAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudXAxis)).EndInit();
            this.grpbxShape.ResumeLayout(false);
            this.grpbxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpbxDifficulty;
        private NumericUpDown nmrcudYAxis;
        private NumericUpDown nmrcudXAxis;
        private RadioButton rbtnCustom;
        private RadioButton rbtnHard;
        private RadioButton rbtnNormal;
        private RadioButton rbtnEasy;
        private GroupBox grpbxShape;
        private CheckedListBox chklbxShape;
        private GroupBox grpbxColor;
        private CheckedListBox chklbxColor;
        private Button btnSave;
    }
}