// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(5752,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fc4801a3-2ba9-11cf-a229-00aa003d7352"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IObjectWithSite
    {
        [PreserveSig]
        HRESULT SetSite(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkSite);
        
        [PreserveSig]
        HRESULT GetSite(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvSite);
    }
}
