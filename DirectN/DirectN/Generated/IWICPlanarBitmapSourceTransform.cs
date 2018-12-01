// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(4184,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3aff9cce-be95-4303-b927-e7d16ff4a613"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPlanarBitmapSourceTransform
    {
        [PreserveSig]
        HRESULT DoesSupportTransform(/* [out][in] __RPC__inout */ ref uint puiWidth, /* [out][in] __RPC__inout */ ref uint puiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, /* [size_is][in] __RPC__in_ecount_full(cPlanes) */ [MarshalAs(UnmanagedType.LPStruct)] Guid pguidDstFormats, /* [size_is][out] __RPC__out_ecount_full(cPlanes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] WICBitmapPlaneDescription[] pPlaneDescriptions, uint cPlanes, /* [out] __RPC__out */ out bool pfIsSupported);
        
        [PreserveSig]
        HRESULT CopyPixels(/* [unique][in] __RPC__in_opt */ ref WICRect prcSource, uint uiWidth, uint uiHeight, WICBitmapTransformOptions dstTransform, WICPlanarOptions dstPlanarOptions, /* [size_is][in] __RPC__in_ecount_full(cPlanes) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 6)] WICBitmapPlane[] pDstPlanes, uint cPlanes);
    }
}
