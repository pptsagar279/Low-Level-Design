
namespace CodePractice.LoggingFrameworkDesign
{
    public class LogMessage
    {
        public DateTime DateTime { get; set; }
        public string Message { get; set; }

        public LogLevel LogLevel { get; set; }

        public LogMessage(string message, LogLevel logLevel)  
        {
            DateTime =  DateTime.Now;
            Message = message;
            LogLevel = logLevel;
        }
    }
}
