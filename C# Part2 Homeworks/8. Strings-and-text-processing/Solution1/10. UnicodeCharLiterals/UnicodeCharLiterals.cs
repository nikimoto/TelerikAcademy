using System;

class UnicodeCharLiterals
{
    static void Main()
    {
        string str = "Hi!";

        foreach (char symbol in str)
        {
            Console.Write("\\u{0:x4}", (int)symbol);
        }
        Console.WriteLine();
    }
}
