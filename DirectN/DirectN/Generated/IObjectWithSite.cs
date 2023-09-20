// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fc4801a3-2ba9-11cf-a229-00aa003d7352"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IObjectWithSite
    {
        [PreserveSig]
        HRESULT SetSite(/* [in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkSite);
        
        [PreserveSig]
        HRESULT GetSite(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvSite);
    }
}
