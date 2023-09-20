// generated from <Windows SDK Path>\um\wmlss.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3dccc293-4fd9-4191-a25b-8e57c5d27bd4"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWindowsMediaLibrarySharingDevice
    {
        [PreserveSig]
        HRESULT get_DeviceID(/* [retval][out] */ out IntPtr deviceID);
        
        [PreserveSig]
        HRESULT get_Authorization(/* [retval][out] */ out WindowsMediaLibrarySharingDeviceAuthorizationStatus authorization);
        
        [PreserveSig]
        HRESULT put_Authorization(/* [in] */ WindowsMediaLibrarySharingDeviceAuthorizationStatus authorization);
        
        [PreserveSig]
        HRESULT get_Properties(/* [retval][out] */ out IWindowsMediaLibrarySharingDeviceProperties deviceProperties);
    }
}
