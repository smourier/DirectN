// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(1543,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9104d1ab-80c9-4fed-abf0-2e6417a6df14"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPSettings
    {
        [PreserveSig]
        HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        HRESULT get_autoStart(/* [retval][out] */ out bool pfAutoStart);
        
        [PreserveSig]
        HRESULT put_autoStart(/* [in] */ bool fAutoStart);
        
        [PreserveSig]
        HRESULT get_baseURL(/* [retval][out] */ out IntPtr pbstrBaseURL);
        
        [PreserveSig]
        HRESULT put_baseURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrBaseURL);
        
        [PreserveSig]
        HRESULT get_defaultFrame(/* [retval][out] */ out IntPtr pbstrDefaultFrame);
        
        [PreserveSig]
        HRESULT put_defaultFrame(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrDefaultFrame);
        
        [PreserveSig]
        HRESULT get_invokeURLs(/* [retval][out] */ out bool pfInvokeURLs);
        
        [PreserveSig]
        HRESULT put_invokeURLs(/* [in] */ bool fInvokeURLs);
        
        [PreserveSig]
        HRESULT get_mute(/* [retval][out] */ out bool pfMute);
        
        [PreserveSig]
        HRESULT put_mute(/* [in] */ bool fMute);
        
        [PreserveSig]
        HRESULT get_playCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT put_playCount(/* [in] */ int lCount);
        
        [PreserveSig]
        HRESULT get_rate(/* [retval][out] */ out double pdRate);
        
        [PreserveSig]
        HRESULT put_rate(/* [in] */ double dRate);
        
        [PreserveSig]
        HRESULT get_balance(/* [retval][out] */ out long plBalance);
        
        [PreserveSig]
        HRESULT put_balance(/* [in] */ int lBalance);
        
        [PreserveSig]
        HRESULT get_volume(/* [retval][out] */ out long plVolume);
        
        [PreserveSig]
        HRESULT put_volume(/* [in] */ int lVolume);
        
        [PreserveSig]
        HRESULT getMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode, /* [retval][out] */ out bool pvarfMode);
        
        [PreserveSig]
        HRESULT setMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode, /* [in] */ bool varfMode);
        
        [PreserveSig]
        HRESULT get_enableErrorDialogs(/* [retval][out] */ out bool pfEnableErrorDialogs);
        
        [PreserveSig]
        HRESULT put_enableErrorDialogs(/* [in] */ bool fEnableErrorDialogs);
    }
}
