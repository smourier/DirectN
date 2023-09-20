// generated from <Windows SDK Path>\um\audiopolicy.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bfa971f1-4d5e-40bb-935e-967039bfbee4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionManager
    {
        [PreserveSig]
        HRESULT GetAudioSessionControl(/* optional(LPCGUID) */ IntPtr AudioSessionGuid, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][out] _Outptr_ */ out IAudioSessionControl SessionControl);
        
        [PreserveSig]
        HRESULT GetSimpleAudioVolume(/* optional(LPCGUID) */ IntPtr AudioSessionGuid, /* [annotation][in] _In_ */ uint StreamFlags, /* [annotation][out] _Outptr_ */ out ISimpleAudioVolume AudioVolume);
    }
}
