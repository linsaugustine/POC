using System;
using NLog;

namespace NLogWriter
{
    public class Logger
    {
        public Logger(string filePath)
        {
            var logger = LogManager.LoadConfiguration("nlog.config").GetCurrentClassLogger();
            logger.Info("Linson Writes");
        }

        public void Transaction (string message)
        {
            this.LogProcess("Transaction", message);
        }

        public void Exception (string message)
        {
            this.LogProcess("Exception", message);
        }

        public void Exception (string message, string stackTrace)
        {
            this.LogProcess("Exception", message, stackTrace);
        }

        private void LogProcess(string fileName, string message1, string message2 = "")
        {
            
        }
    }
}
