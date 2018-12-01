// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1993,1)
using System;
using System.Runtime.InteropServices;
using LPDDENUMSURFACESCALLBACK7 = System.IntPtr;
using LPDDSURFACEDESC2 = DirectN._DDSURFACEDESC2;
using LPDIRECTDRAW = DirectN.IDirectDraw;
using LPDIRECTDRAWCLIPPER = DirectN.IDirectDrawClipper;
using LPDIRECTDRAWPALETTE = DirectN.IDirectDrawPalette;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;
using LPRECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("06675a80-3b9b-11d2-b92f-00609797ea5b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface7
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(LPDIRECTDRAWSURFACE7 __unnamed_0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(ref LPRECT __unnamed_0);
        
        [PreserveSig]
        HRESULT Blt(ref LPRECT __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1, ref LPRECT __unnamed_2, uint __unnamed_3, ref _DDBLTFX __unnamed_4);
        
        [PreserveSig]
        HRESULT BltBatch(ref _DDBLTBATCH __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BltFast(uint __unnamed_0, uint __unnamed_1, LPDIRECTDRAWSURFACE7 __unnamed_2, ref LPRECT __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(ref IntPtr __unnamed_0, ref LPDDENUMSURFACESCALLBACK7 __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint __unnamed_0, ref IntPtr __unnamed_1, ref LPDDENUMSURFACESCALLBACK7 __unnamed_2);
        
        [PreserveSig]
        HRESULT Flip(LPDIRECTDRAWSURFACE7 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(ref _DDSCAPS2 __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCaps(ref _DDSCAPS2 __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipper(LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT GetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDC(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFlipStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetOverlayPosition(ref int __unnamed_0, ref int __unnamed_1);
        
        [PreserveSig]
        HRESULT GetPalette(LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT GetPixelFormat(ref _DDPIXELFORMAT __unnamed_0);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(ref LPDDSURFACEDESC2 __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize(LPDIRECTDRAW __unnamed_0, ref LPDDSURFACEDESC2 __unnamed_1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(ref LPRECT __unnamed_0, ref LPDDSURFACEDESC2 __unnamed_1, uint __unnamed_2, ref IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT ReleaseDC(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Restore();
        
        [PreserveSig]
        HRESULT SetClipper(LPDIRECTDRAWCLIPPER __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorKey(uint __unnamed_0, ref _DDCOLORKEY __unnamed_1);
        
        [PreserveSig]
        HRESULT SetOverlayPosition(int __unnamed_0, int __unnamed_1);
        
        [PreserveSig]
        HRESULT SetPalette(LPDIRECTDRAWPALETTE __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock(ref LPRECT __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(ref LPRECT __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1, ref LPRECT __unnamed_2, uint __unnamed_3, ref _DDOVERLAYFX __unnamed_4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint __unnamed_0, LPDIRECTDRAWSURFACE7 __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDDInterface([MarshalAs(UnmanagedType.IUnknown)] object __unnamed_0);
        
        [PreserveSig]
        HRESULT PageLock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT PageUnlock(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetSurfaceDesc(ref LPDDSURFACEDESC2 __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, ref IntPtr __unnamed_1, uint __unnamed_2, uint __unnamed_3);
        
        [PreserveSig]
        HRESULT GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0, ref IntPtr __unnamed_1, ref uint __unnamed_2);
        
        [PreserveSig]
        HRESULT FreePrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid __unnamed_0);
        
        [PreserveSig]
        HRESULT GetUniquenessValue(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT ChangeUniquenessValue();
        
        [PreserveSig]
        HRESULT SetPriority(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetPriority(ref uint __unnamed_0);
        
        [PreserveSig]
        HRESULT SetLOD(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetLOD(ref uint __unnamed_0);
    }
}
