using System;

namespace lesson_2_6
{
    class Program
    {
            [Flags]
            public enum WeekDays
        {
            Monday = 0b_00000001,
            Tuesday = 0b_00000010,
            Wednesday = 0b_00000100,
            Thursday = 0b_00001000,
            Friday = 0b_00010000,
            Saturday = 0b_00100000,
            Sunday = 0b_01000000
        }

        static void Main(string[] args)
        {
            WeekDays workingDays1 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday | WeekDays.Saturday | WeekDays.Sunday;
            WeekDays workingDays2 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            WeekDays workingDays3 = WeekDays.Monday | WeekDays.Tuesday | WeekDays.Thursday | WeekDays.Friday;

            WeekDays office1 = (WeekDays)0b01111111;
            WeekDays office2 = (WeekDays)0b00011111;
            WeekDays office3 = (WeekDays)0b00011011;

            if (office1 == workingDays1)
                Console.WriteLine("Оффис 1 работает без выходных");
            if (office2 == workingDays2)
                Console.WriteLine("Оффис 2 работает полную рабочую неделю");
            if (office3 == workingDays3)
                Console.WriteLine("Оффис 3 работает 2 через один");


        }
    }
}
