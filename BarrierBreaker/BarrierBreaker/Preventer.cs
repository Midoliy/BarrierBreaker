using System.Collections.Generic;

namespace BarrierBreaker
{
    public static class Preventer
    {
        public static bool Exists(dynamic obj, string name)
        {
            if (obj is IDictionary<string, object> dict)
                return dict.TryGetValue(name, out object _);
            else
                return false;
        }
    }
}
