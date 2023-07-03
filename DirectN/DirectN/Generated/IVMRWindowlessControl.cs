// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\strmif.h(19962,5)
using System;
using System.Runtime.InteropServices;
using COLORREF = System.UInt32;
using LPRECT = DirectN.tagRECT;

namespace DirectN
{
    [ComImport, Guid("0eb1088c-4dcd-46f0-878f-39dae86a51b7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRWindowlessControl
    {
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* [out] */ out int lpWidth, /* [out] */ out int lpHeight, /* [out] */ out int lpARWidth, /* [out] */ out int lpARHeight);
        
        [PreserveSig]
        HRESULT GetMinIdealVideoSize(/* [out] */ out int lpWidth, /* [out] */ out int lpHeight);
        
        [PreserveSig]
        HRESULT GetMaxIdealVideoSize(/* [out] */ out int lpWidth, /* [out] */ out int lpHeight);
        
        [PreserveSig]
        HRESULT SetVideoPosition(/* [in] */ ref LPRECT lpSRCRect, /* [in] */ ref LPRECT lpDSTRect);
        
        [PreserveSig]
        HRESULT GetVideoPosition(/* [out] */ out tagRECT lpSRCRect, /* [out] */ out tagRECT lpDSTRect);
        
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
        HRESULT GetCurrentImage(/* [out] */ out IntPtr lpDib);
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetBorderColor(/* [out] */ out COLORREF lpClr);
        
        [PreserveSig]
        HRESULT SetColorKey(/* [in] */ uint Clr);
        
        [PreserveSig]
        HRESULT GetColorKey(/* [out] */ out COLORREF lpClr);
    }
}
