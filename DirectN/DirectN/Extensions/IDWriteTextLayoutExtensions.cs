using System;

namespace DirectN
{
    public static class IDWriteTextLayoutExtensions
    {
        public static string GetFontFamilyName(this IComObject<IDWriteTextLayout> format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontFamilyName(format?.Object, currentPosition, range);
        public static string GetFontFamilyName(this IDWriteTextLayout format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            string call(IntPtr ptr)
            {
                format.GetFontFamilyNameLength(currentPosition, out var len, ptr).ThrowOnError();
                var s = new string('\0', (int)len);
                format.GetFontFamilyName(currentPosition, s, len + 1, ptr).ThrowOnError();
                return s;
            }
        }

        public static string GetLocaleName(this IComObject<IDWriteTextLayout> format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetLocaleName(format?.Object, currentPosition, range);
        public static string GetLocaleName(this IDWriteTextLayout format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            string call(IntPtr ptr)
            {
                format.GetLocaleNameLength(currentPosition, out var len, ptr).ThrowOnError();
                var s = new string('\0', (int)len);
                format.GetLocaleName(currentPosition, s, len + 1, ptr).ThrowOnError();
                return s;
            }
        }

        public static IComObject<IDWriteFontCollection> GetFontCollection(this IComObject<IDWriteTextLayout> format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontCollection(format?.Object, currentPosition, range);
        public static IComObject<IDWriteFontCollection> GetFontCollection(this IDWriteTextLayout format, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            ComObject<IDWriteFontCollection> call(IntPtr ptr)
            {
                format.GetFontCollection(currentPosition, out var coll, ptr).ThrowOnError();
                return new ComObject<IDWriteFontCollection>(coll);
            }
        }
    }
}
