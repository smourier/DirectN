// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(3429,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1f9fc1d0-c39b-4b26-817f-011967d3440e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPropertyDescriptionList
    {
        [PreserveSig]
        HRESULT GetCount(/* [out] __RPC__out */ out uint pcElem);
        
        [PreserveSig]
        HRESULT GetAt(/* [in] */ uint iElem, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
