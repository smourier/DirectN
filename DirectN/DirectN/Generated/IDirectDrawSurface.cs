// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddraw.h(1447,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6c14db81-a733-11ce-a521-0020af0be560"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDirectDrawSurface
    {
        [PreserveSig]
        HRESULT AddAttachedSurface(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT AddOverlayDirtyRect(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Blt(IntPtr __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4);
        
        [PreserveSig]
        HRESULT BltBatch(IntPtr __unnamed_0, uint __unnamed_1, uint __unnamed_2);
        
        [PreserveSig]
        HRESULT BltFast(uint __unnamed_0, uint __unnamed_1, IntPtr __unnamed_2, IntPtr __unnamed_3, uint __unnamed_4);
        
        [PreserveSig]
        HRESULT DeleteAttachedSurface(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumAttachedSurfaces(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT EnumOverlayZOrders(uint __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2);
        
        [PreserveSig]
        HRESULT Flip(IntPtr __unnamed_0, uint __unnamed_1);
        
        [PreserveSig]
        HRESULT GetAttachedSurface(IntPtr __unnamed_0, ref IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetBltStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetCaps(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetClipper(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetColorKey(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetDC(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetFlipStatus(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT GetOverlayPosition(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT GetPalette(ref IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetPixelFormat(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT GetSurfaceDesc(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Initialize(IntPtr __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT IsLost();
        
        [PreserveSig]
        HRESULT Lock(IntPtr __unnamed_0, IntPtr __unnamed_1, uint __unnamed_2, IntPtr __unnamed_3);
        
        [PreserveSig]
        HRESULT ReleaseDC(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Restore();
        
        [PreserveSig]
        HRESULT SetClipper(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT SetColorKey(uint __unnamed_0, IntPtr __unnamed_1);
        
        [PreserveSig]
        HRESULT SetOverlayPosition(int __unnamed_0, int __unnamed_1);
        
        [PreserveSig]
        HRESULT SetPalette(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT Unlock(IntPtr __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlay(IntPtr __unnamed_0, IntPtr __unnamed_1, IntPtr __unnamed_2, uint __unnamed_3, IntPtr __unnamed_4);
        
        [PreserveSig]
        HRESULT UpdateOverlayDisplay(uint __unnamed_0);
        
        [PreserveSig]
        HRESULT UpdateOverlayZOrder(uint __unnamed_0, IntPtr __unnamed_1);
    }
}
