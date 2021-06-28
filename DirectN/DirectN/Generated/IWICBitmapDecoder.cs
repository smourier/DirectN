// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(3879,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("9edde9e7-8dee-47ea-99df-e6faf2ed44bf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapDecoder
    {
        [PreserveSig]
        HRESULT QueryCapability(/* [in] __RPC__in_opt */ IStream pIStream, /* [out] __RPC__out */ out uint pdwCapability);
        
        [PreserveSig]
        HRESULT Initialize(/* [in] __RPC__in_opt */ IStream pIStream, /* [in] */ WICDecodeOptions cacheOptions);
        
        [PreserveSig]
        HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        HRESULT GetDecoderInfo(/* [out] __RPC__deref_out_opt */ out IWICBitmapDecoderInfo ppIDecoderInfo);
        
        [PreserveSig]
        HRESULT CopyPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        HRESULT GetMetadataQueryReader(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryReader ppIMetadataQueryReader);
        
        [PreserveSig]
        HRESULT GetPreview(/* [out] __RPC__deref_out_opt */ out IWICBitmapSource ppIBitmapSource);
        
        [PreserveSig]
        HRESULT GetColorContexts(/* [in] */ int cCount, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContexts, /* [out] __RPC__out */ out uint pcActualCount);
        
        [PreserveSig]
        HRESULT GetThumbnail(/* [out] __RPC__deref_out_opt */ out IWICBitmapSource ppIThumbnail);
        
        [PreserveSig]
        HRESULT GetFrameCount(/* [out] __RPC__out */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetFrame(/* [in] */ uint index, /* [out] __RPC__deref_out_opt */ out IWICBitmapFrameDecode ppIBitmapFrame);
    }
}
