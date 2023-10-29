using System;

namespace DirectN
{
    public static class IDWriteFontSetBuilderExtensions
    {
        public static IComObject<IDWriteFontSet> CreateFontSet(this IComObject<IDWriteFontSetBuilder1> builder) => CreateFontSet<IDWriteFontSet>(builder);
        public static IComObject<T> CreateFontSet<T>(this IComObject<IDWriteFontSetBuilder1> builder) where T : IDWriteFontSet => CreateFontSet<T>(builder?.Object);
        public static IComObject<T> CreateFontSet<T>(this IDWriteFontSetBuilder1 builder) where T : IDWriteFontSet
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            builder.CreateFontSet(out var set).ThrowOnError();
            return new ComObject<T>((T)set);
        }
    }
}
