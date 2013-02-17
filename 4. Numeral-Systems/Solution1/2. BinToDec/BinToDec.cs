using System;
using System.Collections.Generic;


class BinToDec
{
    static void Main()
    {
        Console.Write("Enter a binary number to convert into a decimal: n = ");
        string input = Console.ReadLine();
       
        int decNum = 0;

        for (int i = 0, j = input.Length - 1; i < input.Length; i++, j--)
        {
            decNum += (input[i] - 48) * (int)Math.Pow(2, j);            
        }

        Console.WriteLine("The decimal representation of {0} number is: {1}",input, decNum);
    }
}
