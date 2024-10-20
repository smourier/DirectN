// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using LPDIRECTSOUNDCAPTUREBUFFER = DirectN.IDirectSoundCaptureBuffer;
using LPUNKNOWN = System.Object;

namespace DirectN
{
    [ComImport, Guid("b0210781-89cd-11d0-af08-00a0c925cd16"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundCapture
    {
        [PreserveSig]
        HRESULT CreateCaptureBuffer(/* THIS_ _In_ */ ref _DSCBUFFERDESC pcDSCBufferDesc, /* _Outptr_ */ out LPDIRECTSOUNDCAPTUREBUFFER ppDSCBuffer, /* _Pre_null_ */ LPUNKNOWN pUnkOuter);
        
        [PreserveSig]
        HRESULT GetCaps(/* THIS_ _Out_ */ out _DSCCAPS pDSCCaps);
        
        [PreserveSig]
        HRESULT Initialize(/* optional(LPCGUID) */ IntPtr pcGuidDevice);
    }
}
