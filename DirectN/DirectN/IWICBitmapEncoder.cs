using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("00000103-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapEncoder
    {
        [PreserveSig]
        HRESULT Initialize(IStream pIStream, WICBitmapEncoderCacheOption cacheOption);

        [PreserveSig]
        HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        HRESULT GetEncoderInfo(out IWICBitmapEncoderInfo ppIEncoderInfo);

        [PreserveSig]
        HRESULT SetColorContexts(int cCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContext);

        [PreserveSig]
        HRESULT SetPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT SetThumbnail(IWICBitmapSource pIThumbnail);

        [PreserveSig]
        HRESULT SetPreview(IWICBitmapSource pIPreview);

        [PreserveSig]
        HRESULT CreateNewFrame(out IWICBitmapFrameEncode ppIFrameEncode, out IPropertyBag2 encoderOptions);

        [PreserveSig]
        HRESULT Commit();

        [PreserveSig]
        HRESULT GetMetadataQueryWriter(out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
