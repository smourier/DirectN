// generated from <Windows SDK Path>\um\dxcapi.h
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
