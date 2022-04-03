using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstString = "Mans";
            Console.WriteLine("Enter the word");
            string firstString = Console.ReadLine();
            Console.WriteLine($"Input String is {firstString}. Reversed String is {ReverseString(firstString)}");
            Console.ReadKey();
        }
        public static string ReverseString(string input)
        {
            char[] stringToChar = input.ToCharArray();
            Array.Reverse(stringToChar);
            return new string (stringToChar);
        }
    }
}
