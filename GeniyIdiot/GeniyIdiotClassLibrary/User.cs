using System;

namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string Name;
        public string Diagnose;
        public int Result;

        public void SetDiagnose(int countRightAnswers, int countQuestions)
        {
            Result = countRightAnswers;

            double pecrentRightAnswers = (double)countRightAnswers / countQuestions;

            if (pecrentRightAnswers < 0.2)
            {
                Diagnose = "Идиот";
                return;
            }
            if (pecrentRightAnswers < 0.4)
            {
                Diagnose = "Кретин";
                return;
            }
            if (pecrentRightAnswers < 0.6)
            {
                Diagnose = "Дурак";
                return;
            }
            if (pecrentRightAnswers < 0.8)
            {
                Diagnose = "Нормальный";
                return;
            }
            if (pecrentRightAnswers < 1)
            {
                Diagnose = "Талант";
                return;
            }
            else
            {
                Diagnose = "Гений";
                return;
            }
        }
    }

    
}
