using System;

namespace lesson3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seaBattle = new string[10, 10];
            for (int i = 0; i < seaBattle.GetLength(0); i++) //Наполнение матрицы
            {
                for (int j=0; j<seaBattle.GetLength(1); j++)
                {
                    if (i%2==0)
                    {
                        seaBattle[i, j] = "X";
                    }
                    else
                    {
                        seaBattle[i, j] = "O";
                    }
                    Console.Write($"{seaBattle[i, j]} ");
                }
                Console.WriteLine();
            }
            //Считывание номера строки и столбца
            Console.WriteLine("Введите номер строки от 1 до 10");
            int indexRow = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите номер столбца от 1 до 10");
            int indexColumn = Convert.ToInt32(Console.ReadLine()) - 1;
            //Если поле равно X, то юзер попал
            if (seaBattle[indexRow, indexColumn].Equals("X"))
                Console.WriteLine("Вы попали");
            else
                Console.WriteLine("Вы промахнулись");
        }
    }
}
