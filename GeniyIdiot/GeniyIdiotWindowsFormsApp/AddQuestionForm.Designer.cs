namespace GeniyIdiotWindowsFormsApp
{
    partial class AddQuestionForm
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
            this.textBoxAddQuestionText = new System.Windows.Forms.TextBox();
            this.textBoxAddQuestionAnswer = new System.Windows.Forms.TextBox();
            this.labelAddQuestionText = new System.Windows.Forms.Label();
            this.labelAddQuestionAnswer = new System.Windows.Forms.Label();
            this.buttonAddQuestionSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAddQuestionText
            // 
            this.textBoxAddQuestionText.Location = new System.Drawing.Point(116, 51);
            this.textBoxAddQuestionText.Name = "textBoxAddQuestionText";
            this.textBoxAddQuestionText.Size = new System.Drawing.Size(558, 20);
            this.textBoxAddQuestionText.TabIndex = 0;
            // 
            // textBoxAddQuestionAnswer
            // 
            this.textBoxAddQuestionAnswer.Location = new System.Drawing.Point(116, 121);
            this.textBoxAddQuestionAnswer.Name = "textBoxAddQuestionAnswer";
            this.textBoxAddQuestionAnswer.Size = new System.Drawing.Size(558, 20);
            this.textBoxAddQuestionAnswer.TabIndex = 1;
            // 
            // labelAddQuestionText
            // 
            this.labelAddQuestionText.AutoSize = true;
            this.labelAddQuestionText.Location = new System.Drawing.Point(116, 32);
            this.labelAddQuestionText.Name = "labelAddQuestionText";
            this.labelAddQuestionText.Size = new System.Drawing.Size(125, 13);
            this.labelAddQuestionText.TabIndex = 2;
            this.labelAddQuestionText.Text = "Введите текст вопроса";
            // 
            // labelAddQuestionAnswer
            // 
            this.labelAddQuestionAnswer.AutoSize = true;
            this.labelAddQuestionAnswer.Location = new System.Drawing.Point(116, 96);
            this.labelAddQuestionAnswer.Name = "labelAddQuestionAnswer";
            this.labelAddQuestionAnswer.Size = new System.Drawing.Size(261, 13);
            this.labelAddQuestionAnswer.TabIndex = 3;
            this.labelAddQuestionAnswer.Text = "Введите ответ на вопрос - это должно быть число";
            // 
            // buttonAddQuestionSave
            // 
            this.buttonAddQuestionSave.Location = new System.Drawing.Point(297, 166);
            this.buttonAddQuestionSave.Name = "buttonAddQuestionSave";
            this.buttonAddQuestionSave.Size = new System.Drawing.Size(146, 23);
            this.buttonAddQuestionSave.TabIndex = 4;
            this.buttonAddQuestionSave.Text = "Добавить вопрос";
            this.buttonAddQuestionSave.UseVisualStyleBackColor = true;
            this.buttonAddQuestionSave.Click += new System.EventHandler(this.buttonAddQuestionSave_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddQuestionSave);
            this.Controls.Add(this.labelAddQuestionAnswer);
            this.Controls.Add(this.labelAddQuestionText);
            this.Controls.Add(this.textBoxAddQuestionAnswer);
            this.Controls.Add(this.textBoxAddQuestionText);
            this.Name = "AddQuestionForm";
            this.Text = "AddQuestionForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuestionForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddQuestionText;
        private System.Windows.Forms.TextBox textBoxAddQuestionAnswer;
        private System.Windows.Forms.Label labelAddQuestionText;
        private System.Windows.Forms.Label labelAddQuestionAnswer;
        private System.Windows.Forms.Button buttonAddQuestionSave;
    }
}