using System;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace LogWritter
{
    public class Log
    {
        private Logger logger;
        public Log(string filePath, string fileName)
        {
            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);
            fileTarget.FileName = string.Format("{0}{1}.txt", filePath, fileName); //"${basedir}/file.txt";
            fileTarget.Layout = "${message}";
            var fileRule = new LoggingRule("*", LogLevel.Debug, fileTarget);
            config.LoggingRules.Add(fileRule);
            LogManager.Configuration = config;
            logger = LogManager.GetLogger("Transactions/Exceptions");
        }

        public void Transaction (string message)
        {
            this.logger.Info(string.Format("Info: {0}", message));
        }

        public void Exception (string message)
        {
            this.logger.Error(string.Format("Error: {0}", message));
        }

        public void Exception (string message, string stackTrace)
        {
            this.logger.Error(string.Format("Error: {0} -> Stack Trace: {1} ", message, stackTrace));
        }
    }
}
