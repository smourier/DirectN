using System;

namespace DirectN
{
    public static class IWICFormatConverterInfoExtensions
    {
        public static IComObject<IWICFormatConverter> CreateInstance(this IComObject<IWICFormatConverterInfo> info) => CreateInstance(info?.Object);
        public static IComObject<IWICFormatConverter> CreateInstance(this IWICFormatConverterInfo info)
        {
            if (info == null)
                throw new ArgumentNullException(nameof(info));

            info.CreateInstance(out var converter).ThrowOnError();
            return new ComObject<IWICFormatConverter>(converter);
        }
    }
}
