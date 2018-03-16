using System;
using LogWritter;

namespace LogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\..\Output\";
            string fileName = "Transaction";
            Log log = new Log(filePath, fileName);
            Console.WriteLine("Logging Transaction Message");
            log.Transaction("Transaction Message Logged");
            Console.WriteLine("Logging Exception Message");
            Console.WriteLine("Logging Exception Message with Stack Trace");
            try 
            {
                throw new ArgumentNullException();
            }
            catch (Exception e)
            {
                log.Exception(e.Message);
                log.Exception(e.Message, e.StackTrace);
            }

            Console.WriteLine("Started");

            for(int i = 0; i < 10000; i++)
            {
                log.Transaction("Loop test started: " + i);
            }

            Console.WriteLine("Completed");
            Console.ReadLine();
        }
    }
}
