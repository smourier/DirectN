using System;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static class IWICStreamProviderExtensions
    {
        public static IStream GetStream(this IComObject<IWICStreamProvider> writer) => GetStream(writer?.Object);
        public static IStream GetStream(this IWICStreamProvider writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            writer.GetStream(out var stream).ThrowOnError();
            return stream;
        }

        public static WICPersistOptions GetPersistOptions(this IComObject<IWICStreamProvider> writer) => GetPersistOptions(writer?.Object);
        public static WICPersistOptions GetPersistOptions(this IWICStreamProvider writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            writer.GetPersistOptions(out var options).ThrowOnError();
            return (WICPersistOptions)options;
        }

        public static Guid GetPreferredVendorGUID(this IComObject<IWICStreamProvider> writer) => GetPreferredVendorGUID(writer?.Object);
        public static Guid GetPreferredVendorGUID(this IWICStreamProvider writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            writer.GetPreferredVendorGUID(out var guid).ThrowOnError();
            return guid;
        }

        public static void RefreshStream(this IComObject<IWICStreamProvider> writer) => RefreshStream(writer?.Object);
        public static void RefreshStream(this IWICStreamProvider writer)
        {
            if (writer == null)
                throw new ArgumentNullException(nameof(writer));

            writer.RefreshStream().ThrowOnError();
        }
    }
}
