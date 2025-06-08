
namespace CodePractice.LoggingFrameworkDesign
{
    public class LoggerClient
    {
        public void Process()
        {
            var logger = Logger.GetLogger();

            logger.Info("This is an information message");
            logger.Debug("This is a debug message");
            logger.Error("This is an error message");

            // Changing log level and appender
            LoggerConfig config = new LoggerConfig(new FileAppend("app.log", new CustomFormatter()), LogLevel.DEBUG);
            logger.AddConfig(config);

            logger.Debug("This is a debug message");
            logger.Info("This is an information message");

        }
    }
}
