// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfd3d12.h(218,5)
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
