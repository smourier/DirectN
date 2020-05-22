// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(1896,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("85401fd4-6de4-4b9d-9869-2d6753a82f3c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioAutoGainControl
    {
        [PreserveSig]
        HRESULT GetEnabled(/* [annotation][out] _Out_ */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT SetEnabled(/* [annotation][in] _In_ */ bool bEnable, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}
