using System;

class UpcaseTag
{
    static void Main()
    {
        string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";       
        int startIndex = 0;        
        int endIndex = 0;
        Console.WriteLine(str);

        while (endIndex != -1)
        {
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
                string old = str.Substring(startIndex, lenght);
                string upper = old.ToUpper();                
                str = str.Replace(old, upper);                
                str = str.Remove(startIndex - 8, 8);
                str = str.Remove(endIndex - 8, 9);
            }
        }
        Console.WriteLine();
        Console.WriteLine(str);
    }
}
