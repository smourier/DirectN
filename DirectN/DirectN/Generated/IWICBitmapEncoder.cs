// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(3285,5)
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("00000103-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapEncoder
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] __RPC__in_opt */ IStream pIStream, /* [in] */ WICBitmapEncoderCacheOption cacheOption);
        
        [PreserveSig]
        HRESULT GetContainerFormat(/* [out] __RPC__out */ out Guid pguidContainerFormat);
        
        [PreserveSig]
        HRESULT GetEncoderInfo(/* [out] __RPC__deref_out_opt */ out IWICBitmapEncoderInfo ppIEncoderInfo);
        
        [PreserveSig]
        HRESULT SetColorContexts(/* [in] */ int cCount, /* [size_is][in] __RPC__in_ecount_full(cCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContext);
        
        [PreserveSig]
        HRESULT SetPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        HRESULT SetThumbnail(/* [in] __RPC__in_opt */ IWICBitmapSource pIThumbnail);
        
        [PreserveSig]
        HRESULT SetPreview(/* [in] __RPC__in_opt */ IWICBitmapSource pIPreview);
        
        [PreserveSig]
        HRESULT CreateNewFrame(/* [out] __RPC__deref_out_opt */ out IWICBitmapFrameEncode ppIFrameEncode, /* [unique][out][in] __RPC__deref_opt_inout_opt */ out IPropertyBag2 ppIEncoderOptions);
        
        [PreserveSig]
        HRESULT Commit();
        
        [PreserveSig]
        HRESULT GetMetadataQueryWriter(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryWriter ppIMetadataQueryWriter);
    }
}
