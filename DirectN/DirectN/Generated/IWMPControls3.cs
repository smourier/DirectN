// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(7532,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a1d1110e-d545-476a-9a78-ac3e4cb1e6bd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPControls3 : IWMPControls2
    {
        // IWMPControls
        [PreserveSig]
        new HRESULT get_isAvailable(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItem, /* [retval][out] */ out bool pIsAvailable);
        
        [PreserveSig]
        new HRESULT play();
        
        [PreserveSig]
        new HRESULT stop();
        
        [PreserveSig]
        new HRESULT pause();
        
        [PreserveSig]
        new HRESULT fastForward();
        
        [PreserveSig]
        new HRESULT fastReverse();
        
        [PreserveSig]
        new HRESULT get_currentPosition(/* [retval][out] */ out double pdCurrentPosition);
        
        [PreserveSig]
        new HRESULT put_currentPosition(/* [in] */ double dCurrentPosition);
        
        [PreserveSig]
        new HRESULT get_currentPositionString(/* [retval][out] */ out IntPtr pbstrCurrentPosition);
        
        [PreserveSig]
        new HRESULT next();
        
        [PreserveSig]
        new HRESULT previous();
        
        [PreserveSig]
        new HRESULT get_currentItem(/* [retval][out] */ out IWMPMedia ppIWMPMedia);
        
        [PreserveSig]
        new HRESULT put_currentItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        [PreserveSig]
        new HRESULT get_currentMarker(/* [retval][out] */ out long plMarker);
        
        [PreserveSig]
        new HRESULT put_currentMarker(/* [in] */ int lMarker);
        
        [PreserveSig]
        new HRESULT playItem(/* [in] */ IWMPMedia pIWMPMedia);
        
        // IWMPControls2
        [PreserveSig]
        new HRESULT step(/* [in] */ int lStep);
        
        // IWMPControls3
        [PreserveSig]
        HRESULT get_audioLanguageCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getAudioLanguageID(/* [in] */ int lIndex, /* [retval][out] */ out long plLangID);
        
        [PreserveSig]
        HRESULT getAudioLanguageDescription(/* [in] */ int lIndex, /* [retval][out] */ out IntPtr pbstrLangDesc);
        
        [PreserveSig]
        HRESULT get_currentAudioLanguage(/* [retval][out] */ out long plLangID);
        
        [PreserveSig]
        HRESULT put_currentAudioLanguage(/* [in] */ int lLangID);
        
        [PreserveSig]
        HRESULT get_currentAudioLanguageIndex(/* [retval][out] */ out long plIndex);
        
        [PreserveSig]
        HRESULT put_currentAudioLanguageIndex(/* [in] */ int lIndex);
        
        [PreserveSig]
        HRESULT getLanguageName(/* [in] */ int lLangID, /* [retval][out] */ out IntPtr pbstrLangName);
        
        [PreserveSig]
        HRESULT get_currentPositionTimecode(/* [retval][out] */ out IntPtr bstrTimecode);
        
        [PreserveSig]
        HRESULT put_currentPositionTimecode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrTimecode);
    }
}
