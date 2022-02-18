
namespace _2048WindowsFormsApp
{
    partial class Rules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rules));
            this.rulesLabel = new System.Windows.Forms.Label();
            this.rulseOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Location = new System.Drawing.Point(12, 43);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(664, 208);
            this.rulesLabel.TabIndex = 0;
            this.rulesLabel.Text = resources.GetString("rulesLabel.Text");
            // 
            // rulseOkButton
            // 
            this.rulseOkButton.Location = new System.Drawing.Point(288, 274);
            this.rulseOkButton.Name = "rulseOkButton";
            this.rulseOkButton.Size = new System.Drawing.Size(75, 23);
            this.rulseOkButton.TabIndex = 1;
            this.rulseOkButton.Text = "Закрыть";
            this.rulseOkButton.UseVisualStyleBackColor = true;
            this.rulseOkButton.Click += new System.EventHandler(this.rulseOkButton_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 322);
            this.Controls.Add(this.rulseOkButton);
            this.Controls.Add(this.rulesLabel);
            this.Name = "Rules";
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Button rulseOkButton;
    }
}