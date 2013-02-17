using System;
using System.Globalization;

class DaysBetweenDates
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Please enter a date in the format:D.MM.YYYY");
            string firstDate = Console.ReadLine();

            Console.WriteLine("Please enter a date in the format:D.MM.YYYY");
            string secondDate = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(firstDate, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(secondDate, "d.MM.yyyy", CultureInfo.InvariantCulture);            
            Console.WriteLine("The distance is:{0} days", (endDate - startDate).TotalDays);
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter the dates in the correct format d.MM.YYYY (Month with leading zero)! Make sure that such a date exists!"); ;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Please provide a date. The date cannot be null!");
        }
        
    }
}
