using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class IMFTransformExtensions
    {
        public static bool IsBuiltinEncoder(this IComObject<IMFTransform> obj) => IsBuiltinEncoder(obj?.Object);
        public static bool IsBuiltinEncoder(this IMFTransform obj) => obj is IMFObjectInformation;

        public static IComObject<IMFAttributes> GetAttributes(this IComObject<IMFTransform> obj) => GetAttributes(obj?.Object);
        public static IComObject<IMFAttributes> GetAttributes(this IMFTransform obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetAttributes(out var atts).IsError)
                return null;

            return new ComObject<IMFAttributes>(atts);
        }

        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this IComObject<IMFTransform> obj) => EnumerateAttributes(obj?.Object);
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this IMFTransform obj)
        {
            if (obj == null || obj.GetAttributes(out var atts).IsError)
                return Enumerable.Empty<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>>();

            return atts.Enumerate();
        }
    }
}
