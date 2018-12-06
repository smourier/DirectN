using System;

namespace DirectN
{
    public static class IDWriteFactoryExtensions
    {
        public static ComObject<IDWriteTextFormat> CreateTextFormat(this ComObject<IDWriteFactory> factory,
            string familyName,
            float size,
            IDWriteFontCollection fonts = null,
            DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
            DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
            DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
            string localeName = null) => CreateTextFormat<IDWriteTextFormat>(factory?.Object, familyName, size, fonts, weight, style, stretch, localeName);

        public static ComObject<T> CreateTextFormat<T>(this ComObject<IDWriteFactory> factory,
            string familyName,
            float size,
            IDWriteFontCollection fonts = null,
            DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
            DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
            DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
            string localeName = null) where T : IDWriteTextFormat => CreateTextFormat<T>(factory?.Object, familyName, size, fonts, weight, style, stretch, localeName);

        public static ComObject<T> CreateTextFormat<T>(this IDWriteFactory factory,
            string familyName,
            float size,
            IDWriteFontCollection fonts = null,
            DWRITE_FONT_WEIGHT weight = DWRITE_FONT_WEIGHT.DWRITE_FONT_WEIGHT_NORMAL,
            DWRITE_FONT_STYLE style = DWRITE_FONT_STYLE.DWRITE_FONT_STYLE_NORMAL,
            DWRITE_FONT_STRETCH stretch = DWRITE_FONT_STRETCH.DWRITE_FONT_STRETCH_NORMAL,
            string localeName = null) where T : IDWriteTextFormat
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (familyName == null)
                throw new ArgumentNullException(nameof(familyName));

            localeName = localeName ?? string.Empty;
            factory.CreateTextFormat(familyName, fonts, weight, style, stretch, size, localeName, out var format).ThrowOnError();
            return new ComObject<T>((T)format);
        }
    }
}
