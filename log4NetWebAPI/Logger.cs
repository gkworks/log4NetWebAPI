using System.Text;
using log4net.Appender;
using log4net.Config;
using log4net.Core;
using log4net.Layout;

namespace log4NetWebAPI
{
    public class Logger
    {
        public static void ConfigureFileAppender(string logFile)
        {
            var fileAppender = GetFileAppender(logFile);
            BasicConfigurator.Configure(fileAppender);
        }

        private static IAppender GetFileAppender(string logFile)
        {
            var layout = new PatternLayout("%date %-5level %logger - %message%newline");
            layout.ActivateOptions(); 

            var appender = new FileAppender
            {
                File = logFile,
                Encoding = Encoding.UTF8,
                Threshold = Level.All,
                Layout = layout
            };

            appender.ActivateOptions();

            return appender;
        }
    }
}