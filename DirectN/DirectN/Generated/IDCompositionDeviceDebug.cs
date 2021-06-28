// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dcomp.h(1397,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a1a3c64a-224f-4a81-9773-4f03a89d3c6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDCompositionDeviceDebug
    {
        [PreserveSig]
        HRESULT EnableDebugCounters();
        
        [PreserveSig]
        HRESULT DisableDebugCounters();
    }
}
