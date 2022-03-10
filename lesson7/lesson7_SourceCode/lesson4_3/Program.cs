using System;

namespace lesson4_3
{
    class Program
    {
        enum Seasons
        {
            Winter,
            Spring,
            Summer,
            Autumn
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 12");
            int inNumber = Convert.ToInt32(Console.ReadLine());
            if (inNumber < 13 && inNumber > 0)
            {
                Console.WriteLine("Ваш месяц");
                GetSeason(inNumber, out string outSeason);
                Console.WriteLine(outSeason);

            }
            else
                Console.WriteLine("Ошибка: введите число от 1 до 12");
            void GetSeason(int number, out string season)
            {
                season = "";
                switch (number)
                {
                    case 1:
                    case 2:
                    case 12:
                        season = Seasons.Winter.ToString();
                        break;
                    case 3:
                    case 4:
                    case 5:
                        season = Seasons.Spring.ToString();
                        break;
                    case 6:
                    case 7:
                    case 8:
                        season = Seasons.Summer.ToString();
                        break;
                    case 9:
                    case 10:
                    case 11:
                        season = Seasons.Autumn.ToString();
                        break;
                }          
            }

        }
    }
}

