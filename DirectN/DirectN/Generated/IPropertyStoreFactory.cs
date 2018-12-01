// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3523,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bc110b6d-57e8-4148-a9c6-91015ab2f3a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyStoreFactory
    {
        [PreserveSig]
        HRESULT GetPropertyStore(/* [in] */ GETPROPERTYSTOREFLAGS flags, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkFactory, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetPropertyStoreForKeys(/* [unique][in] __RPC__in_opt */ ref _tagpropertykey rgKeys, /* [in] */ uint cKeys, /* [in] */ GETPROPERTYSTOREFLAGS flags, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
