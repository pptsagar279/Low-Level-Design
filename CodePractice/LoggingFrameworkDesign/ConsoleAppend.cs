
namespace CodePractice.LoggingFrameworkDesign
{
    public class ConsoleAppend : IAppendable
    {
        private ILogFormatter LogFormatter { get; set; }
        public ConsoleAppend(ILogFormatter logFormatter) 
        {
            LogFormatter = logFormatter;
        }
        public void Append(LogMessage message)
        {
            Console.WriteLine(LogFormatter.Format(message));
        }
    }
}
