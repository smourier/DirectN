// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("679409c0-99f7-11d3-9fb7-00105aa620bb"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPPlaylistArray
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IWMPPlaylist ppItem);
    }
}
