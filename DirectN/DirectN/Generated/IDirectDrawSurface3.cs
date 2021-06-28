// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\ddraw.h(1703,1)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE3 = DirectN.IDirectDrawSurface3;

namespace DirectN
{
    [ComImport, Guid("da044e00-69b2-11d0-a1d5-00aa00b8dfbb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface3
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(LPDIRECTDRAWSURFACE3 unnamed__0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref tagRECT unnamed__0);
        
        [PreserveSig]
        HRESULT Blt(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE3 unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDBLTFX unnamed__4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH unnamed__0, uint unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT BltFast(uint unnamed__0, uint unnamed__1, LPDIRECTDRAWSURFACE3 unnamed__2, ref tagRECT unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint unnamed__0, LPDIRECTDRAWSURFACE3 unnamed__1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint unnamed__0, IntPtr unnamed__1, IntPtr unnamed__2);
        
        [PreserveSig]
        HRESULT Flip(LPDIRECTDRAWSURFACE3 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS unnamed__0, out LPDIRECTDRAWSURFACE3 unnamed__1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDSCAPS unnamed__0);
        
        [PreserveSig]
        HRESULT GetClipper(out LPDIRECTDRAWCLIPPER unnamed__0);
        
        [PreserveSig]
        HRESULT GetColorKey(uint unnamed__0, ref _DDCOLORKEY unnamed__1);
        
        [PreserveSig]
        HRESULT GetDC(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT GetFlipStatus(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetOverlayPosition(ref int unnamed__0, ref int unnamed__1);
        
        [PreserveSig]
        HRESULT GetPalette(out LPDIRECTDRAWPALETTE unnamed__0);
        
        [PreserveSig]
        HRESULT GetPixelFormat(ref int unnamed__0);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(ref LPDDSURFACEDESC unnamed__0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW unnamed__0, ref LPDDSURFACEDESC unnamed__1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(ref tagRECT unnamed__0, ref LPDDSURFACEDESC unnamed__1, uint unnamed__2, IntPtr unnamed__3);
        
        [PreserveSig]
        HRESULT ReleaseDC(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT Restore();
        
        [PreserveSig]
        HRESULT SetClipper(LPDIRECTDRAWCLIPPER unnamed__0);
        
        [PreserveSig]
        HRESULT SetColorKey(uint unnamed__0, ref _DDCOLORKEY unnamed__1);
        
        [PreserveSig]
        HRESULT SetOverlayPosition(int unnamed__0, int unnamed__1);
        
        [PreserveSig]
        HRESULT SetPalette(LPDIRECTDRAWPALETTE unnamed__0);
        
        [PreserveSig]
        HRESULT Unlock(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE3 unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDOVERLAYFX unnamed__4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint unnamed__0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint unnamed__0, LPDIRECTDRAWSURFACE3 unnamed__1);
        
        [PreserveSig]
        HRESULT GetDDInterface(IntPtr unnamed__0);
        
        [PreserveSig]
        HRESULT PageLock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT PageUnlock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT SetSurfaceDesc(ref LPDDSURFACEDESC unnamed__0, uint unnamed__1);
    }
}
