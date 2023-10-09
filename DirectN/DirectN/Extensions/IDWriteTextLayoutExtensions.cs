using System;

namespace DirectN
{
    public static class IDWriteTextLayoutExtensions
    {
        public static string GetFontFamilyName(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontFamilyName(layout?.Object, currentPosition, range);
        public static string GetFontFamilyName(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            string call(IntPtr ptr)
            {
                layout.GetFontFamilyNameLength(currentPosition, out var len, ptr).ThrowOnError();
                var s = new string('\0', (int)len);
                layout.GetFontFamilyName(currentPosition, s, len + 1, ptr).ThrowOnError();
                return s;
            }
        }

        public static string GetLocaleName(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetLocaleName(layout?.Object, currentPosition, range);
        public static string GetLocaleName(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            string call(IntPtr ptr)
            {
                layout.GetLocaleNameLength(currentPosition, out var len, ptr).ThrowOnError();
                var s = new string('\0', (int)len);
                layout.GetLocaleName(currentPosition, s, len + 1, ptr).ThrowOnError();
                return s;
            }
        }

        public static DWRITE_TEXT_METRICS1 GetMetrics1(this IComObject<IDWriteTextLayout> layout) => GetMetrics1(layout?.Object);
        public static DWRITE_TEXT_METRICS1 GetMetrics1(this IDWriteTextLayout layout)
        {
            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            DWRITE_TEXT_METRICS1 metrics1;
            if (layout is IDWriteTextLayout2 layout2)
            {
                layout2.GetMetrics(out metrics1).ThrowOnError();
            }
            else
            {
                layout.GetMetrics(out var metrics).ThrowOnError();
                metrics1.height = metrics.height;
                metrics1.heightIncludingTrailingWhitespace = metrics.height;
                metrics1.layoutHeight = metrics.layoutHeight;
                metrics1.layoutWidth = metrics.layoutWidth;
                metrics1.left = metrics.left;
                metrics1.lineCount = metrics.lineCount;
                metrics1.maxBidiReorderingDepth = metrics.maxBidiReorderingDepth;
                metrics1.top = metrics.top;
                metrics1.width = metrics.width;
                metrics1.widthIncludingTrailingWhitespace = metrics.widthIncludingTrailingWhitespace;
            }

            // sometimes, there's a bug where widthIncludingTrailingWhitespace is 0 while width is not...
            if (metrics1.widthIncludingTrailingWhitespace < metrics1.width)
            {
                metrics1.widthIncludingTrailingWhitespace = metrics1.width;
            }

            if (metrics1.heightIncludingTrailingWhitespace < metrics1.height)
            {
                metrics1.heightIncludingTrailingWhitespace = metrics1.height;
            }
            return metrics1;
        }

        public static IComObject<IDWriteFontCollection> GetFontCollection(this IComObject<IDWriteTextLayout> layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null) => GetFontCollection(layout?.Object, currentPosition, range);
        public static IComObject<IDWriteFontCollection> GetFontCollection(this IDWriteTextLayout layout, uint currentPosition = 0, DWRITE_TEXT_RANGE? range = null)
        {
            if (layout == null)
                throw new ArgumentNullException(nameof(layout));

            if (range == null)
                return call(IntPtr.Zero);

            using (var mem = new ComMemory(range.Value))
            {
                return call(mem.Pointer);
            }

            ComObject<IDWriteFontCollection> call(IntPtr ptr)
            {
                layout.GetFontCollection(currentPosition, out var coll, ptr).ThrowOnError();
                return new ComObject<IDWriteFontCollection>(coll);
            }
        }
    }
}
