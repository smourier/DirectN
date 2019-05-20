// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\ocidl.h(4224,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9c2cad80-3424-11cf-b670-00aa004cd6d8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IOleInPlaceSiteEx
    {
        [PreserveSig]
        HRESULT OnInPlaceActivateEx(/* [out] __RPC__out */ out bool pfNoRedraw, /* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT OnInPlaceDeactivateEx(/* [in] */ bool fNoRedraw);
        
        [PreserveSig]
        HRESULT RequestUIActivate();
    }
}
