
using UnityEngine;

namespace OSM.Utils.Logging.LogTypes
{
    public class RedMsg : AbstractColoredLog
    {
        protected override Color LogColor => Color.red;
    }
}
