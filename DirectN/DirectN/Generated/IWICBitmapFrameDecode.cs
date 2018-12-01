// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(4300,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3b16811b-6a43-4ec9-a813-3d930c13b940"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapFrameDecode : IWICBitmapSource
    {
        // IWICBitmapSource
        [PreserveSig]
        new HRESULT GetSize(/* [out] __RPC__out */ out uint puiWidth, /* [out] __RPC__out */ out uint puiHeight);
        
        [PreserveSig]
        new HRESULT GetPixelFormat(/* [out] __RPC__out */ out Guid pPixelFormat);
        
        [PreserveSig]
        new HRESULT GetResolution(/* [out] __RPC__out */ out double pDpiX, /* [out] __RPC__out */ out double pDpiY);
        
        [PreserveSig]
        new HRESULT CopyPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        new HRESULT CopyPixels(/* [unique][in] __RPC__in_opt */ ref WICRect prc, /* [in] */ uint cbStride, /* [in] */ uint cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbBuffer);
        
        // IWICBitmapFrameDecode
        [PreserveSig]
        HRESULT GetMetadataQueryReader(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryReader ppIMetadataQueryReader);
        
        [PreserveSig]
        HRESULT GetColorContexts(/* [in] */ uint cCount, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cCount) */ out IWICColorContext[] ppIColorContexts, /* [out] __RPC__out */ out uint pcActualCount);
        
        [PreserveSig]
        HRESULT GetThumbnail(/* [out] __RPC__deref_out_opt */ out IWICBitmapSource ppIThumbnail);
    }
}
