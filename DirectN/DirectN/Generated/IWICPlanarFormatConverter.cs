using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("BEBEE9CB-83B0-4DCC-8132-B0AAA55EAC96"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICPlanarFormatConverter : IWICBitmapSource
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

        // IWICPlanarFormatConverter
        [PreserveSig]
        HRESULT Initialize(
            IWICBitmapSource[] ppPlanes,
            int cPlanes,
            [MarshalAs(UnmanagedType.LPStruct)] Guid dstFormat,
            WICBitmapDitherType dither,
            IWICPalette pIPalette,
            double alphaThresholdPercent,
            WICBitmapPaletteType paletteTranslate);

        [PreserveSig]
        HRESULT CanConvert(
            Guid[] pSrcPixelFormats,
            int cSrcPlanes,
            [MarshalAs(UnmanagedType.LPStruct)] Guid dstPixelFormat,
            out bool pfCanConvert);
    }
}
