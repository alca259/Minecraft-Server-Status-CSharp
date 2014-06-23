using System;
using log4net;
using log4net.Core;

namespace Client.Utils
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Info(string message)
        {
            log.Info(message);
        }

        public static void Warn(string message, Exception exception = null)
        {
            log.Warn(message, exception);
        }

        public static void Error(string message, Exception exception = null)
        {
            log.Error(message, exception);
        }

        public static void Fatal(string message, Exception exception = null)
        {
            log.Fatal(message, exception);
        }

        public static void Debug(string message, Exception exception = null)
        {
            log.Debug(message, exception);
        }

        public static void Log(Type clase, int levelCode, string levelName, string message, Exception exception = null)
        {
            log.Logger.Log(clase, new Level(levelCode, levelName), message, exception);
        }
    }
}
