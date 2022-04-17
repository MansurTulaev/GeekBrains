using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            RatioNumbers firstNumber = new RatioNumbers(1, 2);
            RatioNumbers secondNumber = new RatioNumbers(1, 3);
            RatioNumbers sum = secondNumber + firstNumber;
            Console.WriteLine(sum.ToString());
            RatioNumbers sub = secondNumber - firstNumber;
            Console.WriteLine(sub.ToString());
        }

        class RatioNumbers
        {
            private int _numerator;
            private int _denominator;
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            public RatioNumbers(int numer, int denom)
            {
                Numerator = numer;
                Denominator = denom;
            }

            public RatioNumbers()
            {

            }

            //==, != 
            //Переопределить метод ToString() для вывода дроби.
            //Определить операторы преобразования типов между типом дробь,float, int.
            //Определить операторы *, /, %

            public static RatioNumbers operator ++(RatioNumbers ratioNumbers)
            {
                ratioNumbers.Numerator = ratioNumbers.Numerator + ratioNumbers.Denominator;
                Console.WriteLine($"{ratioNumbers.Numerator} / {ratioNumbers.Denominator}");
                return ratioNumbers;
            }
            public static RatioNumbers operator --(RatioNumbers ratioNumbers)
            {
                ratioNumbers.Numerator = ratioNumbers.Numerator - ratioNumbers.Denominator;
                Console.WriteLine($"{ratioNumbers.Numerator} / {ratioNumbers.Denominator}");
                return ratioNumbers;
            }
            public static RatioNumbers operator +(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                RatioNumbers result = new RatioNumbers();
                result.Numerator = firstNumber.Numerator * secondNumber.Denominator + secondNumber.Numerator*firstNumber.Denominator;
                result.Denominator = firstNumber.Denominator * secondNumber.Denominator;
                Console.WriteLine($"{result.Numerator} / {result.Denominator}");
                return result;
            }

            public static RatioNumbers operator -(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                RatioNumbers result = new RatioNumbers();
                result.Numerator = firstNumber.Numerator * secondNumber.Denominator - secondNumber.Numerator * firstNumber.Denominator;
                result.Denominator = firstNumber.Denominator * secondNumber.Denominator;
                Console.WriteLine($"{result.Numerator} / {result.Denominator}");
                return result;
            }

            public static bool operator >(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                double firstDouble = (double)firstNumber.Numerator / (double)firstNumber.Denominator;
                double secondDouble = (double)secondNumber.Numerator / (double)secondNumber.Denominator;
                if(firstDouble > secondDouble) return true;
                else return false;

            }

            public static bool operator <(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                double firstDouble = (double)firstNumber.Numerator / (double)firstNumber.Denominator;
                double secondDouble = (double)secondNumber.Numerator / (double)secondNumber.Denominator;
                if (firstDouble < secondDouble) return true;
                else return false;

            }

            public static bool operator <=(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                double firstDouble = (double)firstNumber.Numerator / (double)firstNumber.Denominator;
                double secondDouble = (double)secondNumber.Numerator / (double)secondNumber.Denominator;
                if (firstDouble <= secondDouble) return true;
                else return false;

            }

            public static bool operator >=(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                double firstDouble = (double)firstNumber.Numerator / (double)firstNumber.Denominator;
                double secondDouble = (double)secondNumber.Numerator / (double)secondNumber.Denominator;
                if (firstDouble >= secondDouble) return true;
                else return false;

            }

            public override string ToString()
            {
                return $"{this.Numerator} / {this.Denominator}";
            }

            
            public bool Equals(RatioNumbers otherNumber)
            {
                if ((this.Numerator == otherNumber.Numerator) && (this.Denominator == otherNumber.Denominator)) return true;
                else return false;
            }

            public static bool operator ==(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                if ((firstNumber.Numerator == secondNumber.Numerator) && (firstNumber.Denominator == secondNumber.Denominator)) return true;
                else return false;
            }
            public static bool operator !=(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                if ((firstNumber.Numerator != secondNumber.Numerator) || (firstNumber.Denominator != secondNumber.Denominator)) return true;
                else return false;
            }
            public static RatioNumbers operator *(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                RatioNumbers result = new RatioNumbers();
                result.Numerator = firstNumber.Numerator * secondNumber.Numerator;
                result.Denominator = firstNumber.Denominator * secondNumber.Denominator;
                return result;
            }

            public static RatioNumbers operator /(RatioNumbers firstNumber, RatioNumbers secondNumber)
            {
                RatioNumbers result = new RatioNumbers();
                result.Numerator = firstNumber.Numerator * secondNumber.Denominator;
                result.Denominator = firstNumber.Denominator * secondNumber.Numerator;
                return result;
            }

            public static implicit operator double(RatioNumbers obj)
            {
                return obj.Numerator / obj.Denominator;
            }

            public static implicit operator float(RatioNumbers obj)
            {
                return (float)(obj.Numerator / obj.Denominator);
            }
        }
    }
}
