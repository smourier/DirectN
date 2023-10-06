using System;
using System.Collections.Generic;

namespace DirectN
{
    public static class IPropertyBag2Extensions
    {
        public static void Write(this IComObject<IPropertyBag2> bag, IEnumerable<KeyValuePair<string, object>> properties) => Write(bag?.Object, properties);
        public static void Write(this IPropertyBag2 bag, IEnumerable<KeyValuePair<string, object>> properties)
        {
            if (bag == null)
                throw new ArgumentNullException(nameof(bag));

            if (properties == null)
                return;

            foreach (var kv in properties)
            {
                var i = GetIndex(bag, kv.Key);
                if (i < 0) // ?
                    continue;

                // read info
                var values = new object[1];
                var props = new tagPROPBAG2[1];
                props[0].pstrName = kv.Key;
                bag.GetPropertyInfo((uint)i, 1, props, out _).ThrowOnError();
                var value = props[0].ChangeType(kv.Value);
                values[0] = value;
                bag.Write(1, props, values).ThrowOnError();
            }
        }

        private static int GetIndex(IPropertyBag2 bag, string name)
        {
            if (bag == null || name == null)
                return -1;

            bag.CountProperties(out var count);
            for (var i = 0; i < count; i++)
            {
                var props = new tagPROPBAG2[1];
                bag.GetPropertyInfo((uint)i, 1, props, out _).ThrowOnError();
                if (props[0].pstrName.EqualsIgnoreCase(name))
                    return i;
            }
            return -1;
        }
    }
}
