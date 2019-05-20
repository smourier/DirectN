// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\amvideo.h(59,1)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAW = DirectN.IDirectDraw;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawVideo
    {
        [PreserveSig]
        HRESULT GetSwitches(/* THIS_ _Out_ */ out uint pSwitches);
        
        [PreserveSig]
        HRESULT SetSwitches(uint Switches);
        
        [PreserveSig]
        HRESULT GetCaps(/* THIS_ _Out_ */ out _DDCAPS_DX7 pCaps);
        
        [PreserveSig]
        HRESULT GetEmulatedCaps(/* THIS_ _Out_ */ out _DDCAPS_DX7 pCaps);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(/* THIS_ _Inout_ */ ref _DDSURFACEDESC pSurfaceDesc);
        
        [PreserveSig]
        HRESULT GetFourCCCodes(/* THIS_ _Out_ */ out uint pCount, /* _Out_ */ out uint pCodes);
        
        [PreserveSig]
        HRESULT SetDirectDraw(LPDIRECTDRAW pDirectDraw);
        
        [PreserveSig]
        HRESULT GetDirectDraw(/* THIS_ _Outptr_ */ out LPDIRECTDRAW ppDirectDraw);
        
        [PreserveSig]
        HRESULT GetSurfaceType(/* THIS_ _Out_ */ out uint pSurfaceType);
        
        [PreserveSig]
        HRESULT SetDefault();
        
        [PreserveSig]
        HRESULT UseScanLine(int UseScanLine);
        
        [PreserveSig]
        HRESULT CanUseScanLine(/* THIS_ _Out_ */ out long UseScanLine);
        
        [PreserveSig]
        HRESULT UseOverlayStretch(int UseOverlayStretch);
        
        [PreserveSig]
        HRESULT CanUseOverlayStretch(/* THIS_ _Out_ */ out long UseOverlayStretch);
        
        [PreserveSig]
        HRESULT UseWhenFullScreen(int UseWhenFullScreen);
        
        [PreserveSig]
        HRESULT WillUseFullScreen(/* THIS_ _Out_ */ out long UseWhenFullScreen);
    }
}
