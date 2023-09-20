// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("97ec2ea4-0e42-4937-97ac-9d6d328824e1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFShutdown
    {
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT GetShutdownStatus(/* [out] __RPC__out */ out _MFSHUTDOWN_STATUS pStatus);
    }
}
