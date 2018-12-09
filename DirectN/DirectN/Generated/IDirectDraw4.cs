// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1152,1)
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
        HRESULT CreateClipper(uint __unnamed_0, ref LPDIRECTDRAWCLIPPER __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT CreatePalette(uint __unnamed_0, ref tagPALETTEENTRY __unnamed_1, ref LPDIRECTDRAWPALETTE __unnamed_2, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_3);
        
        [PreserveSig]
        HRESULT CreateSurface(ref LPDDSURFACEDESC2 __unnamed_0, ref LPDIRECTDRAWSURFACE4 __unnamed_1, [MarshalAs(UnmanagedType.IUnknown)] object __unnamed_2);
        
        [PreserveSig]
        HRESULT DuplicateSurface(ref LPDIRECTDRAWSURFACE4 __unnamed_0, ref LPDIRECTDRAWSURFACE4 __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumDisplayModes(uint __unnamed_0, ref LPDDSURFACEDESC2 __unnamed_1, ref IntPtr __unnamed_2, ref LPDDENUMMODESCALLBACK2 __unnamed_3);
        
        [PreserveSig]
        HRESULT EnumSurfaces(uint __unnamed_0, ref LPDDSURFACEDESC2 __unnamed_1, ref IntPtr __unnamed_2, ref LPDDENUMSURFACESCALLBACK2 __unnamed_3);
        
        [PreserveSig]
        HRESULT FlipToGDISurface();
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDCAPS_DX7 __unnamed_0, ref _DDCAPS_DX7 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDisplayMode(ref LPDDSURFACEDESC2 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFourCCCodes(ref uint __unnamed_0, ref uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetGDISurface(ref LPDIRECTDRAWSURFACE4 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetMonitorFrequency(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetScanLine(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetVerticalBlankStatus(ref bool __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0);
        
        [PreserveSig]
        HRESULT RestoreDisplayMode();
        
        [PreserveSig]
        HRESULT SetCooperativeLevel(ref IntPtr __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetDisplayMode(uint __unnamed_0, uint __unnamed_1, uint __unnamed_2, uint __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT WaitForVerticalBlank(uint __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetAvailableVidMem(ref _DDSCAPS2 __unnamed_0, ref uint __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT GetSurfaceFromDC(ref IntPtr __unnamed_0, ref LPDIRECTDRAWSURFACE4 __unnamed_1);
        
        [PreserveSig]
        HRESULT RestoreAllSurfaces();
        
        [PreserveSig]
        HRESULT TestCooperativeLevel();
        
        [PreserveSig]
        HRESULT GetDeviceIdentifier(ref tagDDDEVICEIDENTIFIER __unnamed_0, uint __unnamed_1);
    }
}
