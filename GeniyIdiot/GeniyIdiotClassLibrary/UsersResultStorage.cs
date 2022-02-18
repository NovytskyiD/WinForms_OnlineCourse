using System.Collections.Generic;
using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary
{
    public class UsersResultStorage
    {
        private static string path = "./Results.json";

        public static List<User> GetResults ()
        {
            if (!FileManager.FileExists(path))
            {
                return new List<User>();
            }
            var readText = FileManager.ReadFromFile(path);
            var userResults = JsonConvert.DeserializeObject<List<User>>(readText);
            return userResults;
        }

        public static void Append (User user)
        {
            var userResult = GetResults();
            userResult.Add(user);
            SaveResults(userResult);
        }

        public static void SaveResults(List<User> users)
        {

            var jsonDate = JsonConvert.SerializeObject(users,Formatting.Indented);
            FileManager.Replace(path, jsonDate);

        }
    }
}
