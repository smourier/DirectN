// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(4420,5)
using System;
using System.Runtime.InteropServices;
using LPCRECT = DirectN.tagRECT;
using LRESULT = System.Int64;

namespace DirectN
{
    [Guid("922eada0-3424-11cf-b670-00aa004cd6d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleInPlaceSiteWindowless : IOleInPlaceSiteEx
    {
        // IOleInPlaceSiteEx
        [PreserveSig]
        new HRESULT OnInPlaceActivateEx(/* [out] __RPC__out */ out bool pfNoRedraw, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        new HRESULT OnInPlaceDeactivateEx(/* [in] */ bool fNoRedraw);
        
        [PreserveSig]
        new HRESULT RequestUIActivate();
        
        // IOleInPlaceSiteWindowless
        [PreserveSig]
        HRESULT CanWindowlessActivate();
        
        [PreserveSig]
        HRESULT GetCapture();
        
        [PreserveSig]
        HRESULT SetCapture(/* [in] */ bool fCapture);
        
        [PreserveSig]
        HRESULT GetFocus();
        
        [PreserveSig]
        HRESULT SetFocus(/* [in] */ bool fFocus);
        
        [PreserveSig]
        HRESULT GetDC(/* optional(LPCRECT) */ IntPtr pRect, /* [in] */ uint grfFlags, /* [out] __RPC__deref_out_opt */ out IntPtr phDC);
        
        [PreserveSig]
        HRESULT ReleaseDC(/* [in] __RPC__in */ IntPtr hDC);
        
        [PreserveSig]
        HRESULT InvalidateRect(/* optional(LPCRECT) */ IntPtr pRect, /* [in] */ bool fErase);
        
        [PreserveSig]
        HRESULT InvalidateRgn(/* [in] __RPC__in */ IntPtr hRGN, /* [in] */ bool fErase);
        
        [PreserveSig]
        HRESULT ScrollRect(/* [in] */ int dx, /* [in] */ int dy, /* [in] __RPC__in */ ref LPCRECT pRectScroll, /* [in] __RPC__in */ ref LPCRECT pRectClip);
        
        [PreserveSig]
        HRESULT AdjustRect(/* [out][in] __RPC__inout */ ref tagRECT prc);
        
        [PreserveSig]
        HRESULT OnDefWindowMessage(/* [annotation][in] _In_ */ uint msg, /* [annotation][in] _In_ */ ulong wParam, /* [annotation][in] _In_ */ long lParam, /* [out] __RPC__out */ out LRESULT plResult);
    }
}
