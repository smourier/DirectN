// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPLPDIRECTSOUNDBUFFER8 = DirectN.IDirectSoundBuffer8;
using LPLPDIRECTSOUNDCAPTUREBUFFER8 = DirectN.IDirectSoundCaptureBuffer8;

namespace DirectN
{
    [ComImport, Guid("edcb4c7a-daab-4216-a42e-6c50596ddc1d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundFullDuplex
    {
        [PreserveSig]
        HRESULT Initialize(/* THIS_ _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCaptureGuid, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pRenderGuid, /* _In_ */ ref _DSCBUFFERDESC lpDscBufferDesc, /* _In_ */ ref _DSBUFFERDESC lpDsBufferDesc, IntPtr hWnd, uint dwLevel, /* _Outptr_ */ out LPLPDIRECTSOUNDCAPTUREBUFFER8 lplpDirectSoundCaptureBuffer8, /* _Outptr_ */ out LPLPDIRECTSOUNDBUFFER8 lplpDirectSoundBuffer8);
    }
}
