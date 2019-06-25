using System;
using System.Collections.Generic;

namespace OOP_Interfaces_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILogger> loggers = new List<ILogger>();

            loggers.Add(new DbLogger());
            loggers.Add(new WindowLogger());
            loggers.Add(new ConsoleLogger());

            foreach (var logger in loggers)
            {
                logger.LogInfo("This is an info");
                logger.LogError("This is an error");
            }
        }
    }
}
