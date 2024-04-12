using System;
using System.IO;

class Program
{
    static void Main()
    {
        var fileLogger = new FileLoggerAdapter(new Logger());
        fileLogger.Log("Log message");
        fileLogger.Error("Error message");
        fileLogger.Warn("Warning message");
    }
}
