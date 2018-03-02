using System;
using Logger;

namespace LoggerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\Output\";
            Log log = new Log(filePath);
            log.Exception("First Exception Logged");
            log.Exception("Second Exception Logged");
            Console.WriteLine("File has created for Exception");

            log.Transaction("First Transaction Logged");
            log.Transaction("Second Transaction Logged");
            Console.WriteLine("File has created for Transaction");

            try
            {
                throw new FieldAccessException();
            }
            catch (Exception e)
            {
                log.Exception(e.Message);
                log.Exception(e.Message, e.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
