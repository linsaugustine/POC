using System;
using System.IO;

namespace Logger
{
    public class Log
    {
        private readonly string filePath;

        public Log(string filePath)
        {
            this.filePath = filePath;
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
            string combinedFilePath = Path.Combine(this.filePath, string.Format("{0}_{1}.log", fileName, DateTime.Now.ToString("MM-dd-yyyy")));
            
            if (File.Exists(combinedFilePath))
            {
                using (StreamWriter writer = File.AppendText(combinedFilePath))
                {
                   WriteLine(writer, message1, message2);
                }
            }
            else
            {
                using (StreamWriter writer = File.CreateText((combinedFilePath)))
                {
                   WriteLine(writer, message1, message2);
                }
            }
        }

        private async void WriteLine(StreamWriter writer, string message1, string message2 = "")
        {
            await writer.WriteLineAsync(message1);

            if(!string.IsNullOrEmpty(message2))
            {
                await writer.WriteLineAsync(message2);
            }
        }
    }
}
