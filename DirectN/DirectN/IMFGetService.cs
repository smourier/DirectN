// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(4915,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fa993888-4383-415a-a930-dd472a8cf6f7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFGetService
    {
        [PreserveSig]
        HRESULT GetService(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
    }
}
