// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddraw.h(1152,1)
using System;
using System.Runtime.InteropServices;
using LPDDENUMMODESCALLBACK2 = System.IntPtr;
using LPDDENUMSURFACESCALLBACK2 = System.IntPtr;
using LPDDSURFACEDESC2 = DirectN._DDSURFACEDESC2;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE4 = DirectN.IDirectDrawSurface4;

namespace DirectN
{
    [Guid("9c59509a-39bd-11d1-8c4a-00c04fd930c5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDraw4
    {
        [PreserveSig]
        HRESULT Compact();
        
        [PreserveSig]
        HRESULT CreateClipper(uint unnamed__0, out LPDIRECTDRAWCLIPPER unnamed__1, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__2);
        
        [PreserveSig]
        HRESULT CreatePalette(uint unnamed__0, ref tagPALETTEENTRY unnamed__1, out LPDIRECTDRAWPALETTE unnamed__2, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__3);
        
        [PreserveSig]
        HRESULT CreateSurface(ref LPDDSURFACEDESC2 unnamed__0, out LPDIRECTDRAWSURFACE4 unnamed__1, [MarshalAs(UnmanagedType.IUnknown)] object unnamed__2);
        
        [PreserveSig]
        HRESULT DuplicateSurface(LPDIRECTDRAWSURFACE4 unnamed__0, out LPDIRECTDRAWSURFACE4 unnamed__1);
        
        [PreserveSig]
        HRESULT EnumDisplayModes(uint unnamed__0, ref LPDDSURFACEDESC2 unnamed__1, IntPtr unnamed__2, ref LPDDENUMMODESCALLBACK2 unnamed__3);
        
        [PreserveSig]
        HRESULT EnumSurfaces(uint unnamed__0, ref LPDDSURFACEDESC2 unnamed__1, IntPtr unnamed__2, ref LPDDENUMSURFACESCALLBACK2 unnamed__3);
        
        [PreserveSig]
        HRESULT FlipToGDISurface();
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDCAPS_DX7 unnamed__0, ref _DDCAPS_DX7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetDisplayMode(ref LPDDSURFACEDESC2 unnamed__0);
        
        [PreserveSig]
        HRESULT GetFourCCCodes(ref uint unnamed__0, ref uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetGDISurface(out LPDIRECTDRAWSURFACE4 unnamed__0);
        
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
        HRESULT SetDisplayMode(uint unnamed__0, uint unnamed__1, uint unnamed__2, uint unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT WaitForVerticalBlank(uint unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT GetAvailableVidMem(ref _DDSCAPS2 unnamed__0, ref uint unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT GetSurfaceFromDC(IntPtr unnamed__0, out LPDIRECTDRAWSURFACE4 unnamed__1);
        
        [PreserveSig]
        HRESULT RestoreAllSurfaces();
        
        [PreserveSig]
        HRESULT TestCooperativeLevel();
        
        [PreserveSig]
        HRESULT GetDeviceIdentifier(ref tagDDDEVICEIDENTIFIER unnamed__0, uint unnamed__1);
    }
}
