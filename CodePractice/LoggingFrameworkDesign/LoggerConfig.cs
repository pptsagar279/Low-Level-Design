
namespace CodePractice.LoggingFrameworkDesign
{
    public class LoggerConfig
    {
        public IAppendable LogAppender { get; set; }

        public LogLevel LogLevel { get; set; }

        public LoggerConfig(IAppendable logAppender, LogLevel logLevel)
        {
            LogAppender = logAppender;
            LogLevel = logLevel;
        }
    }
}
