using System;

namespace OOP_Interfaces_Logger
{
    public class WindowLogger : ILogger
    {
        public void LogError(string error)
        {
            Console.WriteLine($"Window Log: {error}");
        }

        public void LogInfo(string info)
        {
            Console.WriteLine($"Window Log: {info}"); ;
        }
    }
}