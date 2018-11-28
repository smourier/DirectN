using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000121-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmap : IWICBitmapSource
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

        // IWICBitmap
        [PreserveSig]
        HRESULT Lock(WICRect prcLock, WICBitmapLockFlags flags, out IWICBitmapLock ppILock);

        [PreserveSig]
        HRESULT SetPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT SetResolution(double dpiX, double dpiY);
    }
}
