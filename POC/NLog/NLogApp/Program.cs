using System;
using NLogWriter;

namespace NLogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Log.Write.Info("NLog File writing demo");
            Log.Write.Error("NLog Error Log written");
            Console.ReadLine();
        }
    }
}
