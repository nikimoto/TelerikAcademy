using System;
using System.Numerics;


class CalculateTo100Factorial
{
    public static void CalculateFactorial(ref BigInteger[] factorialArr, int current)
    {
        factorialArr[current] = factorialArr[current - 1] * (current + 1);
    }

    static void Main(string[] args)
    {
        int number;
        do
        {
            Console.Write("Enter a number from 1 to 100 to calculate corresponding factorial: ");
            number = int.Parse(Console.ReadLine());
        }
        while (number <= 0 || number > 100);

        BigInteger[] factorial = new BigInteger[number];
        factorial[0] = 1;
        for (int i = 1; i < 100; i++)
        {
            CalculateFactorial(ref factorial, i);
        }

        Console.WriteLine("Calculating n!:");
        for (int i = 0; i < factorial.Length; i++)
        {
            Console.Write("{0}! = {1}", i + 1, factorial[i]);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}