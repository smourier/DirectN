// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxcapi.h(341,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b04f5b50-2059-4f12-a8ff-a1e0cde1cc7e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcVersionInfo
    {
        [PreserveSig]
        HRESULT GetVersion(/* _Out_ */ out uint pMajor, /* _Out_ */ out uint pMinor);
        
        [PreserveSig]
        HRESULT GetFlags(/* _Out_ */ out uint pFlags);
    }
}
