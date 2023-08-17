using System;

namespace DirectN
{
    public static class IWICColorContextExtensions
    {
        public static uint GetExifColorSpace(this IComObject<IWICColorContext> bitmap) => GetExifColorSpace(bitmap?.Object);
        public static uint GetExifColorSpace(this IWICColorContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            context.GetExifColorSpace(out var space).ThrowOnError();
            return space;
        }
    }
}
