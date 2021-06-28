// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(8563,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6c497d62-8919-413c-82db-e935fb3ec584"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlayer4 : IWMPCore3
    {
        // IWMPCore
        [PreserveSig]
        new HRESULT close();
        
        [PreserveSig]
        new HRESULT get_URL(/* [retval][out] */ out IntPtr pbstrURL);
        
        [PreserveSig]
        new HRESULT put_URL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        new HRESULT get_openState(/* [retval][out] */ out WMPOpenState pwmpos);
        
        [PreserveSig]
        new HRESULT get_playState(/* [retval][out] */ out WMPPlayState pwmpps);
        
        [PreserveSig]
        new HRESULT get_controls(/* [retval][out] */ out IWMPControls ppControl);
        
        [PreserveSig]
        new HRESULT get_settings(/* [retval][out] */ out IWMPSettings ppSettings);
        
        [PreserveSig]
        new HRESULT get_currentMedia(/* [retval][out] */ out IWMPMedia ppMedia);
        
        [PreserveSig]
        new HRESULT put_currentMedia(/* [in] */ IWMPMedia pMedia);
        
        [PreserveSig]
        new HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppMediaCollection);
        
        [PreserveSig]
        new HRESULT get_playlistCollection(/* [retval][out] */ out IWMPPlaylistCollection ppPlaylistCollection);
        
        [PreserveSig]
        new HRESULT get_versionInfo(/* [retval][out] */ out IntPtr pbstrVersionInfo);
        
        [PreserveSig]
        new HRESULT launchURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        new HRESULT get_network(/* [retval][out] */ out IWMPNetwork ppQNI);
        
        [PreserveSig]
        new HRESULT get_currentPlaylist(/* [retval][out] */ out IWMPPlaylist ppPL);
        
        [PreserveSig]
        new HRESULT put_currentPlaylist(/* [in] */ IWMPPlaylist pPL);
        
        [PreserveSig]
        new HRESULT get_cdromCollection(/* [retval][out] */ out IWMPCdromCollection ppCdromCollection);
        
        [PreserveSig]
        new HRESULT get_closedCaption(/* [retval][out] */ out IWMPClosedCaption ppClosedCaption);
        
        [PreserveSig]
        new HRESULT get_isOnline(/* [retval][out] */ out bool pfOnline);
        
        [PreserveSig]
        new HRESULT get_error(/* [retval][out] */ out IWMPError ppError);
        
        [PreserveSig]
        new HRESULT get_status(/* [retval][out] */ out IntPtr pbstrStatus);
        
        // IWMPCore2
        [PreserveSig]
        new HRESULT get_dvd(/* [retval][out] */ out IWMPDVD ppDVD);
        
        // IWMPCore3
        [PreserveSig]
        new HRESULT newPlaylist(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [retval][out] */ out IWMPPlaylist ppPlaylist);
        
        [PreserveSig]
        new HRESULT newMedia(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [retval][out] */ out IWMPMedia ppMedia);
        
        // IWMPPlayer4
        [PreserveSig]
        HRESULT get_enabled(/* [retval][out] */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT put_enabled(/* [in] */ bool bEnabled);
        
        [PreserveSig]
        HRESULT get_fullScreen(/* [retval][out] */ out bool pbFullScreen);
        
        [PreserveSig]
        HRESULT put_fullScreen(bool bFullScreen);
        
        [PreserveSig]
        HRESULT get_enableContextMenu(/* [retval][out] */ out bool pbEnableContextMenu);
        
        [PreserveSig]
        HRESULT put_enableContextMenu(bool bEnableContextMenu);
        
        [PreserveSig]
        HRESULT put_uiMode(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMode);
        
        [PreserveSig]
        HRESULT get_uiMode(/* [retval][out] */ out IntPtr pbstrMode);
        
        [PreserveSig]
        HRESULT get_stretchToFit(/* [retval][out] */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT put_stretchToFit(/* [in] */ bool bEnabled);
        
        [PreserveSig]
        HRESULT get_windowlessVideo(/* [retval][out] */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT put_windowlessVideo(/* [in] */ bool bEnabled);
        
        [PreserveSig]
        HRESULT get_isRemote(/* [retval][out] */ out bool pvarfIsRemote);
        
        [PreserveSig]
        HRESULT get_playerApplication(/* [retval][out] */ out IWMPPlayerApplication ppIWMPPlayerApplication);
        
        [PreserveSig]
        HRESULT openPlayer(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
    }
}
