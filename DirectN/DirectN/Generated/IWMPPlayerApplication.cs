// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("40897764-ceab-47be-ad4a-8e28537f9bbf"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWMPPlayerApplication
    {
        [PreserveSig]
        HRESULT switchToPlayerApplication();
        
        [PreserveSig]
        HRESULT switchToControl();
        
        [PreserveSig]
        HRESULT get_playerDocked(/* [retval][out] */ out bool pbPlayerDocked);
        
        [PreserveSig]
        HRESULT get_hasDisplay(/* [retval][out] */ out bool pbHasDisplay);
    }
}
