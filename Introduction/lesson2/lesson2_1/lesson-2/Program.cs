using System;

namespace lesson_2
{
    class HomeWork2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру: ");
            int minTemp = Convert.ToInt32(Console.ReadLine()); //Считывание минимальной температуры
            Console.WriteLine("Введите максимальную температуру: ");
            int maxTemp = Convert.ToInt32(Console.ReadLine()); //Считывание максимальной температуры
            Console.WriteLine($"Среднесуточная температура: {(maxTemp+minTemp)/2}"); //расчет средней температуры и ее вывод
        }
    }
}
