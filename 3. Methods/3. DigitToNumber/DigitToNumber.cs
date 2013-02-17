using System;
using System.Collections.Generic;



class DigitToNumber
{
    static void PrintWord(int digit)
    {
        switch (digit)
        {
            case 0: Console.WriteLine("zero"); break;
            case 1: Console.WriteLine("one"); break;
            case 2: Console.WriteLine("two"); break;
            case 3: Console.WriteLine("three"); break;
            case 4: Console.WriteLine("four"); break;
            case 5: Console.WriteLine("five"); break;
            case 6: Console.WriteLine("six"); break;
            case 7: Console.WriteLine("seven"); break;
            case 8: Console.WriteLine("eight"); break;
            case 9: Console.WriteLine("nine"); break;
            default: Console.WriteLine("Error!"); break;
        }
    }

    static void NumberToWord(int number)
    {
        if (number < 0)
        {
            number *= (-1);
        }
        if (number >= 0 && number < 10)
        {
            PrintWord(number);
        }
        else if (number >= 10)
        {
            int digit = number % 10;            
            PrintWord(digit);
        }        
    }

    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
        NumberToWord(number);
    }
}
