// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using REFWICPixelFormatGUID = System.Guid;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("bebee9cb-83b0-4dcc-8132-b0aaa55eac96"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPlanarFormatConverter : IWICBitmapSource
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
        
        // IWICPlanarFormatConverter
        [PreserveSig]
        HRESULT Initialize(/* [size_is][in] __RPC__in_ecount_full(cPlanes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IWICBitmapSource[] ppPlanes, int cPlanes, /* [in] __RPC__in */ ref REFWICPixelFormatGUID dstFormat, /* [in] */ WICBitmapDitherType dither, /* [unique][in] __RPC__in_opt */ IWICPalette pIPalette, /* [in] */ double alphaThresholdPercent, /* [in] */ WICBitmapPaletteType paletteTranslate);
        
        [PreserveSig]
        HRESULT CanConvert(/* [size_is][in] __RPC__in_ecount_full(cSrcPlanes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] WICPixelFormatGUID[] pSrcPixelFormats, int cSrcPlanes, /* [in] __RPC__in */ ref REFWICPixelFormatGUID dstPixelFormat, /* [out] __RPC__out */ out bool pfCanConvert);
    }
}
