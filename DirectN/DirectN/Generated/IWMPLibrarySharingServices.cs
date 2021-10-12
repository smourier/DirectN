// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmp.h(11633,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("82cba86b-9f04-474b-a365-d6dd1466e541"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPLibrarySharingServices
    {
        [PreserveSig]
        HRESULT isLibraryShared(/* [retval][out] */ out bool pvbShared);
        
        [PreserveSig]
        HRESULT isLibrarySharingEnabled(/* [retval][out] */ out bool pvbEnabled);
        
        [PreserveSig]
        HRESULT showLibrarySharing();
    }
}
