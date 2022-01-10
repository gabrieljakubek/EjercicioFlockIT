using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEjercicio.Service
{
    public interface ILogServicio
    {
        void LogInfo(string message);
        void LogWarn(string message);
        void LogDebug(Exception exception, string message);
        void LogError(Exception exception, string message);
    }
}
