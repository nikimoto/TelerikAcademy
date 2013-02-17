using System;
using System.Collections.Generic;
using System.Text;


class BinToHexDirectly
{
    static void Main()
    {
        Console.Write("Enter a binary number to convert into a hexadecimal: n = ");
        string input = Console.ReadLine();
        //input = input.ToUpper();
        if (input.Length % 4 != 0)
        {
            input = new String('0', 4 - input.Length % 4) + input;
        }
        StringBuilder hexNum = new StringBuilder();
        for (int i = 0; i < input.Length; i += 4)
        {
            switch (input.Substring(i, 4))
            {
                case "0000": hexNum.Append("0"); break;
                case "0001": hexNum.Append("1"); break;
                case "0010": hexNum.Append("2"); break;
                case "0011": hexNum.Append("3"); break;
                case "0100": hexNum.Append("4"); break;
                case "0101": hexNum.Append("5"); break;
                case "0110": hexNum.Append("6"); break;
                case "0111": hexNum.Append("7"); break;
                case "1000": hexNum.Append("8"); break;
                case "1001": hexNum.Append("9"); break;
                case "1010": hexNum.Append("A"); break;
                case "1011": hexNum.Append("B"); break;
                case "1100": hexNum.Append("C"); break;
                case "1101": hexNum.Append("D"); break;
                case "1110": hexNum.Append("E"); break;
                case "1111": hexNum.Append("F"); break;
                default: hexNum.Append(""); break;
            }
        }
        string result = hexNum.ToString();
        Console.Write("The hexadecimal representation of number {0} is: ", input);
        Console.WriteLine(result);
    }
}
