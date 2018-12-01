// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(1628,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a99400f4-3d84-4557-94ba-1242fb2cc9a6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyEnumTypeList
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pctypes);
        
        [PreserveSig]
        HRESULT GetAt(/* [in] */ uint itype, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT GetConditionAt(/* [in] */ uint nIndex, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT FindMatchingIndex(/* [in] __RPC__in */ PropVariant propvarCmp, /* [out] __RPC__out */ out uint pnIndex);
    }
}
