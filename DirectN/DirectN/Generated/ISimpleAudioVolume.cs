// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audioclient.h(1492,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("87ce5498-68d6-44e5-9215-6da47ef883d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ISimpleAudioVolume
    {
        [PreserveSig]
        HRESULT SetMasterVolume(/* [annotation][in] _In_ */ float fLevel, /* [unique][in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT GetMasterVolume(/* [annotation][out] _Out_ */ out float pfLevel);
        
        [PreserveSig]
        HRESULT SetMute(/* [annotation][in] _In_ */ int bMute, /* [unique][in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT GetMute(/* [annotation][out] _Out_ */ out bool pbMute);
    }
}
