using System;
using System.Collections.Generic;
using System.Text;


class HexToDec
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number to convert into a decimal: n = ");
        string input = Console.ReadLine();
        input = input.ToUpper();
        
        int decNum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            decNum += ((input[i] - '0') < 10 ? input[i] - '0' : (input[i] - 55)) * (int)Math.Pow(16, input.Length - 1 - i);
        }

        Console.WriteLine("The decimal representation of {0} number is: {1}", input, decNum);
    }
}
