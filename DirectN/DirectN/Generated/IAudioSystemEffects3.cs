// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c58b31cd-fc6a-4255-bc1f-ad29bb0a4a17"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSystemEffects3 : IAudioSystemEffects2
    {
        // IAudioSystemEffects
        
        // IAudioSystemEffects2
        [PreserveSig]
        new HRESULT GetEffectsList(/* [annotation][out] _Outptr_result_buffer_maybenull_(*pcEffects) */ out IntPtr ppEffectsIds, /* [annotation][out] _Out_ */ out uint pcEffects, /* [annotation][in] _In_ */ IntPtr Event);
        
        // IAudioSystemEffects3
        [PreserveSig]
        HRESULT GetControllableSystemEffectsList(/* [annotation][size_is][size_is][out] _Outptr_result_buffer_maybenull_(*numEffects) */ out IntPtr effects, /* [annotation][out] _Out_ */ out uint numEffects, /* optional(HANDLE) */ IntPtr @event);
        
        [PreserveSig]
        HRESULT SetAudioSystemEffectState(/* [in] */ Guid effectId, /* [in] */ AUDIO_SYSTEMEFFECT_STATE state);
    }
}
