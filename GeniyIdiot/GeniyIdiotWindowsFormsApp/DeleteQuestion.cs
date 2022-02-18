using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        private List<Question> questions;
        private bool deleted = false;
        public DeleteQuestionForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleted = true;
            questions.RemoveAt(dataGridViewDelete.CurrentCell.RowIndex);
            dataGridViewDelete.Rows.Remove(dataGridViewDelete.CurrentCell.OwningRow);
            QuestionsStorage.SaveQuestionsToFile(questions);
        }

        private void DeleteQuestionForm_Load(object sender, EventArgs e)
        {
            DisplayQuestions();
        }

        private void DisplayQuestions()
        {
            questions = QuestionsStorage.LoadQuestions();
            foreach (var question in questions)
            {
                dataGridViewDelete.Rows.Add(question.Text, question.Answer);
            }
        }

        private void DeleteQuestionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void DeleteQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (deleted)
            {
                MessageBox.Show("Вы изменили список вопросов - необходимо перезагрузить приложение!", "Список вопросов изменен", MessageBoxButtons.OK);
                Application.Restart();
            }
        }
    }
}
