using System;
using System.Text;

class ForbiddenWords
{
    static void Main()
    {
        string message = @"Microsoft announced its next generation PHP compiler today. It is based on 
.NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        string[] forbiddenWords = "PHP, CLR, Microsoft".Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder censored = new StringBuilder(message);

        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            censored.Replace(forbiddenWords[i], new String('*', forbiddenWords[i].Length));
        }
        censored.ToString();
        Console.WriteLine(message);
        Console.WriteLine("\nCensored text: ");
        Console.WriteLine(censored);

    }
}
