using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Properties.Settings.Default.Greeting);
            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.WriteLine("Введите имя пользователя");
                Properties.Settings.Default.Name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.WriteLine("Введите ваш возраст");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Occupation))
            {
                Console.WriteLine("Введите ваш род деятельности");
                Properties.Settings.Default.Occupation = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            Console.WriteLine($"Ваше имя: {Properties.Settings.Default.Name}");
            Console.WriteLine($"Ваш возраст: {Properties.Settings.Default.Age}");
            Console.WriteLine($"Ваш род деятельности: {Properties.Settings.Default.Occupation}");
            Console.ReadKey();
        }
    }
}
