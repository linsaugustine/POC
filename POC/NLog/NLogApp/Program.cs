using System;
using NLogWriter;

namespace NLogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger NLog = new Logger("");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
