using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SmartTextReaderProxy : ISmartTextReader
{
    private SmartTextReader textReader;

    public SmartTextReaderProxy(string filePath)
    {
        textReader = new SmartTextReader(filePath);
    }

    public char[,] ReadText()
    {
        Console.WriteLine("Opening file for reading...");
        char[,] text = textReader.ReadText();
        if (text != null)
        {
            Console.WriteLine($"File read successfully. Number of lines: {text.GetLength(0)}, number of characters: {text.GetLength(1)}");
        }
        Console.WriteLine("Closing file...");
        return text;
    }
}
