using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FileWriter : IFileLogger
{
    private readonly string filePath;

    public FileWriter(string filePath)
    {
        this.filePath = filePath;
    }

    public void Log(string message)
    {
        WriteToFile($"[LOG] {message}");
    }

    public void Error(string message)
    {
        WriteToFile($"[ERROR] {message}");
    }

    public void Warn(string message)
    {
        WriteToFile($"[WARN] {message}");
    }

    private void WriteToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine(message);
        }
    }
}
