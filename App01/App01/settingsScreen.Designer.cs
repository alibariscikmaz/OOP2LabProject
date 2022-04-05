﻿namespace App01
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
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnCustom = new System.Windows.Forms.RadioButton();
            this.nmrcudXAxis = new System.Windows.Forms.NumericUpDown();
            this.nmrcudYAxis = new System.Windows.Forms.NumericUpDown();
            this.grpbxSize = new System.Windows.Forms.GroupBox();
            this.chklbxSize = new System.Windows.Forms.CheckedListBox();
            this.grpbxColor = new System.Windows.Forms.GroupBox();
            this.chklbxColor = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxDifficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudXAxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudYAxis)).BeginInit();
            this.grpbxSize.SuspendLayout();
            this.grpbxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxDifficulty
            // 
            this.grpbxDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
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
            // nmrcudXAxis
            // 
            this.nmrcudXAxis.Location = new System.Drawing.Point(102, 106);
            this.nmrcudXAxis.Name = "nmrcudXAxis";
            this.nmrcudXAxis.Size = new System.Drawing.Size(73, 23);
            this.nmrcudXAxis.TabIndex = 4;
            // 
            // nmrcudYAxis
            // 
            this.nmrcudYAxis.Location = new System.Drawing.Point(181, 106);
            this.nmrcudYAxis.Name = "nmrcudYAxis";
            this.nmrcudYAxis.Size = new System.Drawing.Size(73, 23);
            this.nmrcudYAxis.TabIndex = 5;
            // 
            // grpbxSize
            // 
            this.grpbxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
            this.grpbxSize.Controls.Add(this.chklbxSize);
            this.grpbxSize.Location = new System.Drawing.Point(28, 178);
            this.grpbxSize.Name = "grpbxSize";
            this.grpbxSize.Size = new System.Drawing.Size(391, 113);
            this.grpbxSize.TabIndex = 1;
            this.grpbxSize.TabStop = false;
            this.grpbxSize.Text = "Size";
            // 
            // chklbxSize
            // 
            this.chklbxSize.CheckOnClick = true;
            this.chklbxSize.FormattingEnabled = true;
            this.chklbxSize.Items.AddRange(new object[] {
            "Square",
            "Triangle",
            "Circle"});
            this.chklbxSize.Location = new System.Drawing.Point(17, 34);
            this.chklbxSize.Name = "chklbxSize";
            this.chklbxSize.Size = new System.Drawing.Size(355, 58);
            this.chklbxSize.TabIndex = 0;
            // 
            // grpbxColor
            // 
            this.grpbxColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
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
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(200)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(217)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(95)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(451, 499);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpbxColor);
            this.Controls.Add(this.grpbxSize);
            this.Controls.Add(this.grpbxDifficulty);
            this.Name = "settingsScreen";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settingsScreen_Load);
            this.grpbxDifficulty.ResumeLayout(false);
            this.grpbxDifficulty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudXAxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcudYAxis)).EndInit();
            this.grpbxSize.ResumeLayout(false);
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
        private GroupBox grpbxSize;
        private CheckedListBox chklbxSize;
        private GroupBox grpbxColor;
        private CheckedListBox chklbxColor;
        private Button btnSave;
    }
}