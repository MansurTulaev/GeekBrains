using System;
using System.IO;

namespace lesson5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова: ");
            string inputWords = Console.ReadLine();
            Console.WriteLine("Идет запись в текстовый файл");
            File.WriteAllText("GeekText.txt", inputWords);
            
        }
    }
}
