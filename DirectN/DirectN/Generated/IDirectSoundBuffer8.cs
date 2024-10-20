// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUND = DirectN.IDirectSound;

namespace DirectN
{
    [ComImport, Guid("6825a449-7524-4d82-920f-50e36ab3ab1e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundBuffer8 : IDirectSoundBuffer
    {
        // IDirectSoundBuffer
        [PreserveSig]
        new HRESULT GetCaps(/* THIS_ _Out_ */ out _DSBCAPS pDSBufferCaps);
        
        [PreserveSig]
        new HRESULT GetCurrentPosition(/* optional(LPDWORD) */ IntPtr pdwCurrentPlayCursor, /* optional(LPDWORD) */ IntPtr pdwCurrentWriteCursor);
        
        [PreserveSig]
        new HRESULT GetFormat(/* optional(tWAVEFORMATEX) */ IntPtr pwfxFormat, uint dwSizeAllocated, /* optional(LPDWORD) */ IntPtr pdwSizeWritten);
        
        [PreserveSig]
        new HRESULT GetVolume(/* THIS_ _Out_ */ out int plVolume);
        
        [PreserveSig]
        new HRESULT GetPan(/* THIS_ _Out_ */ out int plPan);
        
        [PreserveSig]
        new HRESULT GetFrequency(/* THIS_ _Out_ */ out uint pdwFrequency);
        
        [PreserveSig]
        new HRESULT GetStatus(/* THIS_ _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        new HRESULT Initialize(/* THIS_ _In_ */ LPDIRECTSOUND pDirectSound, /* _In_ */ ref _DSBUFFERDESC pcDSBufferDesc);
        
        [PreserveSig]
        new HRESULT Lock(uint dwOffset, uint dwBytes, /* _Outptr_result_bytebuffer_(*pdwAudioBytes1) */ out IntPtr ppvAudioPtr1, /* _Out_ */ out uint pdwAudioBytes1, /* optional(LPVOID) */ out IntPtr ppvAudioPtr2, /* optional(LPDWORD) */ IntPtr pdwAudioBytes2, uint dwFlags);
        
        [PreserveSig]
        new HRESULT Play(uint dwReserved1, uint dwPriority, uint dwFlags);
        
        [PreserveSig]
        new HRESULT SetCurrentPosition(uint dwNewPosition);
        
        [PreserveSig]
        new HRESULT SetFormat(/* THIS_ _In_ */ ref tWAVEFORMATEX pcfxFormat);
        
        [PreserveSig]
        new HRESULT SetVolume(int lVolume);
        
        [PreserveSig]
        new HRESULT SetPan(int lPan);
        
        [PreserveSig]
        new HRESULT SetFrequency(uint dwFrequency);
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Unlock(/* THIS_ _In_reads_bytes_(dwAudioBytes1) */ IntPtr pvAudioPtr1, uint dwAudioBytes1, /* optional(LPVOID) */ IntPtr pvAudioPtr2, uint dwAudioBytes2);
        
        [PreserveSig]
        new HRESULT Restore();
        
        // IDirectSoundBuffer8
        [PreserveSig]
        HRESULT SetFX(int dwEffectsCount, /* _In_reads_opt_(dwEffectsCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] _DSEFFECTDESC[] pDSFXDesc, /* _Out_writes_opt_(dwEffectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pdwResultCodes);
        
        [PreserveSig]
        HRESULT AcquireResources(uint dwFlags, int dwEffectsCount, /* _Out_writes_(dwEffectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pdwResultCodes);
        
        [PreserveSig]
        HRESULT GetObjectInPath(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidObject, uint dwIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidInterface, /* _Outptr_ */ out IntPtr ppObject);
    }
}
