
namespace OSM.Utils.Logging.LogTypes
{
    public class Wary : AbstractLog
    {
        protected override void PrintUnityLog(string message)
        {
            UnityEngine.Debug.LogWarning(message);
        }
    }
}
