using System;

namespace lesson4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для подсчета числа Фибоначчи:");
            int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(GetFibonacci(num));
            for (int i = 0; i <= num; i++)
                Console.WriteLine($"Для {i} число Фибоначчи: {GetFibonacci(i)}");
        }
        static int GetFibonacci(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
                return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}
