using System;

namespace GB_practice1
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, имя");
            string name = Console.ReadLine(); //объявление переменной name
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now.ToString("dd.MM.yyyy")}"); //формат даты %день.месяц.год%
            Console.ReadLine();


        }
    }
}
