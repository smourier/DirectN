using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class IWICBitmapFrameDecodeExtensions
    {
        public static T GetMetadataValue<T>(this IComObject<IWICBitmapFrameDecode> decode, string name, T defaultValue = default) => GetMetadataValue(decode?.Object, name, defaultValue);
        public static T GetMetadataValue<T>(this IWICBitmapFrameDecode bitmap, string name, T defaultValue = default)
        {
            if (!TryGetMetadataValue<T>(bitmap, name, out var obj))
                return defaultValue;

            return obj;
        }

        public static bool TryGetMetadataValue<T>(this IComObject<IWICBitmapFrameDecode> decode, string name, out T value) => TryGetMetadataValue(decode?.Object, name, out value);
        public static bool TryGetMetadataValue<T>(this IWICBitmapFrameDecode bitmap, string name, out T value)
        {
            value = default;
            if (!TryGetMetadataValue(bitmap, name, out object obj))
                return false;

            return Conversions.TryChangeType(obj, out value);
        }

        public static bool TryGetMetadataValue(this IComObject<IWICBitmapFrameDecode> decode, string name, out object value) => TryGetMetadataValue(decode?.Object, name, out value);
        public static bool TryGetMetadataValue(this IWICBitmapFrameDecode decode, string name, out object value)
        {
            if (decode == null)
                throw new ArgumentNullException(nameof(decode));

            if (name == null)
                throw new ArgumentNullException(nameof(decode));

            value = null;
            if (decode.GetMetadataQueryReader(out var reader).IsError)
                return false;

            using (var pv = new PropVariant())
            {
                if (reader.GetMetadataByName(name, pv).IsError)
                    return false;

                value = pv.Value;
                return true;
            }
        }

        public static IReadOnlyList<IComObject<IWICColorContext>> GetColorContexts(this IComObject<IWICBitmapFrameDecode> decode) => GetColorContexts(decode?.Object);
        public static IReadOnlyList<IComObject<IWICColorContext>> GetColorContexts(this IWICBitmapFrameDecode decode)
        {
            if (decode == null)
                throw new ArgumentNullException(nameof(decode));

            decode.GetColorContexts(0, null, out var count).ThrowOnError();
            if (count == 0)
                return Array.Empty<IComObject<IWICColorContext>>();

            var contexts = new IComObject<IWICColorContext>[count];
            for (var i = 0; i < contexts.Length; i++)
            {
                contexts[i] = WICFunctions.CreateColorContext();
            }

            decode.GetColorContexts((int)count, contexts.Select(c => c.Object).ToArray(), out _).ThrowOnError();
            return contexts;
        }
    }
}
