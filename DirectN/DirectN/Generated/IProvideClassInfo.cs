// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace DirectN
{
    [ComImport, Guid("b196b283-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideClassInfo
    {
        [PreserveSig]
        HRESULT GetClassInfoW(/* [out] __RPC__deref_out_opt */ out ITypeInfo ppTI);
    }
}
