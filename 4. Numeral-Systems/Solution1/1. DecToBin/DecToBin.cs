using System;
using System.Collections.Generic;


class DecToBin
{
    static void Main()
    {
        Console.Write("Enter a decimal number to convert into a binary: n = : ");
        string number = Console.ReadLine();
        int dec = int.Parse(number);
        List<int> bin = new List<int>();

        while (dec > 0)
        {
            bin.Add(dec % 2);
            dec /= 2;
        }
        Console.Write("The binary representation of number {0} is: ", number);
        for (int i = bin.Count-1; i >= 0; i--)
        {
            Console.Write("{0}", bin[i]);
        }
        Console.WriteLine();
    }
}
