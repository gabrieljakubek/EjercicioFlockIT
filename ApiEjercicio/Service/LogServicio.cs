using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Service
{
    public class LogServicio : ILogServicio
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(Exception exception, string message)
        {
            logger.Debug(exception,message);
        }
        public void LogError(Exception exception, string message)
        {
            logger.Error(exception, message);
        }
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
