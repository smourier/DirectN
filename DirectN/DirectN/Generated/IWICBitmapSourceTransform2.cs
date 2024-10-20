// generated from <Windows SDK Path>\um\wincodec.h
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [ComImport, Guid("c3373fdf-6d39-4e5f-8e79-bf40c0b7ed77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapSourceTransform2 : IWICBitmapSourceTransform
    {
        // IWICBitmapSourceTransform
        [PreserveSig]
        new HRESULT CopyPixels(/* optional(WICRect) */ IntPtr prc, /* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* optional(WICPixelFormatGUID) */ IntPtr pguidDstFormat, /* [in] */ WICBitmapTransformOptions dstTransform, /* [in] */ uint nStride, /* [in] */ int cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] byte[] pbBuffer);
        
        [PreserveSig]
        new HRESULT GetClosestSize(/* [out][in] __RPC__inout */ ref uint puiWidth, /* [out][in] __RPC__inout */ ref uint puiHeight);
        
        [PreserveSig]
        new HRESULT GetClosestPixelFormat(/* [out][in] __RPC__inout */ ref WICPixelFormatGUID pguidDstFormat);
        
        [PreserveSig]
        new HRESULT DoesSupportTransform(/* [in] */ WICBitmapTransformOptions dstTransform, /* [out] __RPC__out */ out bool pfIsSupported);
        
        // IWICBitmapSourceTransform2
        [PreserveSig]
        HRESULT GetColorContextsForPixelFormat(/* optional(WICPixelFormatGUID) */ IntPtr pPixelFormat, /* [in] */ int cCount, /* [size_is][unique][in] __RPC__in_ecount_full_opt(cCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IWICColorContext[] ppIColorContexts, /* [out] __RPC__out */ out uint pcActualCount);
    }
}
