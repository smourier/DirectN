// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddraw.h(981,1)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("6c14db80-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDraw
    {
        [PreserveSig]
        HRESULT Compact();
        
        [PreserveSig]
        HRESULT CreateClipper(uint unnamed__0, out LPDIRECTDRAWCLIPPER unnamed__1, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__2);
        
        [PreserveSig]
        HRESULT CreatePalette(uint unnamed__0, ref tagPALETTEENTRY unnamed__1, out LPDIRECTDRAWPALETTE unnamed__2, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__3);
        
        [PreserveSig]
        HRESULT CreateSurface(ref LPDDSURFACEDESC unnamed__0, out LPDIRECTDRAWSURFACE unnamed__1, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__2);
        
        [PreserveSig]
        HRESULT DuplicateSurface(LPDIRECTDRAWSURFACE unnamed__0, out LPDIRECTDRAWSURFACE unnamed__1);
        
        [PreserveSig]
        HRESULT EnumDisplayModes(uint unnamed__0, ref LPDDSURFACEDESC unnamed__1, IntPtr unnamed__2, IntPtr unnamed__3);
        
        [PreserveSig]
        HRESULT EnumSurfaces(uint unnamed__0, ref LPDDSURFACEDESC unnamed__1, IntPtr unnamed__2, IntPtr unnamed__3);
        
        [PreserveSig]
        HRESULT FlipToGDISurface();
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDCAPS_DX7 unnamed__0, ref _DDCAPS_DX7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetDisplayMode(ref LPDDSURFACEDESC unnamed__0);
        
        [PreserveSig]
        HRESULT GetFourCCCodes(ref uint unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetGDISurface(out LPDIRECTDRAWSURFACE unnamed__0);
        
        [PreserveSig]
        HRESULT GetMonitorFrequency(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetScanLine(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetVerticalBlankStatus(ref bool unnamed__0);
        
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0);
        
        [PreserveSig]
        HRESULT RestoreDisplayMode();
        
        [PreserveSig]
        HRESULT SetCooperativeLevel(IntPtr unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetDisplayMode(uint unnamed__0, uint unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT WaitForVerticalBlank(uint unnamed__0, IntPtr unnamed__1);
    }
}
