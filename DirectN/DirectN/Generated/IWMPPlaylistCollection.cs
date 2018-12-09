// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(3223,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("10a13217-23a7-439b-b1c0-d847c79b7774"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlaylistCollection
    {
        [PreserveSig]
        HRESULT newPlaylist(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [retval][out] */ out IWMPPlaylist ppItem);
        
        [PreserveSig]
        HRESULT getAll(/* [retval][out] */ out IWMPPlaylistArray ppPlaylistArray);
        
        [PreserveSig]
        HRESULT getByName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [retval][out] */ out IWMPPlaylistArray ppPlaylistArray);
        
        [PreserveSig]
        HRESULT remove(/* [in] */ IWMPPlaylist pItem);
        
        [PreserveSig]
        HRESULT setDeleted(/* [in] */ IWMPPlaylist pItem, /* [in] */ short varfIsDeleted);
        
        [PreserveSig]
        HRESULT isDeleted(/* [in] */ IWMPPlaylist pItem, /* [retval][out] */ out VARIANT_BOOL pvarfIsDeleted);
        
        [PreserveSig]
        HRESULT importPlaylist(/* [in] */ IWMPPlaylist pItem, /* [retval][out] */ out IWMPPlaylist ppImportedItem);
    }
}
