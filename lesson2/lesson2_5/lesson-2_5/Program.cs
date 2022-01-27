using System;

namespace lesson_2_5
{
    class RainyWinter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12");
            string monthCurrent = Console.ReadLine();
            if (Convert.ToInt32(monthCurrent) >= 0 && Convert.ToInt32(monthCurrent) <= 12)
            {
                switch (monthCurrent)
                {
                    case "1":
                    case "2":
                    case "12":
                        Console.WriteLine("Введите минимальную температуру: ");
                        int minTemp = Convert.ToInt32(Console.ReadLine()); //Считывание минимальной температуры
                        Console.WriteLine("Введите максимальную температуру: ");
                        int maxTemp = Convert.ToInt32(Console.ReadLine()); //Считывание максимальной температуры
                        if ((maxTemp + minTemp) / 2 > 0)
                            Console.WriteLine("Дождливая зима");
                        else
                            Console.WriteLine("Снежная зима");
                        break;
                    default:
                        Console.WriteLine("Вы ввели незимний месяц");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Вы ввели неправильное число");

            }
        }
    }
}
