// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("62fae250-7e65-4460-bfc9-6398b322073c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMOverlayFX
    {
        [PreserveSig]
        HRESULT QueryOverlayFXCaps(/* [annotation][out] _Out_ */ out uint lpdwOverlayFXCaps);
        
        [PreserveSig]
        HRESULT SetOverlayFX(/* [in] */ uint dwOverlayFX);
        
        [PreserveSig]
        HRESULT GetOverlayFX(/* [annotation][out] _Out_ */ out uint lpdwOverlayFX);
    }
}
