// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUND = DirectN.IDirectSound;

namespace DirectN
{
    [ComImport, Guid("279afa85-4981-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundBuffer
    {
        [PreserveSig]
        HRESULT GetCaps(/* THIS_ _Out_ */ out _DSBCAPS pDSBufferCaps);
        
        [PreserveSig]
        HRESULT GetCurrentPosition(/* optional(LPDWORD) */ IntPtr pdwCurrentPlayCursor, /* optional(LPDWORD) */ IntPtr pdwCurrentWriteCursor);
        
        [PreserveSig]
        HRESULT GetFormat(/* optional(tWAVEFORMATEX) */ IntPtr pwfxFormat, uint dwSizeAllocated, /* optional(LPDWORD) */ IntPtr pdwSizeWritten);
        
        [PreserveSig]
        HRESULT GetVolume(/* THIS_ _Out_ */ out int plVolume);
        
        [PreserveSig]
        HRESULT GetPan(/* THIS_ _Out_ */ out int plPan);
        
        [PreserveSig]
        HRESULT GetFrequency(/* THIS_ _Out_ */ out uint pdwFrequency);
        
        [PreserveSig]
        HRESULT GetStatus(/* THIS_ _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT Initialize(/* THIS_ _In_ */ LPDIRECTSOUND pDirectSound, /* _In_ */ ref _DSBUFFERDESC pcDSBufferDesc);
        
        [PreserveSig]
        HRESULT Lock(uint dwOffset, uint dwBytes, /* _Outptr_result_bytebuffer_(*pdwAudioBytes1) */ out IntPtr ppvAudioPtr1, /* _Out_ */ out uint pdwAudioBytes1, /* optional(LPVOID) */ out IntPtr ppvAudioPtr2, /* optional(LPDWORD) */ IntPtr pdwAudioBytes2, uint dwFlags);
        
        [PreserveSig]
        HRESULT Play(uint dwReserved1, uint dwPriority, uint dwFlags);
        
        [PreserveSig]
        HRESULT SetCurrentPosition(uint dwNewPosition);
        
        [PreserveSig]
        HRESULT SetFormat(/* THIS_ _In_ */ ref tWAVEFORMATEX pcfxFormat);
        
        [PreserveSig]
        HRESULT SetVolume(int lVolume);
        
        [PreserveSig]
        HRESULT SetPan(int lPan);
        
        [PreserveSig]
        HRESULT SetFrequency(uint dwFrequency);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Unlock(/* THIS_ _In_reads_bytes_(dwAudioBytes1) */ IntPtr pvAudioPtr1, uint dwAudioBytes1, /* optional(LPVOID) */ IntPtr pvAudioPtr2, uint dwAudioBytes2);
        
        [PreserveSig]
        HRESULT Restore();
    }
}
