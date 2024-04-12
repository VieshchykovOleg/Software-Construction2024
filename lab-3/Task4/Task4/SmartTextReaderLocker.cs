using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class SmartTextReaderLocker : ISmartTextReader
{
    private SmartTextReader textReader;
    private Regex fileRegex;

    public SmartTextReaderLocker(string filePath, string pattern)
    {
        textReader = new SmartTextReader(filePath);
        fileRegex = new Regex(pattern);
    }

    public char[,] ReadText()
    {
        if (!fileRegex.IsMatch(textReader.ToString()))
        {
            Console.WriteLine("Access denied!");
            return null;
        }

        return textReader.ReadText();
    }
}

