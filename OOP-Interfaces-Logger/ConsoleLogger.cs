using System;

namespace OOP_Interfaces_Logger
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"Console Log: {error}");
        }

        public void LogInfo(string info)
        {
            Console.WriteLine($"Console Log: {info}");;
        }
    }
}