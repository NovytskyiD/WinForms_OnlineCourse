using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiotClassLibrary;


namespace GeniyIdiotWindowsFormsApp
{
    public partial class AddQuestionForm : Form
    {
        List<Question> questionsAdd;
        private bool added = false;
        public AddQuestionForm(List<Question> questions)
        {
            InitializeComponent();
            questionsAdd = questions;

        }

        private void buttonAddQuestionSave_Click(object sender, EventArgs e)
        {
            var questionText = textBoxAddQuestionText.Text;
            var questionAnswer = textBoxAddQuestionAnswer.Text;

            if (!TextTools.isNumeric(questionAnswer))
            {

                MessageBox.Show("Вы ввели не число или оно слишком большое!");

            }
            else if (questionText=="")
            {
                MessageBox.Show("Введите текст вопроса!");
            }
            else
            {
                added = true;
                questionsAdd.Add(new Question(questionText, Convert.ToInt32(questionAnswer)));
                QuestionsStorage.AddQuestion(questionText, Convert.ToInt32(questionAnswer));
                MessageBox.Show("Вопрос успешно добавлен","Успех!",MessageBoxButtons.OK);
                textBoxAddQuestionText.Clear();
                textBoxAddQuestionAnswer.Clear();
            }

        }

        private void AddQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (added)
            {
                MessageBox.Show("Вы изменили список вопросов - необходимо перезагрузить приложение!", "Список вопросов изменен", MessageBoxButtons.OK);
                Application.Restart();
            }
        }
    }
}
