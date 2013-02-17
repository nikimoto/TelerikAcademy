using System;
using System.Text.RegularExpressions;

class ShowSentenceWithWordIN
{
    static void Main()
    {
        string text = "In. We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";

        string[] sentence = text.Split('.');

        for (int i = 0; i < sentence.Length; i++)
        {
            if (Regex.Matches(sentence[i], @"\b" + word + @"\b",RegexOptions.IgnoreCase) .Count > 0) 
            {
                Console.WriteLine((sentence[i] + ".").Trim());
            }
        }        
    }
}