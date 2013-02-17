using System;


class NumberOfWorkdays
{
    private static void CheckDays(DateTime now, DateTime final, DateTime[] holidays)
    {
        int lengthDays = (final - now).Days;
        int length = lengthDays;
        DateTime currentDay = new DateTime();

        for (int i = 0; i <= length; i++)
        {
            currentDay = now.AddDays(i);

            if (currentDay.DayOfWeek == DayOfWeek.Saturday || currentDay.DayOfWeek == DayOfWeek.Sunday)
            {
                lengthDays--;
                continue;
            }
            for (int j = 0; j < holidays.Length; j++)
            {
                int compare = currentDay.CompareTo(holidays[j]);
                if (compare == 0) // return 0 if match
                {
                    lengthDays--;                    
                }
            }            
        }
        PrintWorkingDays(now, final, lengthDays);
    }

    private static void PrintWorkingDays(DateTime now, DateTime final, int lengthDays)
    {
        Console.WriteLine("Today is: {0:D}", now);
        Console.WriteLine("Final date is: {0:D}", final);
        Console.WriteLine();
        Console.WriteLine("Working days: {0}", lengthDays);
    }

    static void Main()
    {
        DateTime[] holidays = 
        {
            new DateTime(2013, 1, 1),            new DateTime(2013, 3, 3),
            new DateTime(2013, 5, 1),            new DateTime(2013, 5, 2),
            new DateTime(2013, 5, 6),            new DateTime(2013, 5, 24),
            new DateTime(2013, 9, 6),            new DateTime(2013, 9, 22),
            new DateTime(2013, 12, 24),            new DateTime(2013, 12, 25),
            new DateTime(2013, 12, 26),            new DateTime(2013, 12, 31),
        };

        DateTime now = DateTime.Today;
        Console.Write("Enter final date (YYYY.MM.DD): ");
        DateTime final = DateTime.Parse(Console.ReadLine());
        CheckDays(now, final, holidays);
    }
}
