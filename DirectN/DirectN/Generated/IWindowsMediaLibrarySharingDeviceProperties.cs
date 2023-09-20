// generated from <Windows SDK Path>\um\wmlss.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c4623214-6b06-40c5-a623-b2ff4c076bfd"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public partial interface IWindowsMediaLibrarySharingDeviceProperties
    {
        [PreserveSig]
        HRESULT get_Item(/* [in] */ int index, /* [retval][out] */ out IWindowsMediaLibrarySharingDeviceProperty property);
        
        [PreserveSig]
        HRESULT get_Count(/* [retval][out] */ out int count);
        
        [PreserveSig]
        HRESULT GetProperty(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string name, /* [retval][out] */ out IWindowsMediaLibrarySharingDeviceProperty property);
    }
}
