using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

class ReverseWordsInSentence
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        char[] separator = new char[] { ',', ' ', '!', '?', '.' };
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);       
        Array.Reverse(words);
        
        string[] signs = Regex.Split(text, "[A-Za-z0-9#+]");
        List<string> spaces = new List<string>();
        for (int i = 0; i < signs.Length; i++)
        {
            if (signs[i] != String.Empty)
            {
                spaces.Add(signs[i]);
            }
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < spaces.Count; i++)
        {
            result.Append(words[i]);
            result.Append(spaces[i]);
        }
        Console.WriteLine(result.ToString());

    }
}
