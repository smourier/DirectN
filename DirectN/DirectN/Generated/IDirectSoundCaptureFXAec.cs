// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ad74143d-903d-4ab7-8066-28d363036d65"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectSoundCaptureFXAec
    {
        [PreserveSig]
        HRESULT SetAllParameters(/* THIS_ _In_ */ ref _DSCFXAec pDscFxAec);
        
        [PreserveSig]
        HRESULT GetAllParameters(/* THIS_ _Out_ */ out _DSCFXAec pDscFxAec);
        
        [PreserveSig]
        HRESULT GetStatus(/* THIS_ _Out_ */ out uint pdwStatus);
        
        [PreserveSig]
        HRESULT Reset();
    }
}
