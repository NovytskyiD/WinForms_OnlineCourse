using System.IO;
using System.Text;

namespace GeniyIdiotClassLibrary
{
    class FileManager
    {
        public static string ReadFromFile(string path)
        {
            var reader=new StreamReader(path,Encoding.UTF8);
            var readText = reader.ReadToEnd();
            reader.Close();
            return readText;
        }

        public static void Append(string path, string value)
        {
            var writer = new StreamWriter(path, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();

        }

        public static void Replace(string path, string value)
        {
            var writer = new StreamWriter(path, false, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();

        }

        public static bool FileExists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
