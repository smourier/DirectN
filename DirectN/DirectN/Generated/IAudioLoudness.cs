// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7d8b1437-dd53-4350-9c1b-1ee2890bd938"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioLoudness
    {
        [PreserveSig]
        HRESULT GetEnabled(/* [annotation][out] _Out_ */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT SetEnabled(/* [annotation][in] _In_ */ bool bEnable, /* optional(LPCGUID) */ IntPtr pguidEventContext);
    }
}
