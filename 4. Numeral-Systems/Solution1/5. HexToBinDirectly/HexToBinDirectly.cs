using System;
using System.Collections.Generic;
using System.Text;


class HexToBinDirectly
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number to convert into a binary: n = ");
        string input = Console.ReadLine();
        input = input.ToUpper();
        StringBuilder binNum = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            switch (input.Substring(i, 1))
            {
                case "0": binNum.Append("0000 "); break;
                case "1": binNum.Append("0001 "); break;
                case "2": binNum.Append("0010 "); break;
                case "3": binNum.Append("0011 "); break;
                case "4": binNum.Append("0100 "); break;
                case "5": binNum.Append("0101 "); break;
                case "6": binNum.Append("0110 "); break;
                case "7": binNum.Append("0111 "); break;
                case "8": binNum.Append("1000 "); break;
                case "9": binNum.Append("1001 "); break;
                case "A": binNum.Append("1010 "); break;
                case "B": binNum.Append("1011 "); break;
                case "C": binNum.Append("1100 "); break;
                case "D": binNum.Append("1101 "); break;
                case "E": binNum.Append("1110 "); break;
                case "F": binNum.Append("1111 "); break;
                default: binNum.Append(""); break;
            }
        }
        string result = binNum.ToString();
        Console.Write("The binary representation of number {0} is: ", input);
        Console.WriteLine(result);
    }
}
