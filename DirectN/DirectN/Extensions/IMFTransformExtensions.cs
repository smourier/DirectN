using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class IMFTransformExtensions
    {
        public static bool IsBuiltinEncoder(this ComObject<IMFTransform> input) => IsBuiltinEncoder(input?.Object);
        public static bool IsBuiltinEncoder(this IMFTransform input) => input is IMFObjectInformation;

        public static ComObject<IMFAttributes> GetAttributes(this ComObject<IMFTransform> input) => GetAttributes(input?.Object);
        public static ComObject<IMFAttributes> GetAttributes(this IMFTransform input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (input.GetAttributes(out var atts).IsError)
                return null;

            return new ComObject<IMFAttributes>(atts);
        }

        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this ComObject<IMFTransform> input) => EnumerateAttributes(input?.Object);
        public static IEnumerable<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>> EnumerateAttributes(this IMFTransform input)
        {
            if (input == null || input.GetAttributes(out var atts).IsError)
                return Enumerable.Empty<KeyValuePair<Guid, _MF_ATTRIBUTE_TYPE>>();

            return atts.Enumerate();
        }
    }
}
