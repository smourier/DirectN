// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1223,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3017056d-9a91-4e90-937d-746c72abbf4f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyStoreCache : IPropertyStore
    {
        // IPropertyStore
        [PreserveSig]
        new HRESULT GetCount(/* [out] __RPC__out */ out uint cProps);
        
        [PreserveSig]
        new HRESULT GetAt(/* [in] */ uint iProp, /* [out] __RPC__out */ out _tagpropertykey pkey);
        
        [PreserveSig]
        new HRESULT GetValue(/* [in] __RPC__in */ ref _tagpropertykey key, /* [out] __RPC__out */ out PropVariant pv);
        
        [PreserveSig]
        new HRESULT SetValue(/* [in] __RPC__in */ ref _tagpropertykey key, /* [in] __RPC__in */ PropVariant propvar);
        
        [PreserveSig]
        new HRESULT Commit();
        
        // IPropertyStoreCache
        [PreserveSig]
        HRESULT GetState(/* [in] __RPC__in */ ref _tagpropertykey key, /* [out] __RPC__out */ out PSC_STATE pstate);
        
        [PreserveSig]
        HRESULT GetValueAndState(/* [in] __RPC__in */ ref _tagpropertykey key, /* [out] __RPC__out */ out PropVariant ppropvar, /* [out] __RPC__out */ out PSC_STATE pstate);
        
        [PreserveSig]
        HRESULT SetState(/* [in] __RPC__in */ ref _tagpropertykey key, /* [in] */ PSC_STATE state);
        
        [PreserveSig]
        HRESULT SetValueAndState(/* [in] __RPC__in */ ref _tagpropertykey key, /* [unique][in] __RPC__in_opt */ PropVariant ppropvar, /* [in] */ PSC_STATE state);
    }
}
