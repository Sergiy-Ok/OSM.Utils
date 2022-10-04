
using OSM.Utils.Logging.LogTypes;
using System;

namespace OSM.Utils.Logging
{
    public static class OSMLogger
    {
        public static void Log<T>(this object context, string message) where T: AbstractLog, new()
        {
            T log = new T();
            string tag = context.GetType().Name.ToString();
            log.Print(tag, message);
        }

        public static void LogException(Exception exp)
        {
            Default log = new Default();
            log.PrintException(exp);
        }

        public static void Log(this object context, string message)
        {
            Default log = new Default();
            string tag = context.GetType().Name.ToString();
            log.Print(tag, message);
        }

        public static void Log(string contextName, string message)
        {
            Default log = new Default();
            string tag = contextName;
            log.Print(tag, message);
        }

        public static void Log<T>(string contextName, string message) where T : AbstractLog, new()
        {
            T log = new T();
            string tag = contextName;
            log.Print(tag, message);
        }
    }
}