﻿namespace _2048WindowsFormsApp
{
    partial class startForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.saveUserNameButton = new System.Windows.Forms.Button();
            this.mapSizeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(50, 13);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(104, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Введите ваше имя:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(53, 41);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(250, 20);
            this.userNameTextBox.TabIndex = 1;
            // 
            // saveUserNameButton
            // 
            this.saveUserNameButton.Location = new System.Drawing.Point(109, 171);
            this.saveUserNameButton.Name = "saveUserNameButton";
            this.saveUserNameButton.Size = new System.Drawing.Size(82, 23);
            this.saveUserNameButton.TabIndex = 2;
            this.saveUserNameButton.Text = "Продолжить";
            this.saveUserNameButton.UseVisualStyleBackColor = true;
            this.saveUserNameButton.Click += new System.EventHandler(this.saveUserNameButton_Click);
            // 
            // mapSizeListBox
            // 
            this.mapSizeListBox.FormattingEnabled = true;
            this.mapSizeListBox.Items.AddRange(new object[] {
            "4х4",
            "5х5",
            "6х6"});
            this.mapSizeListBox.Location = new System.Drawing.Point(53, 97);
            this.mapSizeListBox.Name = "mapSizeListBox";
            this.mapSizeListBox.Size = new System.Drawing.Size(120, 43);
            this.mapSizeListBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер поля";
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 206);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mapSizeListBox);
            this.Controls.Add(this.saveUserNameButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Name = "startForm";
            this.Text = "Добро пожаловать";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        public System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button saveUserNameButton;
        public System.Windows.Forms.ListBox mapSizeListBox;
        private System.Windows.Forms.Label label1;
    }
}