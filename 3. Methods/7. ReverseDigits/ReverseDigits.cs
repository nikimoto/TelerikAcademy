using System;
using System.Collections.Generic;


class ReverseDigits
{
    static void ReverseDigitsOfDecimal(decimal number)
    {
        string reversed = number.ToString();
        for (int i = reversed.Length-1; i >= 0; i--)
        {
            Console.Write(reversed[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number");
        decimal num;
        bool isValid = decimal.TryParse(Console.ReadLine(), out num);
        if (isValid)
        {
            ReverseDigitsOfDecimal(num);
        }
        else
        {
            Console.WriteLine("The decimal separator must be ',' !");
        }
    }
}

