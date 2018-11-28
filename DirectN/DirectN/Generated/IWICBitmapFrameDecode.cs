using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3B16811B-6A43-4ec9-A813-3D930C13B940"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapFrameDecode : IWICBitmapSource
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

        // IWICBitmapFrameDecode
        [PreserveSig]
        HRESULT GetMetadataQueryReader(out IWICMetadataQueryReader ppIMetadataQueryReader);

        [PreserveSig]
        HRESULT GetColorContexts(int cCount, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] pIColorContexts, out int pcActualCount);

        [PreserveSig]
        HRESULT GetThumbnail(out IWICBitmapSource ppIThumbnail);
    }
}
