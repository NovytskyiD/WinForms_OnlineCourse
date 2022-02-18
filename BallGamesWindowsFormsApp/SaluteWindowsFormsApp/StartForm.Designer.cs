namespace SaluteWindowsFormsApp
{
    partial class StartForm
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
            this.saluteClickButton = new System.Windows.Forms.Button();
            this.saluteAutoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saluteClickButton
            // 
            this.saluteClickButton.Location = new System.Drawing.Point(147, 132);
            this.saluteClickButton.Name = "saluteClickButton";
            this.saluteClickButton.Size = new System.Drawing.Size(91, 23);
            this.saluteClickButton.TabIndex = 0;
            this.saluteClickButton.Text = "Салют_Клик";
            this.saluteClickButton.UseVisualStyleBackColor = true;
            this.saluteClickButton.Click += new System.EventHandler(this.saluteClickButton_Click);
            // 
            // saluteAutoButton
            // 
            this.saluteAutoButton.Location = new System.Drawing.Point(350, 132);
            this.saluteAutoButton.Name = "saluteAutoButton";
            this.saluteAutoButton.Size = new System.Drawing.Size(98, 23);
            this.saluteAutoButton.TabIndex = 1;
            this.saluteAutoButton.Text = "Салют_Авто";
            this.saluteAutoButton.UseVisualStyleBackColor = true;
            this.saluteAutoButton.Click += new System.EventHandler(this.saluteAutoButton_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saluteAutoButton);
            this.Controls.Add(this.saluteClickButton);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saluteClickButton;
        private System.Windows.Forms.Button saluteAutoButton;
    }
}