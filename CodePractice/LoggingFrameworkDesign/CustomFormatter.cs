
namespace CodePractice.LoggingFrameworkDesign
{
    public class CustomFormatter : ILogFormatter
    {
        public string Format(LogMessage message)
        {
            return string.Format(message.Message);
        }
    }
}
