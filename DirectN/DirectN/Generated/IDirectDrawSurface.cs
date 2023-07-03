// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\ddraw.h(1447,1)
using System;
using System.Runtime.InteropServices;
using LPDDSURFACEDESC = DirectN._DDSURFACEDESC;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [ComImport, Guid("6c14db81-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(LPDIRECTDRAWSURFACE unnamed__0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref tagRECT unnamed__0);
        
        [PreserveSig]
        HRESULT Blt(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDBLTFX unnamed__4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH unnamed__0, uint unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT BltFast(uint unnamed__0, uint unnamed__1, LPDIRECTDRAWSURFACE unnamed__2, ref tagRECT unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint unnamed__0, LPDIRECTDRAWSURFACE unnamed__1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(IntPtr unnamed__0, IntPtr unnamed__1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint unnamed__0, IntPtr unnamed__1, IntPtr unnamed__2);
        
        [PreserveSig]
        HRESULT Flip(LPDIRECTDRAWSURFACE unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS unnamed__0, out LPDIRECTDRAWSURFACE unnamed__1);
        
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
        HRESULT GetPixelFormat(ref _DDPIXELFORMAT unnamed__0);
        
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
        HRESULT UpdateOverlay(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDOVERLAYFX unnamed__4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint unnamed__0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint unnamed__0, LPDIRECTDRAWSURFACE unnamed__1);
    }
}
