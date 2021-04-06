using System;

namespace IntroToWix.Common
{
    public class Log
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>();
        public static Log Instance => instance.Value;

        public void WriteLine(string format, params object[] arg) => Console.WriteLine(format, arg);
    }
}