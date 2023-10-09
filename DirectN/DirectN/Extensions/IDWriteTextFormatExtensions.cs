using System;

namespace DirectN
{
    public static class IDWriteTextFormatExtensions
    {
        public static string GetFontFamilyName(this IComObject<IDWriteTextFormat> format) => GetFontFamilyName(format?.Object);
        public static string GetFontFamilyName(this IDWriteTextFormat format)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            var len = format.GetFontFamilyNameLength();
            var s = new string('\0', (int)len);
            format.GetFontFamilyName(s, len + 1).ThrowOnError();
            return s;
        }

        public static string GetLocaleName(this IComObject<IDWriteTextFormat> format) => GetLocaleName(format?.Object);
        public static string GetLocaleName(this IDWriteTextFormat format)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            var len = format.GetLocaleNameLength();
            var s = new string('\0', (int)len);
            format.GetLocaleName(s, len + 1).ThrowOnError();
            return s;
        }

        public static IComObject<IDWriteFontCollection> GetFontCollection(this IComObject<IDWriteTextFormat> format) => GetFontCollection(format?.Object);
        public static IComObject<IDWriteFontCollection> GetFontCollection(this IDWriteTextFormat format)
        {
            if (format == null)
                throw new ArgumentNullException(nameof(format));

            format.GetFontCollection(out var collection).ThrowOnError();
            return new ComObject<IDWriteFontCollection>(collection);
        }
    }
}
