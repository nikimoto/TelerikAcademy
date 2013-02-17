using System;
using System.Collections.Generic;
using System.Text;

class DecToHex
{
    static void Main()
    {
        Console.Write("Enter a decimal number to convert into a hexadecimal: n = : ");
        string number = Console.ReadLine();
        int decNum = int.Parse(number);
        StringBuilder hexNum = new StringBuilder();

        while (decNum > 0)
        {
            switch (decNum % 16)
            {
                case 10:
                    hexNum.Append('A');
                    break;
                case 11:
                    hexNum.Append('B');
                    break;
                case 12:
                    hexNum.Append('C');
                    break;
                case 13:
                    hexNum.Append('D');
                    break;
                case 14:
                    hexNum.Append('E');
                    break;
                case 15:
                    hexNum.Append('F');
                    break;
                default:
                    hexNum.Append(decNum % 16);
                    break;
            }
            decNum = decNum / 16;
        }
        string result = hexNum.ToString();
        Console.Write("The hexadecimal representation of number {0} is: ", number);

        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
