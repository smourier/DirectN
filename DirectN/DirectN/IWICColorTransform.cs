using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("B66F034F-D0E2-40ab-B436-6DE39E321A94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICColorTransform : IWICBitmapSource
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

        // IWICColorTransform
        [PreserveSig]
        HRESULT Initialize(
            IWICBitmapSource pIBitmapSource,
            IWICColorContext pIContextSource,
            IWICColorContext pIContextDest,
            [MarshalAs(UnmanagedType.LPStruct)] Guid pixelFmtDest);
    }
}
