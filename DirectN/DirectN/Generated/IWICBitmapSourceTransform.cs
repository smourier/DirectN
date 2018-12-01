// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(4056,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3b16811b-6a43-4ec9-b713-3d5a0c13b940"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapSourceTransform
    {
        [PreserveSig]
        HRESULT CopyPixels(/* [unique][in] __RPC__in_opt */ ref WICRect prc, /* [in] */ uint uiWidth, /* [in] */ uint uiHeight, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidDstFormat, /* [in] */ WICBitmapTransformOptions dstTransform, /* [in] */ uint nStride, /* [in] */ uint cbBufferSize, /* [size_is][out] __RPC__out_ecount_full(cbBufferSize) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] byte[] pbBuffer);
        
        [PreserveSig]
        HRESULT GetClosestSize(/* [out][in] __RPC__inout */ ref uint puiWidth, /* [out][in] __RPC__inout */ ref uint puiHeight);
        
        [PreserveSig]
        HRESULT GetClosestPixelFormat(/* [out][in] __RPC__inout */ out Guid pguidDstFormat);
        
        [PreserveSig]
        HRESULT DoesSupportTransform(/* [in] */ WICBitmapTransformOptions dstTransform, /* [out] __RPC__out */ out bool pfIsSupported);
    }
}
