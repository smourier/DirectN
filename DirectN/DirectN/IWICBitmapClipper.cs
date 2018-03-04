using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("E4FBCF03-223D-4e81-9333-D635556DD1B5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapClipper : IWICBitmapSource
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

        // IWICBitmapClipper
        [PreserveSig]
        HRESULT Initialize(IWICBitmapSource pISource, WICRect prc);
    }
}
