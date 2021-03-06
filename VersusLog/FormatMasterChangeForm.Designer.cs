﻿namespace VersusLog
{
    partial class FormatMasterChangeForm
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
            this.BackMainMenuButton = new System.Windows.Forms.Button();
            this.FormatMasterGridView = new System.Windows.Forms.DataGridView();
            this.UpdateViewButton = new System.Windows.Forms.Button();
            this.ChangeGenreLabel = new System.Windows.Forms.Label();
            this.ChangeGenreComboBox = new System.Windows.Forms.ComboBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormatNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.FormatMasterGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackMainMenuButton
            // 
            this.BackMainMenuButton.Location = new System.Drawing.Point(353, 471);
            this.BackMainMenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackMainMenuButton.Name = "BackMainMenuButton";
            this.BackMainMenuButton.Size = new System.Drawing.Size(142, 34);
            this.BackMainMenuButton.TabIndex = 3;
            this.BackMainMenuButton.Text = "メインメニューに戻る";
            this.BackMainMenuButton.UseVisualStyleBackColor = true;
            this.BackMainMenuButton.Click += new System.EventHandler(this.BackMainMenuButton_Click);
            // 
            // FormatMasterGridView
            // 
            this.FormatMasterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FormatMasterGridView.Location = new System.Drawing.Point(14, 5);
            this.FormatMasterGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FormatMasterGridView.Name = "FormatMasterGridView";
            this.FormatMasterGridView.RowTemplate.Height = 21;
            this.FormatMasterGridView.Size = new System.Drawing.Size(482, 291);
            this.FormatMasterGridView.TabIndex = 4;
            // 
            // UpdateViewButton
            // 
            this.UpdateViewButton.Location = new System.Drawing.Point(353, 304);
            this.UpdateViewButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateViewButton.Name = "UpdateViewButton";
            this.UpdateViewButton.Size = new System.Drawing.Size(142, 35);
            this.UpdateViewButton.TabIndex = 38;
            this.UpdateViewButton.Text = "表示更新";
            this.UpdateViewButton.UseVisualStyleBackColor = true;
            this.UpdateViewButton.Click += new System.EventHandler(this.UpdateViewButton_Click);
            // 
            // ChangeGenreLabel
            // 
            this.ChangeGenreLabel.AutoSize = true;
            this.ChangeGenreLabel.Location = new System.Drawing.Point(15, 311);
            this.ChangeGenreLabel.Name = "ChangeGenreLabel";
            this.ChangeGenreLabel.Size = new System.Drawing.Size(55, 15);
            this.ChangeGenreLabel.TabIndex = 37;
            this.ChangeGenreLabel.Text = "変更種別";
            // 
            // ChangeGenreComboBox
            // 
            this.ChangeGenreComboBox.FormattingEnabled = true;
            this.ChangeGenreComboBox.Location = new System.Drawing.Point(14, 330);
            this.ChangeGenreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChangeGenreComboBox.Name = "ChangeGenreComboBox";
            this.ChangeGenreComboBox.Size = new System.Drawing.Size(140, 23);
            this.ChangeGenreComboBox.TabIndex = 36;
            this.ChangeGenreComboBox.TextChanged += new System.EventHandler(this.ChangeGenreComboBox_TextChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(203, 471);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(100, 34);
            this.DoneButton.TabIndex = 34;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(6, 38);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(146, 23);
            this.IDTextBox.TabIndex = 32;
            this.IDTextBox.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "フォーマット名";
            // 
            // FormatNameTextBox
            // 
            this.FormatNameTextBox.Location = new System.Drawing.Point(6, 94);
            this.FormatNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FormatNameTextBox.Name = "FormatNameTextBox";
            this.FormatNameTextBox.Size = new System.Drawing.Size(146, 23);
            this.FormatNameTextBox.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FormatNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 368);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(182, 138);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入力";
            // 
            // FormatMasterChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 516);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateViewButton);
            this.Controls.Add(this.ChangeGenreLabel);
            this.Controls.Add(this.ChangeGenreComboBox);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.FormatMasterGridView);
            this.Controls.Add(this.BackMainMenuButton);
            this.Font = new System.Drawing.Font("Meiryo UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormatMasterChangeForm";
            this.Text = "VersusLog -フォーマットマスタ変更-";
            ((System.ComponentModel.ISupportInitialize)(this.FormatMasterGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMainMenuButton;
        private System.Windows.Forms.DataGridView FormatMasterGridView;
        private System.Windows.Forms.Button UpdateViewButton;
        private System.Windows.Forms.Label ChangeGenreLabel;
        private System.Windows.Forms.ComboBox ChangeGenreComboBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FormatNameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}