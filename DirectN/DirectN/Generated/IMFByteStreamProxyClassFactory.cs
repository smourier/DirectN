// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfobjects.h(4740,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a6b43f84-5c0a-42e8-a44d-b1857a76992f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFByteStreamProxyClassFactory
    {
        [PreserveSig]
        HRESULT CreateByteStreamProxy(/* [in] __RPC__in_opt */ IMFByteStream pByteStream, /* [unique][in] __RPC__in_opt */ IMFAttributes pAttributes, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}
