// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(20242,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d0cef145-b3f4-4340-a2e5-7a5080ca05cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivityMonitor
    {
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Stop();
    }
}
