using System;


class SplitStringAndCalculateSum
{
    private static string[] SplitArray(string str)
    {
        char[] charSeparator = new char[] { ' ', ',', '-', '/', '\\' };
        string[] splitedArray = str.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries);
        return splitedArray;
    }

    private static int CalculateSum(string[] splitedArray)
    {
        int sum = 0;
        foreach (string number in splitedArray)
        {
            sum += int.Parse(number);
        }
        return sum;
    }

    static void Main()
    {
        //string str = "43 68 9 23 318";
        Console.WriteLine("Enter numbers separated by spaces:");
        string str = Console.ReadLine();
        int sum = CalculateSum(SplitArray(str));
        Console.WriteLine("The sum is: {0}", sum);
    }
}
