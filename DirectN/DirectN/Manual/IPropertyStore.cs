using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("886d8eeb-8cf2-4446-8d02-cdba1dbdcf99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyStore
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint cProps);

        [PreserveSig]
        HRESULT GetAt(/* [in] */ uint iProp, /* [out] __RPC__out */ out PROPERTYKEY pkey);

        [PreserveSig]
        HRESULT GetValue(/* [in] __RPC__in */ ref PROPERTYKEY key, /* [out] __RPC__out */ [In, Out] PropVariant pv);

        [PreserveSig]
        HRESULT SetValue(/* [in] __RPC__in */ ref PROPERTYKEY key, /* [in] __RPC__in */ PropVariant propvar);

        [PreserveSig]
        HRESULT Commit();
    }
}
