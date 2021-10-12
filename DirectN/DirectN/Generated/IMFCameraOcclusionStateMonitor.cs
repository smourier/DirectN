// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(22830,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cc692f46-c697-47e2-a72d-7b064617749b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraOcclusionStateMonitor
    {
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        uint GetSupportedStates();
    }
}
