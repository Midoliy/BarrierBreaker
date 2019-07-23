using System;
using System.Collections.Generic;

namespace BarrierBreaker
{
    public static class ActionPreventer
    {
        private static bool Implemented(dynamic obj, string actionName, Type type)
        {
            if (obj is IDictionary<string, object> dict)
                return dict.TryGetValue(actionName, out object o) ? o.GetType() == type
                                                                  : false;
            else
                return false;
        }

        public static bool Implemented(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action));

        public static bool Implemented<T1>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1>));

        public static bool Implemented<T1, T2>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2>));

        public static bool Implemented<T1, T2, T3>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3>));

        public static bool Implemented<T1, T2, T3, T4>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4>));

        public static bool Implemented<T1, T2, T3, T4, T5>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>));
    }
}
