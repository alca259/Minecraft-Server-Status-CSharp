﻿namespace MSSUtils.Logger
{
    public static class LogConfig
    {
        public static void Configure()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
    }
}