using System;

namespace OOP_Interfaces_Logger
{
    public class DbLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"Database Log: {error}");
        }

        public void LogInfo(string info)
        {
            Console.WriteLine($"Database Log: {info}"); ;
        }
    }
}