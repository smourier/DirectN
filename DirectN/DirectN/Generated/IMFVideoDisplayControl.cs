// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(469,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a490b1e4-ab84-4d31-a1b2-181e03b1077a"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoDisplayControl
    {
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* [unique][out][in] __RPC__inout_opt */ ref tagSIZE pszVideo, /* [unique][out][in] __RPC__inout_opt */ ref tagSIZE pszARVideo);
        
        [PreserveSig]
        HRESULT GetIdealVideoSize(/* [unique][out][in] __RPC__inout_opt */ ref tagSIZE pszMin, /* [unique][out][in] __RPC__inout_opt */ ref tagSIZE pszMax);
        
        [PreserveSig]
        HRESULT SetVideoPosition(/* [unique][in] __RPC__in_opt */ ref MFVideoNormalizedRect pnrcSource, /* [unique][in] __RPC__in_opt */ IntPtr prcDest);
        
        [PreserveSig]
        HRESULT GetVideoPosition(/* [out] __RPC__out */ out MFVideoNormalizedRect pnrcSource, /* [out] __RPC__out */ IntPtr prcDest);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [in] */ uint dwAspectRatioMode);
        
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [out] __RPC__out */ out uint pdwAspectRatioMode);
        
        [PreserveSig]
        HRESULT SetVideoWindow(/* [in] __RPC__in */ IntPtr hwndVideo);
        
        [PreserveSig]
        HRESULT GetVideoWindow(/* [out] __RPC__deref_out_opt */ out IntPtr phwndVideo);
        
        [PreserveSig]
        HRESULT RepaintVideo();
        
        [PreserveSig]
        HRESULT GetCurrentImage(/* [out][in] __RPC__inout */ ref tagBITMAPINFOHEADER pBih, /* [size_is][size_is][out] __RPC__deref_out_ecount_full_opt(*pcbDib) */ out byte[] pDib, /* [out] __RPC__out */ out uint pcbDib, /* [unique][out][in] __RPC__inout_opt */ ref long pTimeStamp);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetBorderColor(/* [out] __RPC__out */ out uint pClr);
        
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
