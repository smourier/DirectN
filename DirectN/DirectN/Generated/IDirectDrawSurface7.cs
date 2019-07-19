// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ddraw.h(1993,1)
using System;
using System.Runtime.InteropServices;
using LPDDENUMSURFACESCALLBACK7 = System.IntPtr;
using LPDDSURFACEDESC2 = DirectN._DDSURFACEDESC2;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [Guid("06675a80-3b9b-11d2-b92f-00609797ea5b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface7
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(LPDIRECTDRAWSURFACE7 unnamed__0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref tagRECT unnamed__0);
        
        [PreserveSig]
        HRESULT Blt(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDBLTFX unnamed__4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH unnamed__0, uint unnamed__1, uint unnamed__2);
        
        [PreserveSig]
        HRESULT BltFast(uint unnamed__0, uint unnamed__1, LPDIRECTDRAWSURFACE7 unnamed__2, ref tagRECT unnamed__3, uint unnamed__4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(IntPtr unnamed__0, ref LPDDENUMSURFACESCALLBACK7 unnamed__1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint unnamed__0, IntPtr unnamed__1, ref LPDDENUMSURFACESCALLBACK7 unnamed__2);
        
        [PreserveSig]
        HRESULT Flip(LPDIRECTDRAWSURFACE7 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS2 unnamed__0, out LPDIRECTDRAWSURFACE7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDSCAPS2 unnamed__0);
        
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
        HRESULT GetSurfaceDesc(ref LPDDSURFACEDESC2 unnamed__0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW unnamed__0, ref LPDDSURFACEDESC2 unnamed__1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(ref tagRECT unnamed__0, ref LPDDSURFACEDESC2 unnamed__1, uint unnamed__2, IntPtr unnamed__3);
        
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
        HRESULT Unlock(ref tagRECT unnamed__0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(ref tagRECT unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1, ref tagRECT unnamed__2, uint unnamed__3, ref _DDOVERLAYFX unnamed__4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint unnamed__0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint unnamed__0, LPDIRECTDRAWSURFACE7 unnamed__1);
        
        [PreserveSig]
        HRESULT GetDDInterface([MarshalAs(UnmanagedType.IUnknown)] object unnamed__0);
        
        [PreserveSig]
        HRESULT PageLock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT PageUnlock(uint unnamed__0);
        
        [PreserveSig]
        HRESULT SetSurfaceDesc(ref LPDDSURFACEDESC2 unnamed__0, uint unnamed__1);
        
        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, IntPtr unnamed__1, uint unnamed__2, uint unnamed__3);
        
        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0, IntPtr unnamed__1, ref uint unnamed__2);
        
        [PreserveSig]
        HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid unnamed__0);
        
        [PreserveSig]
        HRESULT GetUniquenessValue(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT ChangeUniquenessValue();
        
        [PreserveSig]
        HRESULT SetPriority(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetPriority(ref uint unnamed__0);
        
        [PreserveSig]
        HRESULT SetLOD(uint unnamed__0);
        
        [PreserveSig]
        HRESULT GetLOD(ref uint unnamed__0);
    }
}
