// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(1300,5)
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("00000120-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapSource
    {
        [PreserveSig]
        HRESULT GetSize(/* [out] __RPC__out */ out uint puiWidth, /* [out] __RPC__out */ out uint puiHeight);
        
        [PreserveSig]
        HRESULT GetPixelFormat(/* [out] __RPC__out */ out WICPixelFormatGUID pPixelFormat);
        
        [PreserveSig]
        HRESULT GetResolution(/* [out] __RPC__out */ out double pDpiX, /* [out] __RPC__out */ out double pDpiY);
        
        [PreserveSig]
        HRESULT CopyPalette(/* [in] __RPC__in_opt */ IWICPalette pIPalette);
        
        [PreserveSig]
        HRESULT CopyPixels(/* optional(WICRect) */ IntPtr prc, /* [in] */ uint cbStride, /* [in] */ int cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbBuffer);
    }
}
