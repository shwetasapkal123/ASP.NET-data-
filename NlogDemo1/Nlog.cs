using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo1
{
    public class Nlog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogError(string msg)
        {
            logger.Error(msg);  
        }

        public void LogDebug(string msg)
        {
            logger.Debug(msg);
        }
        public void LogInfo(string msg)
        {
            logger.Info(msg);
        }
        public void LogWarn(string msg)
        {
            logger.Warn(msg);
        }
    }
}
