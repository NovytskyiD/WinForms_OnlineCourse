using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class mainForm : Form
    {
        public List<Question> questions;
        private int countQuestions;
        private int currentQuestionNumber;
        private int currentQuestion;
        private int countCorrectAnswers;
        private Random random =new Random();
        private User user = new User();
        public mainForm()
        {
            InitializeComponent();

        }

        private void userAnswerTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void questionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            questions = QuestionsStorage.LoadQuestions();
            string inputName = Interaction.InputBox("Пожалуйста, введи ваше имя", "", "Неизвестно", -1, -1);
            user.Name = inputName;
            currentQuestion = 1;
            countQuestions = questions.Count;
            currentQuestionNumber = random.Next(0, countQuestions);
            questionTextLabel.Text = $"Вопрос №{currentQuestion}.{questions[currentQuestionNumber].Text}";
            
        }


        private void nextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = userAnswerTextbox.Text;
            if (TextTools.isNumeric(userAnswer))
            {
                if (questions[currentQuestionNumber].Answer == Convert.ToInt32(userAnswer))
                {
                    countCorrectAnswers++;
                }
                    questions.RemoveAt(currentQuestionNumber);
                    currentQuestion++;
                    currentQuestionNumber = random.Next(0, questions.Count());
                    if (questions.Count()>0)
                    {
                        ShowNextQuestion();
                    }
                    else
                {
                    user.SetDiagnose(countCorrectAnswers, countQuestions);
                    UsersResultStorage.Append(user);
                    var dialogResult=MessageBox.Show($"{user.Name}, ваш диагноз - {user.Diagnose}! Хотите пройти еще раз?","Опрос закончен!",MessageBoxButtons.YesNo);
                    if (dialogResult==DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                }
                    
                
            }
            else
            {
                MessageBox.Show("Вы ввели не число или оно слишком большое!");
            }

        }

        private void ShowNextQuestion()
        {
            questionTextLabel.Text = $"Вопрос №{currentQuestion}.{questions[currentQuestionNumber].Text}";
            userAnswerTextbox.Text = "";
        }

        private void beginNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void quitStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Results results = new Results();
            results.ShowDialog();
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddQuestionForm addQuestion = new AddQuestionForm(questions);
            addQuestion.ShowDialog();
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteQuestionForm deleteQuestion = new DeleteQuestionForm();
            deleteQuestion.ShowDialog();
        }
    }
}
