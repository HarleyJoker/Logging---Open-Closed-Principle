using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging___Open_Closed_Principle
{
    public enum LoggerType
    {
        Console,
        File
    }
    public class Logger
    {
        public void Log (string message, LoggerType type)
        {
            switch (type)
            {
                case LoggerType.Console:
                    Console.WriteLine($"Log to console: {message}");
                    break;
                case LoggerType.File:
                    Console.WriteLine($"Write to file: {message}");
                    // Simulate file logging
                    break;
                    // Adding a new logging method would require modifying this class
            }
        }
    }
}
