// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUNDCAPTURE = DirectN.IDirectSoundCapture;

namespace DirectN
{
    [ComImport, Guid("b0210782-89cd-11d0-af08-00a0c925cd16"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundCaptureBuffer
    {
        [PreserveSig]
        HRESULT GetCaps(/* THIS_ _Out_ */ out _DSCBCAPS pDSCBCaps);
        
        [PreserveSig]
        HRESULT GetCurrentPosition(/* optional(LPDWORD) */ IntPtr pdwCapturePosition, /* optional(LPDWORD) */ IntPtr pdwReadPosition);
        
        [PreserveSig]
        HRESULT GetFormat(/* optional(tWAVEFORMATEX) */ IntPtr pwfxFormat, uint dwSizeAllocated, /* optional(LPDWORD) */ IntPtr pdwSizeWritten);
        
        [PreserveSig]
        HRESULT GetStatus(/* THIS_ _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT Initialize(/* THIS_ _In_ */ LPDIRECTSOUNDCAPTURE pDirectSoundCapture, /* _In_ */ ref _DSCBUFFERDESC pcDSCBufferDesc);
        
        [PreserveSig]
        HRESULT Lock(uint dwOffset, uint dwBytes, /* _Outptr_result_bytebuffer_(*pdwAudioBytes1) */ out IntPtr ppvAudioPtr1, /* _Out_ */ out uint pdwAudioBytes1, /* optional(LPVOID) */ out IntPtr ppvAudioPtr2, /* optional(LPDWORD) */ IntPtr pdwAudioBytes2, uint dwFlags);
        
        [PreserveSig]
        HRESULT Start(uint dwFlags);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Unlock(/* THIS_ _In_reads_bytes_(dwAudioBytes1) */ IntPtr pvAudioPtr1, uint dwAudioBytes1, /* optional(LPVOID) */ IntPtr pvAudioPtr2, uint dwAudioBytes2);
    }
}
