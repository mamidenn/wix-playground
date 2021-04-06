using IntroToWix.Common;
using System;
using System.Reflection;

namespace IntroToWix
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var log = Log.Instance;
            log.WriteLine("Hello!");
            log.WriteLine($"This is version {Assembly.GetExecutingAssembly().GetName().Version}.");
            Console.ReadLine();
        }
    }
}