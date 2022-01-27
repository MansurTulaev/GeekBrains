using System;

namespace lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int numberInput = Convert.ToInt32(Console.ReadLine()); // считывание число
            if (numberInput % 2 == 0) // анализируем по остатку от деления на 2
                Console.WriteLine($"{numberInput} - четное число");
            else
                Console.WriteLine($"{numberInput} - нечетное число");
        }

    }
}
