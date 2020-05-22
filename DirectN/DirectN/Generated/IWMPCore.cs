// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(3843,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d84cca99-cce2-11d2-9ecc-0000f8085981"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPCore
    {
        [PreserveSig]
        HRESULT close();
        
        [PreserveSig]
        HRESULT get_URL(/* [retval][out] */ out IntPtr pbstrURL);
        
        [PreserveSig]
        HRESULT put_URL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        HRESULT get_openState(/* [retval][out] */ out WMPOpenState pwmpos);
        
        [PreserveSig]
        HRESULT get_playState(/* [retval][out] */ out WMPPlayState pwmpps);
        
        [PreserveSig]
        HRESULT get_controls(/* [retval][out] */ out IWMPControls ppControl);
        
        [PreserveSig]
        HRESULT get_settings(/* [retval][out] */ out IWMPSettings ppSettings);
        
        [PreserveSig]
        HRESULT get_currentMedia(/* [retval][out] */ out IWMPMedia ppMedia);
        
        [PreserveSig]
        HRESULT put_currentMedia(/* [in] */ IWMPMedia pMedia);
        
        [PreserveSig]
        HRESULT get_mediaCollection(/* [retval][out] */ out IWMPMediaCollection ppMediaCollection);
        
        [PreserveSig]
        HRESULT get_playlistCollection(/* [retval][out] */ out IWMPPlaylistCollection ppPlaylistCollection);
        
        [PreserveSig]
        HRESULT get_versionInfo(/* [retval][out] */ out IntPtr pbstrVersionInfo);
        
        [PreserveSig]
        HRESULT launchURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL);
        
        [PreserveSig]
        HRESULT get_network(/* [retval][out] */ out IWMPNetwork ppQNI);
        
        [PreserveSig]
        HRESULT get_currentPlaylist(/* [retval][out] */ out IWMPPlaylist ppPL);
        
        [PreserveSig]
        HRESULT put_currentPlaylist(/* [in] */ IWMPPlaylist pPL);
        
        [PreserveSig]
        HRESULT get_cdromCollection(/* [retval][out] */ out IWMPCdromCollection ppCdromCollection);
        
        [PreserveSig]
        HRESULT get_closedCaption(/* [retval][out] */ out IWMPClosedCaption ppClosedCaption);
        
        [PreserveSig]
        HRESULT get_isOnline(/* [retval][out] */ out bool pfOnline);
        
        [PreserveSig]
        HRESULT get_error(/* [retval][out] */ out IWMPError ppError);
        
        [PreserveSig]
        HRESULT get_status(/* [retval][out] */ out IntPtr pbstrStatus);
    }
}
