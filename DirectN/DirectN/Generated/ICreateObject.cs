// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(4076,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("75121952-e0d0-43e5-9380-1d80483acf72"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ICreateObject
    {
        [PreserveSig]
        HRESULT CreateObject(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid clsid, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
