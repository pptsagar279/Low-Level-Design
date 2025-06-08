
namespace CodePractice.LoggingFrameworkDesign
{
    public class FileAppend : IAppendable
    {
        private string FilePath { get; set; }

        private static readonly object obj = new object();

        private ILogFormatter LogFormatter {  get; set; }

        public FileAppend(string path, ILogFormatter logFormatter) 
        {
            LogFormatter = logFormatter;
            FilePath = path;

            if (!File.Exists(FilePath))
            {
                using (File.Create(FilePath)) { };
            }
        }
        public void Append(LogMessage message)
        {
            lock (obj)
            {
                using (StreamWriter writer = new StreamWriter(FilePath, append: true))
                {
                    writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff} - {LogFormatter.Format(message)}");
                }
            }
        }
    }
}
