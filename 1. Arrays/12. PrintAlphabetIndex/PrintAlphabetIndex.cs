using System;
using System.Collections.Generic;


class PrintAlphabetIndex
{
    static void Main()
    {
        char[] letters = new char[26];

        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = (char)('a' + i);
        }

        string word = Console.ReadLine().ToLower();

        foreach (char letter in word)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                if (letter == letters[i])
                {
                    Console.WriteLine("Letter '{0}' has index {1}", letter, i + 1);
                    break;
                }
            }
        }
    }
}
