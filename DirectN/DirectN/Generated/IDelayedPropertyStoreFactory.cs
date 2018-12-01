// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3627,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("40d4577f-e237-4bdb-bd69-58f089431b6a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDelayedPropertyStoreFactory : IPropertyStoreFactory
    {
        // IPropertyStoreFactory
        [PreserveSig]
        new HRESULT GetPropertyStore(/* [in] */ GETPROPERTYSTOREFLAGS flags, /* [unique][in] __RPC__in_opt */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkFactory, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        new HRESULT GetPropertyStoreForKeys(/* [unique][in] __RPC__in_opt */ ref _tagpropertykey rgKeys, /* [in] */ uint cKeys, /* [in] */ GETPROPERTYSTOREFLAGS flags, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        // IDelayedPropertyStoreFactory
        [PreserveSig]
        HRESULT GetDelayedPropertyStore(/* [in] */ GETPROPERTYSTOREFLAGS flags, /* [in] */ uint dwStoreId, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
