// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUNDBUFFER = DirectN.IDirectSoundBuffer;
using LPUNKNOWN = System.Object;

namespace DirectN
{
    [ComImport, Guid("c50a7e93-f395-4834-9ef6-7fa99de50966"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSound8 : IDirectSound
    {
        // IDirectSound
        [PreserveSig]
        new HRESULT CreateSoundBuffer(/* THIS_ _In_ */ ref _DSBUFFERDESC pcDSBufferDesc, /* _Outptr_ */ out LPDIRECTSOUNDBUFFER ppDSBuffer, /* _Pre_null_ */ LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        new HRESULT GetCaps(/* THIS_ _Out_ */ out _DSCAPS pDSCaps);
        
        [PreserveSig]
        new HRESULT DuplicateSoundBuffer(/* THIS_ _In_ */ LPDIRECTSOUNDBUFFER pDSBufferOriginal, /* _Outptr_ */ out LPDIRECTSOUNDBUFFER ppDSBufferDuplicate);
        
        [PreserveSig]
        new HRESULT SetCooperativeLevel(IntPtr hwnd, uint dwLevel);
        
        [PreserveSig]
        new HRESULT Compact();
        
        [PreserveSig]
        new HRESULT GetSpeakerConfig(/* THIS_ _Out_ */ out uint pdwSpeakerConfig);
        
        [PreserveSig]
        new HRESULT SetSpeakerConfig(uint dwSpeakerConfig);
        
        [PreserveSig]
        new HRESULT Initialize(/* optional(LPCGUID) */ IntPtr pcGuidDevice);
        
        // IDirectSound8
        [PreserveSig]
        HRESULT VerifyCertification(/* THIS_ _Out_ */ out uint pdwCertified);
    }
}
