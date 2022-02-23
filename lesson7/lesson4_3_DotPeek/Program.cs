// Decompiled with JetBrains decompiler
// Type: lesson4_3.Program
// Assembly: lesson4_3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4265C3D-2AC7-4B2D-8E7C-88A1D798AA7D
// Assembly location: C:\Users\mdtulaev\source\repos\lesson7\lesson7_SourceCode\lesson4_3\bin\Debug\net5.0\lesson4_3.dll

using System;

namespace lesson4_3
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Введите число от 1 до 12");
      int int32 = Convert.ToInt32(Console.ReadLine());
      if (int32 < 13 && int32 > 0)
      {
        Console.WriteLine("Ваш месяц");
        string season;
        GetSeason(int32, out season);
        Console.WriteLine(season);
      }
      else
        Console.WriteLine("Ошибка: введите число от 1 до 12");

      void GetSeason(int number, out string season)
      {
        season = "";
        switch (number)
        {
          case 1:
          case 2:
          case 12:
            season = Program.Seasons.Winter.ToString();
            break;
          case 3:
          case 4:
          case 5:
            season = Program.Seasons.Spring.ToString();
            break;
          case 6:
          case 7:
          case 8:
            season = Program.Seasons.Summer.ToString();
            break;
          case 9:
          case 10:
          case 11:
            season = Program.Seasons.Fall.ToString();
            break;
        }
      }
    }

    private enum Seasons
    {
      Winter,
      Spring,
      Summer,
      Fall,
    }
  }
}
