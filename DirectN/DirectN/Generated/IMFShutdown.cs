// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(6942,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("97ec2ea4-0e42-4937-97ac-9d6d328824e1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFShutdown
    {
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT GetShutdownStatus(/* [out] __RPC__out */ out _MFSHUTDOWN_STATUS pStatus);
    }
}
