using System;

class PrintFormatedNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());

        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0, 15:X}", (int)number);
        Console.WriteLine("{0, 15:P}", (double)number / 100);
        Console.WriteLine("{0, 15:E}", number);
    }
}
