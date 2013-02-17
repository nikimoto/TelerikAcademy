using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class RemoveAllWordsFromListed
{    
    static List<string> ReadList()
    {
        List<string> words = new List<string>();
        StreamReader readWordsFile = new StreamReader(@"..\..\Words to remove.txt");        
        string word = readWordsFile.ReadLine();        

        using (readWordsFile)
        {
            while (word != null)
            {
                words.Add(word);
                word = readWordsFile.ReadLine();
            }
        }
        return words;

    }

    static void Main()
    {
        char[] separator = {' ', '\r', '\n', ','};
        try
        {
            List<string> words = ReadList();                      
            
            using ( StreamReader readText = new StreamReader(@"..\..\All Words.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\Remaining Words.txt"))
                {
                    string line = readText.ReadLine();
                    while (line != null)
                    {
                        for (int i = 0; i < words.Count; i++)
                        {
                            string word = @"\b" + words[i] + @"\b"; // only for whole words, not substrings
                            //line = String.Empty;
                            line = Regex.Replace(line, word, "");                            
                        }
                        writer.WriteLine(line);
                        line = readText.ReadLine();
                    }
                }
            }
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }
    }
}
