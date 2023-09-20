// generated from <Windows SDK Path>\um\wmp.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8b5050ff-e0a4-4808-b3a8-893a9e1ed894"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMPSyncServices
    {
        [PreserveSig]
        HRESULT get_deviceCount(/* [retval][out] */ out long plCount);
        
        [PreserveSig]
        HRESULT getDevice(/* [in] */ int lIndex, /* [retval][out] */ out IWMPSyncDevice ppDevice);
    }
}
