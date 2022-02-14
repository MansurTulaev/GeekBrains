using System;
using System.IO;

namespace lesson5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Идет запись в текстовый файл");
            File.AppendAllText("startup.txt", Environment.NewLine+DateTime.Now.ToString());
        }
    }
}
