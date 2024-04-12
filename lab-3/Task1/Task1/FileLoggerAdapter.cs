using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FileLoggerAdapter : IFileLogger
{
    private readonly Logger logger;

    public FileLoggerAdapter(Logger logger)
    {
        this.logger = logger;
    }

    public void Log(string message)
    {
        logger.Log(message);
    }

    public void Error(string message)
    {
        logger.Error(message);
    }

    public void Warn(string message)
    {
        logger.Warn(message);
    }
}
