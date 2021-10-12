// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(4535,5)
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("3b16811b-6a43-4ec9-a813-3d930c13b940"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapFrameDecode : IWICBitmapSource
    {
        // IWICBitmapSource
        [PreserveSig]
        new HRESULT GetSize(/* [out] __RPC__out */ out uint puiWidth, /* [out] __RPC__out */ out uint puiHeight);
        
        [PreserveSig]
        new HRESULT GetPixelFormat(/* [out] __RPC__out */ out WICPixelFormatGUID pPixelFormat);
        
        [PreserveSig]
        new HRESULT GetResolution(/* [out] __RPC__out */ out double pDpiX, /* [out] __RPC__out */ out double pDpiY);
        
        [PreserveSig]
        new HRESULT CopyPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        new HRESULT CopyPixels(/* optional(WICRect) */ IntPtr prc, /* [in] */ uint cbStride, /* [in] */ int cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbBuffer);
        
        // IWICBitmapFrameDecode
        [PreserveSig]
        HRESULT GetMetadataQueryReader(/* [out] __RPC__deref_out_opt */ out IWICMetadataQueryReader ppIMetadataQueryReader);
        
        [PreserveSig]
        HRESULT GetColorContexts(/* [in] */ int cCount, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cCount) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IWICColorContext[] ppIColorContexts, /* [out] __RPC__out */ out uint pcActualCount);
        
        [PreserveSig]
        HRESULT GetThumbnail(/* [out] __RPC__deref_out_opt */ out IWICBitmapSource ppIThumbnail);
    }
}
