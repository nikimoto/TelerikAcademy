using System;
using System.Collections.Generic;
using System.Text;


class ConvertAnyFromBaseSToBaseD
{
    static void Main()
    {
        Console.Write("Enter the number you want to convert: ");
        string number = Console.ReadLine();
        number = number.ToUpper();
        Console.Write("Enter the base from which is the number to convert s = ");
        int sBase = int.Parse(Console.ReadLine());
        Console.Write("Enter the base to convert the number d = ");
        int dBase = int.Parse(Console.ReadLine());

        int resultDec = 0;
        StringBuilder newNumber = new StringBuilder();
               
        //Convert to 10 base number
        for (int i = 0; i < number.Length; i++)
        {            
            resultDec += (number[i] - '0' < 10 ? number[i] - '0' : number[i] - 55 ) * (int)Math.Pow(sBase, number.Length - 1 - i);
        }
        //Convert to d base number
        while (resultDec > 0)
        {
            switch (resultDec % dBase)
            {
                case 0: newNumber.Append("0"); break;
                case 1: newNumber.Append("1"); break;
                case 2: newNumber.Append("2"); break;
                case 3: newNumber.Append("3"); break;
                case 4: newNumber.Append("4"); break;
                case 5: newNumber.Append("5"); break;
                case 6: newNumber.Append("6"); break;
                case 7: newNumber.Append("7"); break;
                case 8: newNumber.Append("8"); break;
                case 9: newNumber.Append("9"); break;
                case 10: newNumber.Append("A"); break;
                case 11: newNumber.Append("B"); break;
                case 12: newNumber.Append("C"); break;
                case 13: newNumber.Append("D"); break;
                case 14: newNumber.Append("E"); break;
                case 15: newNumber.Append("F"); break;
                default: newNumber.Append(""); break;
            }
            resultDec = resultDec / dBase;
        }
        string result = newNumber.ToString();
        Console.Write("The number {0} from NS with base {1} represented to NS with base {2} is: ", number, sBase, dBase);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }

        Console.WriteLine();   
    }
}
