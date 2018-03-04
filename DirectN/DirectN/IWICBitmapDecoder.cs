using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [Guid("9EDDE9E7-8DEE-47ea-99DF-E6FAF2ED44BF"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICBitmapDecoder
    {
        [PreserveSig]
        HRESULT QueryCapability(IStream pIStream, out WICBitmapDecoderCapabilities pdwCapability);

        [PreserveSig]
        HRESULT Initialize(IStream pIStream, WICDecodeOptions cacheOptions);

        [PreserveSig]
        HRESULT GetContainerFormat(out Guid pguidContainerFormat);

        [PreserveSig]
        HRESULT GetDecoderInfo(out IWICBitmapDecoderInfo ppIDecoderInfo);

        [PreserveSig]
        HRESULT CopyPalette(IWICPalette pIPalette);

        [PreserveSig]
        HRESULT GetMetadataQueryReader(out IWICMetadataQueryReader ppIMetadataQueryReader);

        [PreserveSig]
        HRESULT GetPreview(out IWICBitmapSource ppIBitmapSource);

        [PreserveSig]
        HRESULT GetColorContexts(int cCount, [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContexts, out int pcActualCount);

        [PreserveSig]
        HRESULT GetThumbnail(out IWICBitmapSource ppIThumbnail);

        [PreserveSig]
        HRESULT GetFrameCount(out int pCount);

        [PreserveSig]
        HRESULT GetFrame(int index, out IWICBitmapFrameDecode ppIBitmapFrame);
    }
}
