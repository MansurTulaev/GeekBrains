using System;

namespace lesson3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] phoneBook = new string[5, 2] { { "Сидоров", "88005553535" }, { "Петров", "petrov@mail.ru" }, { "Иванов", "ivanov@mail.ru" }, { "Анисимов", "anisimov@mail.ru" }, { "Николаев", "nicolaev@mail." } };
            Console.WriteLine("Введите имя: ");
            string findName = Console.ReadLine();
            int counter = 0; //переменная для подсчета числа совпадений
            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                if (findName.Equals(phoneBook[i, 0]))
                {
                    Console.WriteLine(phoneBook[i, 1]);
                    counter++;
                }
            }
            if (counter == 0) //если в массиве не найдено имя, выводится соответствующее сообщение
            { 
                Console.WriteLine("Для этого имени не найден телефон/имейл"); 
            }
        }
    }
}
