using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class IMFTransformExtensions
    {
        public static bool IsBuiltinEncoder(this ComObject<IMFTransform> obj) => IsBuiltinEncoder(obj?.Object);
        public static bool IsBuiltinEncoder(this IMFTransform obj) => obj is IMFObjectInformation;

        public static ComObject<IMFAttributes> GetAttributes(this ComObject<IMFTransform> obj) => GetAttributes(obj?.Object);
        public static ComObject<IMFAttributes> GetAttributes(this IMFTransform obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            if (obj.GetAttributes(out var atts).IsError)
                return null;

            return new ComObject<IMFAttributes>(atts);
        }

        public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this ComObject<IMFTransform> obj) => EnumerateAttributes(obj?.Object);
        public static IEnumerable<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this IMFTransform obj)
        {
            if (obj == null || obj.GetAttributes(out var atts).IsError)
                return Enumerable.Empty<KeyValuePair<Guid, MF_ATTRIBUTE_TYPE>>();

            return atts.Enumerate();
        }
    }
}
