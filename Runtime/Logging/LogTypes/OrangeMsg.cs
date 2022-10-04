
using UnityEngine;

namespace OSM.Utils.Logging.LogTypes
{
    public class OrangeMsg : AbstractColoredLog
    {
        protected override Color LogColor => new Color(1f, 0.75f, 0f);
    }
}
