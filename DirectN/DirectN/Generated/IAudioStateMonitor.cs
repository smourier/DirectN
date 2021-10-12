// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audiostatemonitorapi.h(42,1)
using System;
using System.Runtime.InteropServices;
using AudioStateMonitorRegistrationHandle = System.Int64;
using PAudioStateMonitorCallback = System.IntPtr;

namespace DirectN
{
    [ComImport, Guid("1d13d136-0199-4cdc-b84e-e72c2b581ece"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioStateMonitor
    {
        [PreserveSig]
        HRESULT RegisterCallback(/* _In_ */ ref PAudioStateMonitorCallback callback, /* optional(void) */ IntPtr context, /* _Out_ */ out AudioStateMonitorRegistrationHandle registration);
        
        [PreserveSig]
        void UnregisterCallback(/* _In_ */ long registration);
        
        [PreserveSig]
        AudioStateMonitorSoundLevel GetSoundLevel();
    }
}
