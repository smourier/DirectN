// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wincodec.h(2084,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000123-a8f2-4877-ba0a-fd2b6645fb94"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICBitmapLock
    {
        [PreserveSig]
        HRESULT GetSize(/* [out] __RPC__out */ out uint puiWidth, /* [out] __RPC__out */ out uint puiHeight);
        
        [PreserveSig]
        HRESULT GetStride(/* [out] __RPC__out */ out uint pcbStride);
        
        [PreserveSig]
        HRESULT GetDataPointer(/* [out] __RPC__out */ out uint pcbBufferSize, /* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcbBufferSize) */ out IntPtr[] ppbData);
        
        [PreserveSig]
        HRESULT GetPixelFormat(/* [out] __RPC__out */ out Guid pPixelFormat);
    }
}
