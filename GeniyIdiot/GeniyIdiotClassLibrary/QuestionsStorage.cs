using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary
{
    public class QuestionsStorage
    {
        private static string pathQuestions = "./Questions.json";

        public static List<Question> LoadQuestions()
        {
            List<Question> questions = new List<Question>();

            if (FileManager.FileExists(pathQuestions))
            {
                var readText = FileManager.ReadFromFile(pathQuestions);
                if (readText.Length < 1)
                {
                    questions = GetDefaultQuestions();
                    SaveQuestionsToFile(questions);
                }
                else
                {
                    questions = JsonConvert.DeserializeObject<List<Question>>(readText);
                }
            }
            else
            {
                questions = GetDefaultQuestions();
                SaveQuestionsToFile(questions);
            }

            return questions;
        }

        private static List<Question> GetDefaultQuestions()
        {
            List<Question> defaultQuestions = new List<Question>
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках", 25),
                new Question("Укол делают каждые полчаса. Сколько минут нужно на 3 укола?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2)
            };
            return defaultQuestions;
        }

        public static void SaveQuestionsToFile (List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileManager.Replace(pathQuestions, jsonData);
        }

        public static void AddQuestion(string question, int answer)
        {
            var questions = LoadQuestions();
            questions.Add(new Question(question, answer));
            SaveQuestionsToFile(questions);
        }

    }
}
