using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5009834F-2D6A-41ce-9E1B-17C5AFF7A782"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapFlipRotator : IWICBitmapSource
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

        // IWICBitmapFlipRotator
        [PreserveSig]
        HRESULT Initialize(IWICBitmapSource pISource, WICBitmapTransformOptions options);
    }
}
