// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ocidl.h(1133,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b196b283-bab4-101a-b69c-00aa00341d07"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IProvideClassInfo
    {
        [PreserveSig]
        HRESULT GetClassInfoA(/* optional(ITypeInfo) */ out IntPtr ppTI);
    }
}
