using System;

namespace DirectN
{
    public static class IWICColorTransformExtensions
    {
        public static void Initialize(this IComObject<IWICColorTransform> transform, IComObject<IWICBitmapSource> source, IComObject<IWICColorContext> sourceColorContext, IComObject<IWICColorContext> destinationColorContext, Guid destinationPixelFormat) => Initialize(transform?.Object, source?.Object, sourceColorContext?.Object, destinationColorContext?.Object, destinationPixelFormat);
        public static void Initialize(this IWICColorTransform transform, IWICBitmapSource source, IWICColorContext sourceColorContext, IWICColorContext destinationColorContext, Guid destinationPixelFormat)
        {
            if (transform == null)
                throw new ArgumentNullException(nameof(transform));

            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (sourceColorContext == null)
                throw new ArgumentNullException(nameof(sourceColorContext));

            if (destinationColorContext == null)
                throw new ArgumentNullException(nameof(destinationColorContext));

            transform.Initialize(source, sourceColorContext, destinationColorContext, destinationPixelFormat).ThrowOnError();
        }
    }
}
