// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(3081,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("679409c0-99f7-11d3-9fb7-00105aa620bb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlaylistArray
    {
        [PreserveSig]
        HRESULT get_count(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT item(/* [in] */ int lIndex, /* [retval][out] */ out IWMPPlaylist ppItem);
    }
}
