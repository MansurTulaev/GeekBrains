using System;
using System.Diagnostics;

namespace lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Идет вывод всех процессов на компьютере");
            Process[] processArray = Process.GetProcesses();
            for (int i = 0; i < processArray.Length; i++)
                Console.WriteLine($"{processArray[i].ProcessName}"); //Вывод всех процессов
            string processName = Console.ReadLine(); //считывание названия процесса
            for (int i = 0; i < processArray.Length; i++) //закрытие процесса если совпадают названия
                if (processName.Equals(processArray[i].ProcessName))
                {
                    Console.WriteLine($"{processArray[i].ProcessName} завершен по требованию пользователя");
                    processArray[i].Kill();
                }
                    



        }
    }
}
