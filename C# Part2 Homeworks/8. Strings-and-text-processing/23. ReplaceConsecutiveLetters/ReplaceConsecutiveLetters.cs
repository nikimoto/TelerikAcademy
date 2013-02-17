using System;
using System.Collections.Generic;
using System.Text;

class ReplaceConsecutiveLetters
{
    static void Main()
    {
        string text = "aaaaabbbbbcdddeeeedssaajjjgddfjjsdfhg";
        StringBuilder cleanText = new StringBuilder(text);

        for (int letter = 0; letter < cleanText.Length - 1; letter++)
        {
            if (cleanText[letter] == cleanText[letter + 1])
            {
                cleanText.Remove(letter, 1);
                letter--;
            }
        }
        Console.WriteLine(cleanText);
    }
}
