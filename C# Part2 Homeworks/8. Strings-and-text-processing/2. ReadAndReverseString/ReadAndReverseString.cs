using System;

class ReadAndReverseString
{
    static void ReverseString(string str)
    {
        for (int i = str.Length-1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter a string to reverse: ");
        string str = Console.ReadLine();

        Console.Write("The reversed string is: ");
        ReverseString(str);
    }
}
