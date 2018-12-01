// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(500,5)
using System;
using System.Runtime.InteropServices;
using PROPERTYKEY = DirectN._tagpropertykey;

namespace DirectN
{
    [Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyStore
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint cProps);
        
        [PreserveSig]
        HRESULT GetAt(/* [in] */ uint iProp, /* [out] __RPC__out */ out PROPERTYKEY pkey);
        
        [PreserveSig]
        HRESULT GetValue(/* [in] __RPC__in */ ref PROPERTYKEY key, /* [out] __RPC__out */ PropVariant pv);
        
        [PreserveSig]
        HRESULT SetValue(/* [in] __RPC__in */ ref PROPERTYKEY key, /* [in] __RPC__in */ PropVariant propvar);
        
        [PreserveSig]
        HRESULT Commit();
    }
}
