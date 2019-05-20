// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxcapi.h(347,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcVersionInfo2 : IDxcVersionInfo
    {
        // IDxcVersionInfo
        [PreserveSig]
        new HRESULT GetVersion(/* _Out_ */ out uint pMajor, /* _Out_ */ out uint pMinor);
        
        [PreserveSig]
        new HRESULT GetFlags(/* _Out_ */ out uint pFlags);
        
        // IDxcVersionInfo2
        [PreserveSig]
        HRESULT GetCommitInfo(/* _Out_ */ out uint pCommitCount, /* _Out_ */ out IntPtr pCommitHash);
    }
}
