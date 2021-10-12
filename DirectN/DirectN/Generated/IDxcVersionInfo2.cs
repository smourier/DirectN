// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxcapi.h(581,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("fb6904c4-42f0-4b62-9c46-983af7da7c83"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDxcVersionInfo2 : IDxcVersionInfo
    {
        // IDxcVersionInfo
        [PreserveSig]
        new HRESULT GetVersion(/* _Out_ */ out uint pMajor, /* _Out_ */ out uint pMinor);
        
        [PreserveSig]
        new HRESULT GetFlags(/* _Out_ */ out uint pFlags);
        
        // IDxcVersionInfo2
        [PreserveSig]
        HRESULT GetCommitInfo(/* _Out_ */ out uint pCommitCount, /* // The total number commits. _Outptr_result_z_ */ out IntPtr pCommitHash);
    }
}
