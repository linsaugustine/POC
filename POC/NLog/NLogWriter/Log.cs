using NLog;

namespace NLogWriter
{
    public class Log
    {
        static Logger _logWriter;
        public static string _filepath;
        public static string _filename;

        public static Logger Write
        {
            get
            {
                Path = _filepath;
                Name = _filename;
                if (_logWriter != null)
                    return _logWriter;
                _logWriter = LogManager.GetCurrentClassLogger();
                return _logWriter;
            }
        }

        public static string Path
        {
            set
            {
                if (_filepath == null)
                    _filepath = @"..\Logs\";
                LogManager.Configuration.Variables["logPath"] = _filepath;
            }
        }
        public static string Name
        {
            set
            {
                if (_filename == null)
                    _filename = "${cached:${date:format=yyyy-MM-dd HH_mm}}.log";
                LogManager.Configuration.Variables["logName"] = _filename;
            }
        }

    }
}
