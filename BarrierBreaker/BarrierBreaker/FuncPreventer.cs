using System;
using System.Collections.Generic;

namespace BarrierBreaker
{
    public static class FuncPreventer
    {
        private static bool Implemented(dynamic obj, string funcName, Type type)
        {
            if (obj is IDictionary<string, object> dict)
                return dict.TryGetValue(funcName, out object o) ? o.GetType() == type
                                                                : false;
            else
                return false;
        }

        public static bool Implemented<TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<TResult>));

        public static bool Implemented<T1, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, TResult>));

        public static bool Implemented<T1, T2, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, TResult>));

        public static bool Implemented<T1, T2, T3, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, TResult>));

        public static bool Implemented<T1, T2, T3, T4, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>));

        public static bool Implemented<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(dynamic obj, string actionName)
            => Implemented(obj, actionName, typeof(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>));
    }
}
