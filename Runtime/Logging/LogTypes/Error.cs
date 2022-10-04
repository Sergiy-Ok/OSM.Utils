
namespace OSM.Utils.Logging.LogTypes
{
    public class Error : AbstractLog
    {
        protected override void PrintUnityLog(string message)
        {
            UnityEngine.Debug.LogError(message);
        }
    }
}
