using System;

class URLReplace
{
    static void Main()
    {
        string text = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. 
Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(text);
        Console.WriteLine("\nReplaced text:\n");

        string replaced = text.Replace(@"<a href=""", @"[URL=");
        replaced = replaced.Replace(@""">", "]");
        replaced = replaced.Replace(@"</a>", @"[/URL]");
        Console.WriteLine(replaced);



    }
}
