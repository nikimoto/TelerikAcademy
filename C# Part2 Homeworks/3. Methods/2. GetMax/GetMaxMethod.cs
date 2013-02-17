using System;
using System.Collections.Generic;


class MaximalNum
{
    static int GetMax(int first, int second)
    {
        int max = first;
        if (first < second)
        {
            max = second;
        }
        return max;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int one = int.Parse(Console.ReadLine());

        Console.Write("Enter second number:");
        int two = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int three = int.Parse(Console.ReadLine());

        int max = GetMax(one, two);
        Console.WriteLine("The bigest number is {0}", GetMax(max, three));
    }
}
