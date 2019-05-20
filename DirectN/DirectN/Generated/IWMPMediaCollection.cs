// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmp.h(2815,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8363bc22-b4b4-4b19-989d-1cd765749dd1"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPMediaCollection
    {
        [PreserveSig]
        HRESULT add(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrURL, /* [retval][out] */ out IWMPMedia ppItem);
        
        [PreserveSig]
        HRESULT getAll(/* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT getByName(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT getByGenre(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrGenre, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT getByAuthor(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAuthor, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT getByAlbum(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAlbum, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT getByAttribute(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrValue, /* [retval][out] */ out IWMPPlaylist ppMediaItems);
        
        [PreserveSig]
        HRESULT remove(/* [in] */ IWMPMedia pItem, /* [in] */ bool varfDeleteFile);
        
        [PreserveSig]
        HRESULT getAttributeStringCollection(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrAttribute, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrMediaType, /* [retval][out] */ out IWMPStringCollection ppStringCollection);
        
        [PreserveSig]
        HRESULT getMediaAtom(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrItemName, /* [retval][out] */ out long plAtom);
        
        [PreserveSig]
        HRESULT setDeleted(/* [in] */ IWMPMedia pItem, /* [in] */ bool varfIsDeleted);
        
        [PreserveSig]
        HRESULT isDeleted(/* [in] */ IWMPMedia pItem, /* [retval][out] */ out bool pvarfIsDeleted);
    }
}
