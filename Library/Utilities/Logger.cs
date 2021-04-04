using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Utilities
{
    public static class Logger
    {
        static StackFrame CallStack = new StackFrame(1, true);
        public static void LogNormal(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public static void LogWarning(string message)
        {
            Console.WriteLine($"Warning: {message} ! \r\n at {CallStack.GetFileName()} Line:{CallStack.GetFileLineNumber()}");
        }

        public static void LogError(string message)
        {
            Console.WriteLine($"ERROR: {message} !!\r\n at {CallStack.GetFileName()} Line:{CallStack.GetFileLineNumber()}");
        }
    }
}
