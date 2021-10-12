// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioclient.h(1960,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4460b3ae-4b44-4527-8676-7548a8acd260"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEffectsManager
    {
        [PreserveSig]
        HRESULT RegisterAudioEffectsChangedNotificationCallback(/* [in] */ IAudioEffectsChangedNotificationClient client);
        
        [PreserveSig]
        HRESULT UnregisterAudioEffectsChangedNotificationCallback(/* [in] */ IAudioEffectsChangedNotificationClient client);
        
        [PreserveSig]
        HRESULT GetAudioEffects(/* [annotation][size_is][size_is][out] _Outptr_result_buffer_maybenull_(*numEffects) */ out IntPtr effects, /* [out] */ out uint numEffects);
        
        [PreserveSig]
        HRESULT SetAudioEffectState(/* [in] */ Guid effectId, /* [in] */ AUDIO_EFFECT_STATE state);
    }
}
