// generated from <Windows SDK Path>\um\mfd3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("802302b0-82de-45e1-b421-f19ee5bdaf23"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFD3D12SynchronizationObject
    {
        [PreserveSig]
        HRESULT SignalEventOnFinalResourceRelease(IntPtr hEvent);
        
        [PreserveSig]
        HRESULT Reset();
    }
}
