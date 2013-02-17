using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextWithoutTags
{
    static void Main()
    {
        string fileName = @"..\..\HelloStranger.txt";
        string OutputFileName = @"..\..\HelloStranger Edited.txt";

        List<string> clearText = new List<string>();
        string xmlContent = "";
        int startIndex = 0,
            tempIndex = 0,
            lengthToEnd = 0;

        using(StreamReader reader = new StreamReader(fileName))
        {
            xmlContent = reader.ReadToEnd();
        }

        while (tempIndex != -1)
        {
            tempIndex = xmlContent.IndexOf('>', startIndex);
            if (tempIndex == -1)
            {
                break;
            }

            startIndex = tempIndex + 1;
            tempIndex = xmlContent.IndexOf('<', startIndex);
            if (tempIndex == -1)
            {
                break;
            }

            if (tempIndex - startIndex > 1)
            {
                lengthToEnd = tempIndex - startIndex;
                clearText.Add(xmlContent.Substring(startIndex,lengthToEnd).Trim());
            }
            startIndex = tempIndex + 1;
            lengthToEnd = 0;
        }       

        using( StreamWriter writer = new StreamWriter(OutputFileName))
        {
            foreach (string line in clearText)
	        {
                writer.WriteLine(line);
	        }
        }    
    }
}
