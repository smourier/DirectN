// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmp.h(5582,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("bc17e5b7-7561-4c18-bb90-17d485775659"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPCore2 : IWMPCore
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
        HRESULT get_dvd(/* [retval][out] */ out IWMPDVD ppDVD);
    }
}
