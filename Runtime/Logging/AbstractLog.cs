
using System;

namespace OSM.Utils.Logging
{
    public abstract class AbstractLog
    {
        public virtual void Print(string tag, string message)
        {
            string validMsg = PrepareMsg(message);
            string logMesage = GetLog(tag, validMsg);
            PrintUnityLog(logMesage);
        }

        public virtual void PrintException(Exception exp)
        {
            UnityEngine.Debug.LogError(exp);
        }

        protected virtual string PrepareMsg(string msg)
        {
            string resultMsg = msg;
            return resultMsg;
        }

        protected virtual void PrintUnityLog(string message)
        {
            UnityEngine.Debug.Log(message);
        }

        protected virtual string GetLog(string tag, string message)
        {
            string log = $"<b>{tag}</b> => {message}";
            return log;
        }
    }
}
