// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmp.h(8106,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("40897764-ceab-47be-ad4a-8e28537f9bbf"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPPlayerApplication
    {
        [PreserveSig]
        HRESULT switchToPlayerApplication();
        
        [PreserveSig]
        HRESULT switchToControl();
        
        [PreserveSig]
        HRESULT get_playerDocked(/* [retval][out] */ out VARIANT_BOOL pbPlayerDocked);
        
        [PreserveSig]
        HRESULT get_hasDisplay(/* [retval][out] */ out VARIANT_BOOL pbHasDisplay);
    }
}
