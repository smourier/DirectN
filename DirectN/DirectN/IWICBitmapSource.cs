using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000120-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapSource
    {
        [PreserveSig]
        HRESULT GetSize(out int puiWidth, out int puiHeight);

        [PreserveSig]
        HRESULT GetPixelFormat(out Guid pPixelFormat);

        [PreserveSig]
        HRESULT GetResolution(out double pDpiX, out double pDpiY);

        [PreserveSig]
        HRESULT CopyPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT CopyPixels(WICRect prc, int cbStride, int cbBufferSize, IntPtr pbBuffer);
    }
}
