using System;
using System.IO;

namespace lesson5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу");
            string fileName = Console.ReadLine();
            static void GetDirectoriesRecursive(string path, string file)
            {
                File.AppendAllLines(file, new[] { path });
                var subdirectories = Directory.EnumerateDirectories(path);
                foreach (string subdirectory in subdirectories)
                    GetDirectoriesRecursive(subdirectory, file);
            }
            GetDirectoriesRecursive(fileName, "ololo.txt");


        }
    }
}
