using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public interface IFileLogger
    {
        void Log(string message);
        void Error(string message);
        void Warn(string message);
    }
