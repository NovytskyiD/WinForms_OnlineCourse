using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
namespace GeniyIdiotConsoleApp
{


    class Program
    {
        static void Main(string[] args)

        {
            bool stop = false;
            var questions = new List<Question>();
            User user = new User();
            Console.WriteLine("Введите свое имя:");
            user.Name = Console.ReadLine();

            while (!stop)
            {

                questions = QuestionsStorage.LoadQuestions();
                int countQuestions = questions.Count;
                int countRightAnswers = 0;
                UsersResultStorage resultStorage = new UsersResultStorage();

                Random random = new Random();
                int questionNum = 1;

                for (int i = countQuestions - 1; i >= 0; i--)
                {
                    int currentQuestion = random.Next(0, questions.Count);
                    Question question = questions[currentQuestion];
                    int userAnswer = 0;
                    Console.WriteLine($"{questionNum}. {question.Text}");
                    userAnswer = TextTools.GetNumber();

                    int rightAnswer = question.Answer;

                    if (userAnswer == rightAnswer)
                        countRightAnswers++;
                    questionNum++;


                    questions.RemoveAt(currentQuestion);
                }

                Console.WriteLine($"Количество правильных ответов: {countRightAnswers}");

                user.SetDiagnose(countRightAnswers, countQuestions);

                Console.WriteLine($"{user.Name} - ваш диагноз: {user.Diagnose}");

                //Сохраняем результаты
                UsersResultStorage.Append(user);

                //Отображаем результаты
                if (TextTools.GetYesOrNo("Хотите посмотреть предыдущие результаты"))
                {
                    DisplayUserResults();
                }

                //Добавляем вопросы
                if (TextTools.GetYesOrNo("Хотите добавить вопрос"))
                {
                    Console.WriteLine("Введите текст вопроса:");
                    string text = Console.ReadLine();
                    Console.WriteLine("Введите ответ - это должно быть число:");
                    int answer = TextTools.GetNumber();
                    questions.Add(new Question(text, answer));
                    QuestionsStorage.AddQuestion(text, answer);
                }

                //Удаляем вопросы
                if (TextTools.GetYesOrNo("Хотите удалить вопрос"))
                {

                    DeleteQuestion();
                }
                //Продолжаем или выходим?
                if (!TextTools.GetYesOrNo($"{user.Name}, хотите повторить тест"))
                    stop = true;

            }

            void DisplayUserResults()
            {
                Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Имя", "Правильно", "Диагноз");
                var userResults = UsersResultStorage.GetResults();

                foreach (var userResult in userResults)
                {
                    Console.WriteLine("{0,-15}{1,-15}{2,-15}", userResult.Name, userResult.Result, userResult.Diagnose);
                }

            }

            void DisplayAllQuestions(List<Question> questionsList)
            {
                for (int i = 0; i < questionsList.Count; i++)
                    Console.WriteLine($"{i + 1}. {questionsList[i].Text}");
            }

            void DeleteQuestion()
            {
                questions = QuestionsStorage.LoadQuestions();
                DisplayAllQuestions(questions);
                Console.WriteLine("Введите номер вопроса, который нужно удалить:");
                int questionId;
                while (true)
                {
                    while (!int.TryParse(Console.ReadLine(), out questionId))
                    {
                        Console.WriteLine("Введите номер вопроса, который нужно удалить:");
                    }

                    if (questionId - 1 >= 0 && questionId - 1 < questions.Count)
                    {
                        questions.RemoveAt(questionId - 1);
                        QuestionsStorage.SaveQuestionsToFile(questions);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введен неверный номер вопроса!");
                    }
                }
            }

        }
    }
}

