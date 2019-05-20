// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(2304,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b196b28b-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISpecifyPropertyPages
    {
        [PreserveSig]
        HRESULT GetPages(/* [out] __RPC__out */ out tagCAUUID pPages);
    }
}
