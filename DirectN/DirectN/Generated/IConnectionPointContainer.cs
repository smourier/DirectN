// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(862,5)
using System;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.ComTypes
{
    [Guid("b196b284-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConnectionPointContainer
    {
        [PreserveSig]
        HRESULT EnumConnectionPoints(/* [out] __RPC__deref_out_opt */ out IEnumConnectionPoints ppEnum);
        
        [PreserveSig]
        HRESULT FindConnectionPoint(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [out] __RPC__deref_out_opt */ out IConnectionPoint ppCP);
    }
}
