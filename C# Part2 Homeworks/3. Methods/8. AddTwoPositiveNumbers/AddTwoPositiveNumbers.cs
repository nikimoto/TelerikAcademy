using System;
using System.Collections.Generic;


class AddTwoPositiveNumbers
{
    static int[] FillNumber(string stringNumber)
    {
        int[] number = new int[stringNumber.Length];
        for (int i = stringNumber.Length-1; i >= 0; i--)
        {
            number[stringNumber.Length - i - 1] = (int)Char.GetNumericValue(stringNumber[i]);
        }
        return number;
    }

    static List<int> AddTwoNumbers(int[] a, int[] b)
    {
        int max = Math.Max(a.Length, b.Length);
        List<int> result = new List<int>();

        int carry = 0;
        for (int i = 0; i < max; i++)
        {
            int currentDigit = ((i < a.Length ? a[i] : 0) + (i < b.Length? b[i] : 0 ) + carry );
            carry = currentDigit / 10;
            result.Add(currentDigit % 10);
        }
        if (carry == 1)
        {
            result.Add(1);
        }
        return result;
    }

    static void PrintResult(List<int> result)
    {
        for (int i = result.Count-1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter two integer numbers: ");
        Console.Write("Number 1 = ");
        string strignNumber1 = Console.ReadLine();

        Console.Write("Number 2 = ");
        string stringNumber2 = Console.ReadLine();

        int[] number1 = new int[strignNumber1.Length];
        int[] number2 = new int[stringNumber2.Length];
        number1 = FillNumber(strignNumber1);
        number2 = FillNumber(stringNumber2);

        PrintResult(AddTwoNumbers(number1, number2));
    }
}

