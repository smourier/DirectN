// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(18950,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRWindowlessControl
    {
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* [out] */ out long lpWidth, /* [out] */ out long lpHeight, /* [out] */ out long lpARWidth, /* [out] */ out long lpARHeight);
        
        [PreserveSig]
        HRESULT GetMinIdealVideoSize(/* [out] */ out long lpWidth, /* [out] */ out long lpHeight);
        
        [PreserveSig]
        HRESULT GetMaxIdealVideoSize(/* [out] */ out long lpWidth, /* [out] */ out long lpHeight);
        
        [PreserveSig]
        HRESULT SetVideoPosition(/* [in] */ IntPtr lpSRCRect, /* [in] */ IntPtr lpDSTRect);
        
        [PreserveSig]
        HRESULT GetVideoPosition(/* [out] */ IntPtr lpSRCRect, /* [out] */ IntPtr lpDSTRect);
        
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [out] */ out uint lpAspectRatioMode);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [in] */ uint AspectRatioMode);
        
        [PreserveSig]
        HRESULT SetVideoClippingWindow(/* [in] */ IntPtr hwnd);
        
        [PreserveSig]
        HRESULT RepaintVideo(/* [in] */ IntPtr hwnd, /* [in] */ IntPtr hdc);
        
        [PreserveSig]
        HRESULT DisplayModeChanged();
        
        [PreserveSig]
        HRESULT GetCurrentImage(/* [out] */ out byte lpDib);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetBorderColor(/* [out] */ out uint lpClr);
        
        [PreserveSig]
        HRESULT SetColorKey(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetColorKey(/* [out] */ out uint lpClr);
    }
}
