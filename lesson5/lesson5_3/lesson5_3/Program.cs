using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lesson5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            string stringNumbers = Console.ReadLine();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(new FileStream("numbers.bin", FileMode.OpenOrCreate), stringNumbers);
            //string desser = formatter.Deserialize(new FileStream("numbers.bin", FileMode.OpenOrCreate)).ToString(); считывание чисел из бинарного файла
            //Console.WriteLine(desser);

        }
    }
}
