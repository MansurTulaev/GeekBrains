using System;

namespace lesson3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine();
            string reversedWord = ""; //создание пустой строки
            for (int i = word.Length-1; i>=0; i--)
            {
                reversedWord = reversedWord + word[i]; //добавление элементов с конца
            }
            Console.WriteLine(reversedWord);
        }
    }
}
