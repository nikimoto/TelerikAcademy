using System;

class URLParsing
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string[] separators = new string[] { "://", "/" };
        string[] parsed = url.Split(separators, 3, StringSplitOptions.None);
        if (parsed.Length == 3)
        {
            parsed[2] = "/" + parsed[2];
            Console.WriteLine(" [protocol]: {0}\n [server]: {1}\n [resourse]: {2}", parsed[0], parsed[1], parsed[2]);
        }
        else
        {
            Console.WriteLine(" [protocol]: {0}\n [server]: {1}", parsed[0], parsed[1]);
        }   
    }
}
