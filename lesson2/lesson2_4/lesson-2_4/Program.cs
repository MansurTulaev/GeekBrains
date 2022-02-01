using System;

namespace lesson_2_4
{
    class DrawCheck
    {
        static void Main(string[] args)
        {
            string firstProduct = "Брендирование электронных чеков для отправки" + Environment.NewLine + "покупателям по e-mail";
            int sumFirstProduct = 500;
            int quantityFirstProduct = 3;
            string secondProduct = "Мягкая игрушка Фискальный накопитель";
            int sumSecondProduct = 500;
            int quantitySecondProduct = 2;
            DateTime currentDate = new DateTime(2020, 4, 20);
            Console.WriteLine(currentDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("---------------------------");
            Console.WriteLine(firstProduct);
            Console.WriteLine($"{sumFirstProduct} x {quantityFirstProduct}  = {sumFirstProduct * quantityFirstProduct}");
            Console.WriteLine($"НДС 20%    = {sumFirstProduct * quantityFirstProduct * 0.2}");
            Console.WriteLine(secondProduct);
            Console.WriteLine($"{quantitySecondProduct} X {sumSecondProduct}  = {quantitySecondProduct * sumSecondProduct}");
            Console.WriteLine($"НДС 10%    = {quantitySecondProduct * sumSecondProduct * 0.1}");
            Console.WriteLine("---------------------------");
            Console.WriteLine($"ИТОГО {(sumFirstProduct * quantityFirstProduct) + (sumSecondProduct * quantitySecondProduct)}");
            Console.WriteLine("Налогообложение: ОСН");
            Console.WriteLine($"Сумма НДС: {(sumFirstProduct * quantityFirstProduct * 0.2) + (sumSecondProduct * quantitySecondProduct * 0.1)}");
        }
    }
}
