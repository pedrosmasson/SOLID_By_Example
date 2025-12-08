using System;

namespace SOLID_By_Example.S_SingleResponsability.After.Loggers
{
    public class ConsoleLogger
    {
        public void Log(string message) => Console.WriteLine("[LOG] " + message);
        public void Error(string message) => Console.WriteLine("[ERROR] " + message);
        public void Warn(string message) => Console.WriteLine("[WARN] " + message);
    }
}