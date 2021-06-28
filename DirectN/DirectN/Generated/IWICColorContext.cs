// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(2358,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3c613a02-34b2-44ea-9a7c-45aea9c6fd6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICColorContext
    {
        [PreserveSig]
        HRESULT InitializeFromFilename(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wzFilename);
        
        [PreserveSig]
        HRESULT InitializeFromMemory(/* [size_is][in] __RPC__in_ecount_full(cbBufferSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbBuffer, /* [in] */ int cbBufferSize);
        
        [PreserveSig]
        HRESULT InitializeFromExifColorSpace(/* [in] */ uint value);
        
        [PreserveSig]
        HRESULT GetType(/* [out] __RPC__out */ out WICColorContextType pType);
        
        [PreserveSig]
        HRESULT GetProfileBytes(/* [in] */ int cbBuffer, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cbBuffer) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbBuffer, /* [out] __RPC__out */ out uint pcbActual);
        
        [PreserveSig]
        HRESULT GetExifColorSpace(/* [out] __RPC__out */ out uint pValue);
    }
}
