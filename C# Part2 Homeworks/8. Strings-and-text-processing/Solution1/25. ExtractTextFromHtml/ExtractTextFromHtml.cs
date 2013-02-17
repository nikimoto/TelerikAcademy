using System;

class ExtractTextFromHtml
{
    static void Main()
    {
        string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skillful .NET software engineers.</p></body></html>";
        int startIndex = 0;
        int endIndex = 0;
        Console.WriteLine(str);
        Console.WriteLine("\nHTML text content: \n");

        while (endIndex != -1)
        {
            string text = "";
            endIndex = str.IndexOf('>', startIndex);
            if (endIndex == -1)
            {
                break;
            }

            startIndex = endIndex + 1;
            endIndex = str.IndexOf('<', startIndex);
            if (endIndex == -1)
            {
                break;
            }
            if (endIndex - startIndex > 1)
            {
                int lenght = endIndex - startIndex;
                text = str.Substring(startIndex, lenght);                
                Console.WriteLine(text);
            } 
        }
    }
}
