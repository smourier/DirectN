// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmlss.h(626,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1803f9d6-fe6d-4546-bf5b-992fe8ec12d1"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWindowsMediaLibrarySharingDevices
    {
        [PreserveSig]
        HRESULT get_Item(/* [in] */ int index, /* [retval][out] */ out IWindowsMediaLibrarySharingDevice device);
        
        [PreserveSig]
        HRESULT get_Count(/* [retval][out] */ out int count);
        
        [PreserveSig]
        HRESULT GetDevice(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string deviceID, /* [retval][out] */ out IWindowsMediaLibrarySharingDevice device);
    }
}
