using System;


class LeapYear
{
    static void Main()
    {
        bool isValidYear = false;
        int year;
        do
        {
            Console.Write("Please, enter an year to check if it's leap: "); 
            isValidYear = int.TryParse(Console.ReadLine(), out year);
        }
        while (!isValidYear);
        bool leap = false;
        try
        {
            leap = DateTime.IsLeapYear(year);
            Console.WriteLine("Is {0} year leap? -> {1}", year, leap);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Year must be between 1 and 9999");            
        }       
    }
}
