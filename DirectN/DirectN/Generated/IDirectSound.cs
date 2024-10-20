// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUNDBUFFER = DirectN.IDirectSoundBuffer;
using LPUNKNOWN = System.Object;

namespace DirectN
{
    [ComImport, Guid("279afa83-4981-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSound
    {
        [PreserveSig]
        HRESULT CreateSoundBuffer(/* THIS_ _In_ */ ref _DSBUFFERDESC pcDSBufferDesc, /* _Outptr_ */ out LPDIRECTSOUNDBUFFER ppDSBuffer, /* _Pre_null_ */ LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        HRESULT GetCaps(/* THIS_ _Out_ */ out _DSCAPS pDSCaps);
        
        [PreserveSig]
        HRESULT DuplicateSoundBuffer(/* THIS_ _In_ */ LPDIRECTSOUNDBUFFER pDSBufferOriginal, /* _Outptr_ */ out LPDIRECTSOUNDBUFFER ppDSBufferDuplicate);
        
        [PreserveSig]
        HRESULT SetCooperativeLevel(IntPtr hwnd, uint dwLevel);
        
        [PreserveSig]
        HRESULT Compact();
        
        [PreserveSig]
        HRESULT GetSpeakerConfig(/* THIS_ _Out_ */ out uint pdwSpeakerConfig);
        
        [PreserveSig]
        HRESULT SetSpeakerConfig(uint dwSpeakerConfig);
        
        [PreserveSig]
        HRESULT Initialize(/* optional(LPCGUID) */ IntPtr pcGuidDevice);
    }
}
