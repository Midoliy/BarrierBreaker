using System.Collections.Generic;
using System.Dynamic;

namespace BarrierBreaker
{
    public static class Dynamics
    {
        public static dynamic dyn(object target) => target.ToExpandoObject();

        public static dynamic ToExpandoObject(this object @this)
        {
            var type = @this.GetType();
            var exobj = new ExpandoObject() as IDictionary<string, object>;

            foreach (var property in type.GetProperties())
                exobj[property.Name] = property.GetValue(@this);

            foreach (var field in type.GetFields())
                exobj[field.Name] = field.GetValue(@this);

            return exobj;
        }
    }
}
