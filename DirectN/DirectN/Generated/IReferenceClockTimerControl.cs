// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(2548,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("ebec459c-2eca-4d42-a8af-30df557614b8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IReferenceClockTimerControl
    {
        [PreserveSig]
        HRESULT SetDefaultTimerResolution(long timerResolution);
        
        [PreserveSig]
        HRESULT GetDefaultTimerResolution(/* [annotation] _Out_ */ out REFERENCE_TIME pTimerResolution);
    }
}
