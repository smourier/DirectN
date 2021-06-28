// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(1387,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("df45aeea-b74a-4b6b-afad-2366b6aa012e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioMute
    {
        [PreserveSig]
        HRESULT SetMute(/* [annotation][in] _In_ */ bool bMuted, /* optional(LPCGUID) */ IntPtr pguidEventContext);
        
        [PreserveSig]
        HRESULT GetMute(/* [annotation][out] _Out_ */ out bool pbMuted);
    }
}
