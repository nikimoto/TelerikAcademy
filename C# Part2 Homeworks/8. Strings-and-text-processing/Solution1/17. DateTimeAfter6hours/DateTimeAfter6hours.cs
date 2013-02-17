using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

class DateTimeAfter6hours
{
    static void Main()
    {
        Console.WriteLine("Please enter date an time in the format:D.M.YYYY HH:mm:ss");
        string inputDateTime = Console.ReadLine();

        DateTime date = DateTime.ParseExact(inputDateTime, "d.M.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("After 6 hours and 30 minutes will be: {0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
    }
}
