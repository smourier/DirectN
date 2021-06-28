// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(2494,5)
using System;
using System.Runtime.InteropServices;
using REFWICPixelFormatGUID = System.Guid;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("b66f034f-d0e2-40ab-b436-6de39e321a94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICColorTransform : IWICBitmapSource
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
        
        // IWICColorTransform
        [PreserveSig]
        HRESULT Initialize(/* [in] __RPC__in_opt */ IWICBitmapSource pIBitmapSource, /* [in] __RPC__in_opt */ IWICColorContext pIContextSource, /* [in] __RPC__in_opt */ IWICColorContext pIContextDest, /* [in] __RPC__in */ ref REFWICPixelFormatGUID pixelFmtDest);
    }
}
