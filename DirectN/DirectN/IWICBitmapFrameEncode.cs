using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000105-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapFrameEncode
    {
        [PreserveSig]
        HRESULT Initialize(IPropertyBag2 pIEncoderOptions);

        [PreserveSig]
        HRESULT SetSize(int uiWidth, int uiHeight);

        [PreserveSig]
        HRESULT SetResolution(double dpiX, double dpiY);

        [PreserveSig]
        HRESULT SetPixelFormat([MarshalAs(UnmanagedType.LPStruct)] Guid pPixelFormat);

        [PreserveSig]
        HRESULT SetColorContexts(int cCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContext);

        [PreserveSig]
        HRESULT SetPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT SetThumbnail(IWICBitmapSource pIThumbnail);

        [PreserveSig]
        HRESULT WritePixels(int lineCount, int cbStride, uint cbBufferSize, IntPtr pbPixels);

        [PreserveSig]
        HRESULT WriteSource(IWICBitmapSource pIBitmapSource, WICRect prc);

        [PreserveSig]
        HRESULT Commit();

        [PreserveSig]
        HRESULT GetMetadataQueryWriter(out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
