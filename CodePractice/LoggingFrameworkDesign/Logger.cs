
namespace CodePractice.LoggingFrameworkDesign
{
    public class Logger
    {
        private LoggerConfig Config { get; set;}
        private Logger()
        {
            Config = new LoggerConfig(new ConsoleAppend(new CustomFormatter()), LogLevel.INFO);
        }

        private class LoggerInstance
        {
            internal static readonly Logger logger = new Logger();
        }

        public static Logger GetLogger()
        {
            return LoggerInstance.logger;
        }

        public void AddConfig(LoggerConfig config)
        {
            Config = config;
        }

        public void Log(string message, LogLevel logLevel)
        {
            var logMessage = new LogMessage(message, logLevel);

            Config.LogAppender.Append(logMessage);
        }

        public void Info(string message)
        {
            Log(message, LogLevel.INFO);
        }

        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Debug(string message)
        {
            Log(message, LogLevel.DEBUG);
        }
    }

}
