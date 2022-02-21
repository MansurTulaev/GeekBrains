using System;

namespace lesson4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел через пробел:");
            string numbersString = Console.ReadLine();
            string[] numbersArray = numbersString.Split(' ');
            int sum = 0;
            for (int i = 0; i < numbersArray.Length; i++)
                sum += Convert.ToInt32(numbersArray[i]);
            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
