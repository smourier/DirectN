// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(4069,5)
using System;
using System.Runtime.InteropServices;
using WICPixelFormatGUID = System.Guid;

namespace DirectN
{
    [Guid("3b16811b-6a43-4ec9-b713-3d5a0c13b940"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapSourceTransform
    {
        [PreserveSig]
        HRESULT CopyPixels(/* optional(WICRect) */ IntPtr prc, /* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* optional(WICPixelFormatGUID) */ IntPtr pguidDstFormat, /* [in] */ WICBitmapTransformOptions dstTransform, /* [in] */ uint nStride, /* [in] */ int cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] byte[] pbBuffer);
        
        [PreserveSig]
        HRESULT GetClosestSize(/* [out][in] __RPC__inout */ ref uint puiWidth, /* [out][in] __RPC__inout */ ref uint puiHeight);
        
        [PreserveSig]
        HRESULT GetClosestPixelFormat(/* [out][in] __RPC__inout */ ref WICPixelFormatGUID pguidDstFormat);
        
        [PreserveSig]
        HRESULT DoesSupportTransform(/* [in] */ WICBitmapTransformOptions dstTransform, /* [out] __RPC__out */ out bool pfIsSupported);
    }
}
