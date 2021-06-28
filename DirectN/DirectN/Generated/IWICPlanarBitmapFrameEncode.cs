// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(3651,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f928b7b8-2221-40c1-b72e-7e82f1974d1a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICPlanarBitmapFrameEncode
    {
        [PreserveSig]
        HRESULT WritePixels(uint lineCount, /* [size_is][in] __RPC__in_ecount_full(cPlanes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] WICBitmapPlane[] pPlanes, int cPlanes);
        
        [PreserveSig]
        HRESULT WriteSource(/* [size_is][in] __RPC__in_ecount_full(cPlanes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] IWICBitmapSource[] ppPlanes, int cPlanes, /* optional(WICRect) */ IntPtr prcSource);
    }
}
