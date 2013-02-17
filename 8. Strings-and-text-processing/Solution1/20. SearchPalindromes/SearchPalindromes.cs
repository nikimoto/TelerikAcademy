using System;

class SearchPalindromes
{
    static void Main()
    {
        string text = @"Nice blue sky. No exe flying in the sky. ABBA will not come in Bulgaria.
       I don`t know what is lamal, maybe I will find some day. mouseesuom";
        char[] separators = { ' ', ',', '.', '!', '?', '\n', '\r', '\t' };
        string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in splitted)
        {
            bool isPalindrome = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && word.Length > 1)
            {
                Console.WriteLine(word);
            }
        }
    }
}
