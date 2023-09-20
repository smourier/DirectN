// generated from <Windows SDK Path>\um\ocidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b196b28b-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpecifyPropertyPages
    {
        [PreserveSig]
        HRESULT GetPages(/* [out] __RPC__out */ out tagCAUUID pPages);
    }
}
