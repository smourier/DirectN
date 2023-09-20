// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d0cef145-b3f4-4340-a2e5-7a5080ca05cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorActivityMonitor
    {
        [PreserveSig]
        HRESULT Start();
        
        [PreserveSig]
        HRESULT Stop();
    }
}
