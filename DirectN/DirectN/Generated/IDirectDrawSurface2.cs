// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1570,1)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE2 = DirectN.IDirectDrawSurface2;

namespace DirectN
{
    [Guid("57805885-6eec-11cf-9441-a82303c10e27"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface2
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(ref LPDIRECTDRAWSURFACE2 __unnamed_0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref tagRECT __unnamed_0);
        
        [PreserveSig]
        HRESULT Blt(ref tagRECT __unnamed_0, ref LPDIRECTDRAWSURFACE2 __unnamed_1, ref tagRECT __unnamed_2, uint __unnamed_3, ref _DDBLTFX __unnamed_4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BltFast(uint __unnamed_0, uint __unnamed_1, ref LPDIRECTDRAWSURFACE2 __unnamed_2, ref tagRECT __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint __unnamed_0, ref LPDIRECTDRAWSURFACE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(ref IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint __unnamed_0, ref IntPtr __unnamed_1, ref IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT Flip(ref LPDIRECTDRAWSURFACE2 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS __unnamed_0, ref LPDIRECTDRAWSURFACE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDSCAPS __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipper(ref LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT GetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDC(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFlipStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetOverlayPosition(ref int __unnamed_0, ref int __unnamed_1);
        
        [PreserveSig]
        HRESULT GetPalette(ref LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT GetPixelFormat(ref _DDPIXELFORMAT __unnamed_0);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(ref LPDDSURFACEDESC __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize(ref LPDIRECTDRAW __unnamed_0, ref LPDDSURFACEDESC __unnamed_1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(ref tagRECT __unnamed_0, ref LPDDSURFACEDESC __unnamed_1, uint __unnamed_2, ref IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT ReleaseDC(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Restore();
        
        [PreserveSig]
        HRESULT SetClipper(ref LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT SetOverlayPosition(int __unnamed_0, int __unnamed_1);
        
        [PreserveSig]
        HRESULT SetPalette(ref LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(ref tagRECT __unnamed_0, ref LPDIRECTDRAWSURFACE2 __unnamed_1, ref tagRECT __unnamed_2, uint __unnamed_3, ref _DDOVERLAYFX __unnamed_4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint __unnamed_0, ref LPDIRECTDRAWSURFACE2 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDDInterface([MarshalAs(UnmanagedType.IUnknown)] object __unnamed_0);
        
        [PreserveSig]
        HRESULT PageLock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT PageUnlock(uint __unnamed_0);
    }
}
