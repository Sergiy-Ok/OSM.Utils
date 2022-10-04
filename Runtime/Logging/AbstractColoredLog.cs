
using UnityEngine;

namespace OSM.Utils.Logging
{
    public abstract class AbstractColoredLog : AbstractLog
    {
        protected abstract Color LogColor { get; }

        protected override string GetLog(string tag, string message)
        {
            string log = string.Empty;
            string[] parts = message.Split('\n');

            if (parts.Length <= 1)
            {
                log = $"<color=#{ColorUtility.ToHtmlStringRGB(LogColor)}><b>{tag}</b> => {message}</color>";
            }
            else
            {
                log = $"<color=#{ColorUtility.ToHtmlStringRGB(LogColor)}><b>{tag}</b> => </color>";
                foreach (string part in parts)
                {
                    if (part != string.Empty)
                    {
                        log += $"<color=#{ColorUtility.ToHtmlStringRGB(LogColor)}>{part}</color>\n";
                    }
                }
            }

            return log;
        }
    }
}
