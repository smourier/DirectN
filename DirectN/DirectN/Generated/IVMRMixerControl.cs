// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(19226,5)
using System;
using System.Runtime.InteropServices;
using COLORREF = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("1c1a17b0-bed0-415d-974b-dc6696131599"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IVMRMixerControl
    {
        [PreserveSig]
        HRESULT SetAlpha(/* [in] */ uint dwStreamID, /* [in] */ float Alpha);
        
        [PreserveSig]
        HRESULT GetAlpha(/* [in] */ uint dwStreamID, /* [out] */ out float pAlpha);
        
        [PreserveSig]
        HRESULT SetZOrder(/* [in] */ uint dwStreamID, /* [in] */ uint dwZ);
        
        [PreserveSig]
        HRESULT GetZOrder(/* [in] */ uint dwStreamID, /* [out] */ out uint pZ);
        
        [PreserveSig]
        HRESULT SetOutputRect(/* [in] */ uint dwStreamID, /* [in] */ ref _NORMALIZEDRECT pRect);
        
        [PreserveSig]
        HRESULT GetOutputRect(/* [in] */ uint dwStreamID, /* [out] */ out _NORMALIZEDRECT pRect);
        
        [PreserveSig]
        HRESULT SetBackgroundClr(/* [in] */ uint ClrBkg);
        
        [PreserveSig]
        HRESULT GetBackgroundClr(/* [in] */ ref COLORREF lpClrBkg);
        
        [PreserveSig]
        HRESULT SetMixingPrefs(/* [in] */ uint dwMixerPrefs);
        
        [PreserveSig]
        HRESULT GetMixingPrefs(/* [out] */ out uint pdwMixerPrefs);
    }
}
