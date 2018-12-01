// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(469,5)
using System;
using System.Runtime.InteropServices;
using BITMAPINFOHEADER = DirectN.tagBITMAPINFOHEADER;
using COLORREF = System.UInt32;
using LPRECT = DirectN.tagRECT;
using SIZE = DirectN.tagSIZE;

namespace DirectN
{
    [Guid("a490b1e4-ab84-4d31-a1b2-181e03b1077a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoDisplayControl
    {
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* [unique][out][in] __RPC__inout_opt */ ref SIZE pszVideo, /* [unique][out][in] __RPC__inout_opt */ ref SIZE pszARVideo);
        
        [PreserveSig]
        HRESULT GetIdealVideoSize(/* [unique][out][in] __RPC__inout_opt */ ref SIZE pszMin, /* [unique][out][in] __RPC__inout_opt */ ref SIZE pszMax);
        
        [PreserveSig]
        HRESULT SetVideoPosition(/* optional(MFVideoNormalizedRect) */ IntPtr pnrcSource, /* optional(LPRECT) */ IntPtr prcDest);
        
        [PreserveSig]
        HRESULT GetVideoPosition(/* [out] __RPC__out */ out MFVideoNormalizedRect pnrcSource, /* [out] __RPC__out */ out LPRECT prcDest);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [in] */ uint dwAspectRatioMode);
        
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [out] __RPC__out */ out uint pdwAspectRatioMode);
        
        [PreserveSig]
        HRESULT SetVideoWindow(/* [in] __RPC__in */ IntPtr hwndVideo);
        
        [PreserveSig]
        HRESULT GetVideoWindow(/* optional(HWND) */ out IntPtr phwndVideo);
        
        [PreserveSig]
        HRESULT RepaintVideo();
        
        [PreserveSig]
        HRESULT GetCurrentImage(/* [out][in] __RPC__inout */ ref BITMAPINFOHEADER pBih, /* optional(BYTE) */ out IntPtr pDib, /* [out] __RPC__out */ out uint pcbDib, /* [unique][out][in] __RPC__inout_opt */ ref long pTimeStamp);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetBorderColor(/* [out] __RPC__out */ out COLORREF pClr);
        
        [PreserveSig]
        HRESULT SetRenderingPrefs(/* [in] */ uint dwRenderFlags);
        
        [PreserveSig]
        HRESULT GetRenderingPrefs(/* [out] __RPC__out */ out uint pdwRenderFlags);
        
        [PreserveSig]
        HRESULT SetFullscreen(/* [in] */ bool fFullscreen);
        
        [PreserveSig]
        HRESULT GetFullscreen(/* [out] __RPC__out */ out bool pfFullscreen);
    }
}
