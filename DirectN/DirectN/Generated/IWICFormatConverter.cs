// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wincodec.h(1459,5)
using System;
using System.Runtime.InteropServices;
using REFWICPixelFormatGUID = System.Guid;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("00000301-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICFormatConverter : IWICBitmapSource
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
        
        // IWICFormatConverter
        [PreserveSig]
        HRESULT Initialize(/* [in] __RPC__in_opt */ IWICBitmapSource pISource, /* [in] __RPC__in */ ref REFWICPixelFormatGUID dstFormat, /* [in] */ WICBitmapDitherType dither, /* [unique][in] __RPC__in_opt */ IWICPalette pIPalette, /* [in] */ double alphaThresholdPercent, /* [in] */ WICBitmapPaletteType paletteTranslate);
        
        [PreserveSig]
        HRESULT CanConvert(/* [in] __RPC__in */ ref REFWICPixelFormatGUID srcPixelFormat, /* [in] __RPC__in */ ref REFWICPixelFormatGUID dstPixelFormat, /* [out] __RPC__out */ out bool pfCanConvert);
    }
}
