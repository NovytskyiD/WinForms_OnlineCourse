using System;
using System.Text.RegularExpressions;

namespace GeniyIdiotClassLibrary
{
    public class TextTools
    {
        public static int GetNumber()
        {
            bool isNumeric = false;
            string userAnswer = "";

            while (!isNumeric)
            {
                userAnswer = Console.ReadLine();

                isNumeric = Regex.IsMatch(userAnswer, @"^\d+$");

                if (isNumeric)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число!");
                    continue;
                }
            }
            return Convert.ToInt32(userAnswer);
        }

        public static bool isNumeric (string value)
        {
            try
            {
                Convert.ToInt32(value);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool GetYesOrNo(string message)
        {
            Console.WriteLine(message + " - Да или Нет?");
            while (true)
            {
                string retry = Console.ReadLine();

                if (retry.ToLower() == "нет")
                    return false;
                else if (retry.ToLower() == "да")
                    return true;
                else
                {
                    Console.WriteLine($"Пожалуйста, сделайте выбор - Да/Нет");
                }
            }
        }

    }
}

