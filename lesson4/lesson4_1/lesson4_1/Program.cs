using System;

namespace lesson4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetFullName(string firstName, string secondName, string patronymic) => firstName +" "+ secondName+" " + patronymic;
            Console.WriteLine(GetFullName("Федотов", "Валерий", "Сидорович"));
            Console.WriteLine(GetFullName("Масаев", "Тамби", "Гаврилович"));
            string firstName1 = "Vasiliev";
            string secondName1 = "Petr";
            string patronymic1 = "Sergeevich";
            Console.WriteLine(GetFullName(firstName1, secondName1, patronymic1));
            Console.WriteLine("Введите фамилию");
            string firstName2 = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string secondName2 = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string patronymic2 = Console.ReadLine();
            Console.WriteLine(GetFullName(firstName2, secondName2, patronymic2));
        }
        
    }
}
