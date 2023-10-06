using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    public static class IWICImagingFactoryExtensions
    {
        public static IComObject<IWICPalette> CreatePalette(this IComObject<IWICImagingFactory> factory) => CreatePalette(factory?.Object);
        public static IComObject<IWICPalette> CreatePalette(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreatePalette(out var value).ThrowOnError();
            return new ComObject<IWICPalette>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmap(this IComObject<IWICImagingFactory> factory, int width, int height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => CreateBitmap(factory?.Object, width, height, pixelFormat, option);
        public static IComObject<IWICBitmap> CreateBitmap(this IWICImagingFactory factory, int width, int height, Guid pixelFormat, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmap((uint)width, (uint)height, pixelFormat, option, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICBitmapClipper> CreateBitmapClipper(this IComObject<IWICImagingFactory> factory) => CreateBitmapClipper(factory?.Object);
        public static IComObject<IWICBitmapClipper> CreateBitmapClipper(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmapClipper(out var value).ThrowOnError();
            return new ComObject<IWICBitmapClipper>(value);
        }

        public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator(this IComObject<IWICImagingFactory> factory) => CreateBitmapFlipRotator(factory?.Object);
        public static IComObject<IWICBitmapFlipRotator> CreateBitmapFlipRotator(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmapFlipRotator(out var value).ThrowOnError();
            return new ComObject<IWICBitmapFlipRotator>(value);
        }

        public static IComObject<IWICBitmapScaler> CreateBitmapScaler(this IComObject<IWICImagingFactory> factory) => CreateBitmapScaler(factory?.Object);
        public static IComObject<IWICBitmapScaler> CreateBitmapScaler(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmapScaler(out var value).ThrowOnError();
            return new ComObject<IWICBitmapScaler>(value);
        }

        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(this IComObject<IWICImagingFactory> factory, string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromFilename(factory?.Object, fileName, guidVendor, desiredAccess, metadataOptions);
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFilename(this IWICImagingFactory factory, string fileName, Guid? guidVendor = null, FileAccess desiredAccess = FileAccess.Read, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (fileName == null)
                throw new ArgumentNullException(nameof(factory));

            const uint GENERIC_READ = 0x80000000;
            const uint GENERIC_WRITE = 0x40000000;
            using (var guid = new ComMemory(guidVendor))
            {
                uint acc = 0;
                if (desiredAccess.HasFlag(FileAccess.Read))
                {
                    acc |= GENERIC_READ;
                }

                if (desiredAccess.HasFlag(FileAccess.Write))
                {
                    acc |= GENERIC_WRITE;
                }

                factory.CreateDecoderFromFilename(fileName, guid.Pointer, acc, metadataOptions, out var value).ThrowOnError();
                return new ComObject<IWICBitmapDecoder>(value);
            }
        }

        public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(this IComObject<IWICImagingFactory> factory, IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromStream(factory?.Object, stream, guidVendor, metadataOptions);
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromStream(this IWICImagingFactory factory, IStream stream, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (stream == null)
                throw new ArgumentNullException(nameof(factory));

            using (var guid = new ComMemory(guidVendor))
            {
                factory.CreateDecoderFromStream(stream, guid.Pointer, metadataOptions, out var value).ThrowOnError();
                return new ComObject<IWICBitmapDecoder>(value);
            }
        }

        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(this IComObject<IWICImagingFactory> factory, IntPtr handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand) => CreateDecoderFromFileHandle(factory?.Object, handle, guidVendor, metadataOptions);
        public static IComObject<IWICBitmapDecoder> CreateDecoderFromFileHandle(this IWICImagingFactory factory, IntPtr handle, Guid? guidVendor = null, WICDecodeOptions metadataOptions = WICDecodeOptions.WICDecodeMetadataCacheOnDemand)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            using (var guid = new ComMemory(guidVendor))
            {
                factory.CreateDecoderFromFileHandle(handle, guid.Pointer, metadataOptions, out var value).ThrowOnError();
                return new ComObject<IWICBitmapDecoder>(value);
            }
        }

        public static IComObject<IEnumUnknown> CreateComponentEnumerator(this IComObject<IWICImagingFactory> factory, WICComponentType type = WICComponentType.WICAllComponents, WICComponentEnumerateOptions options = WICComponentEnumerateOptions.WICComponentEnumerateDefault) => CreateComponentEnumerator(factory?.Object, type, options);
        public static IComObject<IEnumUnknown> CreateComponentEnumerator(this IWICImagingFactory factory, WICComponentType type = WICComponentType.WICAllComponents, WICComponentEnumerateOptions options = WICComponentEnumerateOptions.WICComponentEnumerateDefault)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateComponentEnumerator((uint)type, (uint)options, out var value).ThrowOnError();
            return new ComObject<IEnumUnknown>(value);
        }

        public static IComObject<IWICBitmapEncoder> CreateEncoder(this IComObject<IWICImagingFactory> factory, Guid containerFormat) => CreateEncoder(factory?.Object, containerFormat);
        public static IComObject<IWICBitmapEncoder> CreateEncoder(this IWICImagingFactory factory, Guid containerFormat)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateEncoder(containerFormat, IntPtr.Zero, out var value).ThrowOnError();
            return new ComObject<IWICBitmapEncoder>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(this IComObject<IWICImagingFactory> factory, IntPtr bitmapHandle, IntPtr paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha) => CreateBitmapFromHBITMAP(factory?.Object, bitmapHandle, paletteHandle, options);
        public static IComObject<IWICBitmap> CreateBitmapFromHBITMAP(this IWICImagingFactory factory, IntPtr bitmapHandle, IntPtr paletteHandle, WICBitmapAlphaChannelOption options = WICBitmapAlphaChannelOption.WICBitmapUseAlpha)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmapFromHBITMAP(bitmapHandle, paletteHandle, options, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmapFromHICON(this IComObject<IWICImagingFactory> factory, IntPtr iconHandle) => CreateBitmapFromHICON(factory?.Object, iconHandle);
        public static IComObject<IWICBitmap> CreateBitmapFromHICON(this IWICImagingFactory factory, IntPtr iconHandle)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateBitmapFromHICON(iconHandle, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmapFromMemory(this IComObject<IWICImagingFactory> factory, int width, int height, Guid pixelFormat, int stride, byte[] buffer) => CreateBitmapFromMemory(factory?.Object, width, height, pixelFormat, stride, buffer);
        public static IComObject<IWICBitmap> CreateBitmapFromMemory(this IWICImagingFactory factory, int width, int height, Guid pixelFormat, int stride, byte[] buffer)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            factory.CreateBitmapFromMemory((uint)width, (uint)height, pixelFormat, (uint)stride, buffer.Length, buffer, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmapFromSource(this IComObject<IWICImagingFactory> factory, IComObject<IWICBitmapSource> source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache) => CreateBitmapFromSource(factory?.Object, source?.Object, option);
        public static IComObject<IWICBitmap> CreateBitmapFromSource(this IWICImagingFactory factory, IWICBitmapSource source, WICBitmapCreateCacheOption option = WICBitmapCreateCacheOption.WICBitmapNoCache)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (source == null)
                throw new ArgumentNullException(nameof(source));

            factory.CreateBitmapFromSource(source, option, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(this IComObject<IWICImagingFactory> factory, IComObject<IWICBitmapSource> source, int x, int y, int width, int height) => CreateBitmapFromSourceRect(factory?.Object, source?.Object, x, y, width, height);
        public static IComObject<IWICBitmap> CreateBitmapFromSourceRect(this IWICImagingFactory factory, IWICBitmapSource source, int x, int y, int width, int height)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (source == null)
                throw new ArgumentNullException(nameof(source));

            factory.CreateBitmapFromSourceRect(source, (uint)x, (uint)y, (uint)width, (uint)height, out var value).ThrowOnError();
            return new ComObject<IWICBitmap>(value);
        }

        public static IComObject<IWICColorContext> CreateColorContext(this IComObject<IWICImagingFactory> factory) => CreateColorContext(factory?.Object);
        public static IComObject<IWICColorContext> CreateColorContext(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateColorContext(out var value).ThrowOnError();
            return new ComObject<IWICColorContext>(value);
        }

        public static IComObject<IWICColorTransform> CreateColorTransformer(this IComObject<IWICImagingFactory> factory) => CreateColorTransformer(factory?.Object);
        public static IComObject<IWICColorTransform> CreateColorTransformer(this IWICImagingFactory factory)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            factory.CreateColorTransformer(out var value).ThrowOnError();
            return new ComObject<IWICColorTransform>(value);
        }

        public static IEnumerable<IComObject<IWICComponentInfo>> EnumerateComponents(this IWICImagingFactory factory, WICComponentType type, WICComponentEnumerateOptions options)
        {
            using (var enumerator = factory.CreateComponentEnumerator(type, options))
            {
                do
                {
                    var o = new object[1];
                    var fetched = 0;
                    enumerator.Object.Next(1, o, ref fetched);
                    if (fetched != 1)
                        break;

                    if (o[0] is IWICComponentInfo info)
                        yield return new ComObject<IWICComponentInfo>(info);
                }
                while (true);
            }
        }

        public static IComObject<IWICImageEncoder> CreateImageEncoder(this IComObject<IWICImagingFactory2> factory, IComObject<ID2D1Device> device) => CreateImageEncoder(factory?.Object, device?.Object);
        public static IComObject<IWICImageEncoder> CreateImageEncoder(this IWICImagingFactory2 factory, ID2D1Device device)
        {
            if (factory == null)
                throw new ArgumentNullException(nameof(factory));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            factory.CreateImageEncoder(device, out var value).ThrowOnError();
            return new ComObject<IWICImageEncoder>(value);
        }
    }
}
