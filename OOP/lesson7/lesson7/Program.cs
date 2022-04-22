using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    class Program
    {
        //Делаю кодировку для английского алфавита. Дефолтная кодировка на моем компе Windows-1251. Использую только нижние символы. С 97 по 122 - английский алфавит
        static void Main(string[] args)
        {
            ACoder aCoder = new ACoder();
            Console.WriteLine(aCoder.Encode("mansur"));
            Console.WriteLine(aCoder.Decode("nbotvs"));

            BCoder bCoder = new BCoder();
            Console.WriteLine(bCoder.Encode("mansur"));
            Console.WriteLine(bCoder.Decode("nzmhfi"));
            Console.ReadLine();
        }

        interface ICoder
        {
            string Encode(string a);
            string Decode(string b);
        }

        class ACoder: ICoder
        {
            public string Encode(string a)
            {
                a.ToLower();
                byte[] initialBytes = Encoding.Default.GetBytes(a.ToCharArray());
                byte[] resultBytes = new byte[initialBytes.Length];
                for (int i = 0; i< initialBytes.Length; i++ )
                //foreach (byte i in Encoding.UTF32.GetBytes(a.ToCharArray()))
                {
                    byte m;
                    if ((int)(initialBytes[i] + 1) > 122)
                        m = (byte)(initialBytes[i]+ 1 - 26);
                    else
                        m = (byte)(initialBytes[i] + 1);
                    Console.WriteLine($"Было {initialBytes[i].ToString()}. Стало {m.ToString()}");
                    resultBytes[i] = m;
                }

                return new string(Encoding.Default.GetChars(resultBytes));

            }

            public string Decode(string a)
            {
                a.ToLower();
                byte[] initialBytes = Encoding.Default.GetBytes(a.ToCharArray());
                byte[] resultBytes = new byte[initialBytes.Length];
                for (int i = 0; i < initialBytes.Length; i++)
                //foreach (byte i in Encoding.UTF32.GetBytes(a.ToCharArray()))
                {
                    byte m;
                    if ((int)(initialBytes[i] - 1) < 97)
                        m = (byte)(initialBytes[i] - 1 + 26);
                    else
                        m = (byte)(initialBytes[i] - 1);
                    Console.WriteLine($"Было {initialBytes[i].ToString()}. Стало {m.ToString()}");
                    resultBytes[i] = m;
                }

                return new string(Encoding.Default.GetChars(resultBytes));

            }

        }
        class BCoder : ICoder //В кодировке Windows-1251 сумма элемента и его зеркала равна 219ю Чтобы узнать другой элемент, нужно вычесть из 219 число
        {
            public string Encode(string a)
            {
                a.ToLower();
                byte[] initialBytes = Encoding.Default.GetBytes(a.ToCharArray());
                byte[] resultBytes = new byte[initialBytes.Length];
                for (int i = 0; i < initialBytes.Length; i++)
                //foreach (byte i in Encoding.UTF32.GetBytes(a.ToCharArray()))
                {
                    byte m;
                    m = (byte)(219 - initialBytes[i]);
                    Console.WriteLine($"Было {initialBytes[i].ToString()}. Стало {m.ToString()}");
                    resultBytes[i] = m;
                }

                return new string(Encoding.Default.GetChars(resultBytes));

            }

            public string Decode(string a)
            {
                a.ToLower();
                byte[] initialBytes = Encoding.Default.GetBytes(a.ToCharArray());
                byte[] resultBytes = new byte[initialBytes.Length];
                for (int i = 0; i < initialBytes.Length; i++)
                //foreach (byte i in Encoding.UTF32.GetBytes(a.ToCharArray()))
                {
                    byte m;
                    m = (byte)(219 - initialBytes[i]);
                    Console.WriteLine($"Было {initialBytes[i].ToString()}. Стало {m.ToString()}");
                    resultBytes[i] = m;
                }

                return new string(Encoding.Default.GetChars(resultBytes));

            }

        }
    }
}
