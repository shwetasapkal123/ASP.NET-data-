using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NlogDemo
{
    public class Nlog
    {
        public static readonly Logger logger=LogManager.GetCurrentClassLogger();

        public void LogDebug(string msg)
        {
            logger.Debug(msg);
        }
        public void LogError(string msg)
        {
            logger.Error(msg);
        }
    }
}
