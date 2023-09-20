// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8ba957f5-fd8c-4791-b82d-f840401ee474"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPMediaCollection2 : IWMPMediaCollection
    {
        // IWMPMediaCollection
        [PreserveSig]
        new HRESULT add(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [retval][out] */ out IWMPMedia ppItem);
        
        [PreserveSig]
        new HRESULT getAll(/* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT getByName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT getByGenre(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrGenre, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT getByAuthor(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAuthor, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT getByAlbum(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAlbum, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT getByAttribute(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        new HRESULT remove(/* [in] */ IWMPMedia pItem, /* [in] */ bool varfDeleteFile);
        
        [PreserveSig]
        new HRESULT getAttributeStringCollection(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMediaType, /* [retval][out] */ out IWMPStringCollection ppStringCollection);
        
        [PreserveSig]
        new HRESULT getMediaAtom(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out long plAtom);
        
        [PreserveSig]
        new HRESULT setDeleted(/* [in] */ IWMPMedia pItem, /* [in] */ bool varfIsDeleted);
        
        [PreserveSig]
        new HRESULT isDeleted(/* [in] */ IWMPMedia pItem, /* [retval][out] */ out bool pvarfIsDeleted);
        
        // IWMPMediaCollection2
        [PreserveSig]
        HRESULT createQuery(/* [retval][out] */ out IWMPQuery ppQuery);
        
        [PreserveSig]
        HRESULT getPlaylistByQuery(/* [in] */ IWMPQuery pQuery, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMediaType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSortAttribute, /* [in] */ bool fSortAscending, /* [retval][out] */ out IWMPPlaylist ppPlaylist);
        
        [PreserveSig]
        HRESULT getStringCollectionByQuery(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ IWMPQuery pQuery, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMediaType, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrSortAttribute, /* [in] */ bool fSortAscending, /* [retval][out] */ out IWMPStringCollection ppStringCollection);
        
        [PreserveSig]
        HRESULT getByAttributeAndMediaType(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMediaType, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
    }
}
