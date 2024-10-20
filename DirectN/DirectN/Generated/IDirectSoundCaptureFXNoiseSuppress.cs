// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ed311e41-fbae-4175-9625-cd0854f693ca"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundCaptureFXNoiseSuppress
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSCFXNoiseSuppress pcDscFxNoiseSuppress);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSCFXNoiseSuppress pDscFxNoiseSuppress);
        
        [PreserveSig]
        HRESULT Reset();
    }
}
