using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICFormatConverter : IWICBitmapSource
    {
        // IWICBitmapSource
        [PreserveSig]
        new HRESULT GetSize(out int puiWidth, out int puiHeight);

        [PreserveSig]
        new HRESULT GetPixelFormat(out Guid pPixelFormat);

        [PreserveSig]
        new HRESULT GetResolution(out double pDpiX, out double pDpiY);

        [PreserveSig]
        new HRESULT CopyPalette(IWICPalette pIPalette);

        [PreserveSig]
        new HRESULT CopyPixels(WICRect prc, int cbStride, int cbBufferSize, IntPtr pbBuffer);

        // IWICFormatConverter
        [PreserveSig]
        HRESULT Initialize(IWICBitmapSource pISource, [MarshalAs(UnmanagedType.LPStruct)] Guid dstFormat, WICBitmapDitherType dither, IWICPalette pIPalette, double alphaThresholdPercent, WICBitmapPaletteType paletteTranslate);

        [PreserveSig]
        HRESULT CanConvert([MarshalAs(UnmanagedType.LPStruct)] Guid srcPixelFormat, [MarshalAs(UnmanagedType.LPStruct)] Guid dstPixelFormat, out bool pfCanConvert);
    }
}
