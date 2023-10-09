using Contracts;
using NLog;

namespace LoggerService;

public class LoggerManager:ILoggerManager
{
    private static Logger logger = LogManager.GetCurrentClassLogger();

    public LoggerManager()
    {
        
    }
    
    public void LogInfo(string message) => logger.Debug(message);

    public void LogWarn(string message) => logger.Error(message);
    public void LogDebug(string message) => logger.Info(message);

    public void LogError(string message) => logger.Warn(message);

}