// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUNDCAPTURE = DirectN.IDirectSoundCapture;

namespace DirectN
{
    [ComImport, Guid("00990df4-0dbb-4872-833e-6d303e80aeb6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundCaptureBuffer8 : IDirectSoundCaptureBuffer
    {
        // IDirectSoundCaptureBuffer
        [PreserveSig]
        new HRESULT GetCaps(/* THIS_ _Out_ */ out _DSCBCAPS pDSCBCaps);
        
        [PreserveSig]
        new HRESULT GetCurrentPosition(/* optional(LPDWORD) */ IntPtr pdwCapturePosition, /* optional(LPDWORD) */ IntPtr pdwReadPosition);
        
        [PreserveSig]
        new HRESULT GetFormat(/* optional(tWAVEFORMATEX) */ IntPtr pwfxFormat, uint dwSizeAllocated, /* optional(LPDWORD) */ IntPtr pdwSizeWritten);
        
        [PreserveSig]
        new HRESULT GetStatus(/* THIS_ _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        new HRESULT Initialize(/* THIS_ _In_ */ LPDIRECTSOUNDCAPTURE pDirectSoundCapture, /* _In_ */ ref _DSCBUFFERDESC pcDSCBufferDesc);
        
        [PreserveSig]
        new HRESULT Lock(uint dwOffset, uint dwBytes, /* _Outptr_result_bytebuffer_(*pdwAudioBytes1) */ out IntPtr ppvAudioPtr1, /* _Out_ */ out uint pdwAudioBytes1, /* optional(LPVOID) */ out IntPtr ppvAudioPtr2, /* optional(LPDWORD) */ IntPtr pdwAudioBytes2, uint dwFlags);
        
        [PreserveSig]
        new HRESULT Start(uint dwFlags);
        
        [PreserveSig]
        new HRESULT Stop();
        
        [PreserveSig]
        new HRESULT Unlock(/* THIS_ _In_reads_bytes_(dwAudioBytes1) */ IntPtr pvAudioPtr1, uint dwAudioBytes1, /* optional(LPVOID) */ IntPtr pvAudioPtr2, uint dwAudioBytes2);
        
        // IDirectSoundCaptureBuffer8
        [PreserveSig]
        HRESULT GetObjectInPath(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidObject, uint dwIndex, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidInterface, /* _Outptr_ */ out IntPtr ppObject);
        
        [PreserveSig]
        HRESULT GetFXStatus(int dwEffectsCount, /* _Out_writes_(dwEffectsCount) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pdwFXStatus);
    }
}
