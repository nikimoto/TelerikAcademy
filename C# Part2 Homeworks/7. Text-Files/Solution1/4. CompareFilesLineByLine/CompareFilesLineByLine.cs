using System;
using System.IO;

class CompareFilesLineByLine
{
    static void Main()
    {
        string firstFileName = "../../text1.txt";
        string secondFileName = "../../text2.txt";
        int equalLines = 0;
        int differentLines = 0;
        StreamReader reader1 = new StreamReader(firstFileName);
        StreamReader reader2 = new StreamReader(secondFileName);

        using (reader1)
        {
            using (reader2)
            {
                string firstFileLine = reader1.ReadLine();
                string secondFileLine = reader2.ReadLine();                

                while(firstFileLine != null && secondFileLine != null)
                {
                    if (firstFileLine == secondFileLine)
                    {
                        equalLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstFileLine = reader1.ReadLine();
                    secondFileLine = reader2.ReadLine();
                }
            }
        }
        Console.WriteLine("The two files have {0} equals lines.", equalLines);
        Console.WriteLine("The two files have {0} diffent lines.", differentLines);
    }
}
