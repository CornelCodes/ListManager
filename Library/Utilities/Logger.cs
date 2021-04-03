using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public static class Logger
    {
        public static void LogNormal(string message)
        {
            Console.WriteLine($"Log: {message} .");
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine($"Warning: {message} !");
        }

        public static void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message} !!");
        }
    }
}
