// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f90a6130-b658-11d2-ae49-0000f8754b99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMDeviceRemoval
    {
        [PreserveSig]
        HRESULT DeviceInfo(/* [annotation][out] _Out_ */ out Guid pclsidInterfaceClass, /* [annotation][out] _Out_ */ out IntPtr pwszSymbolicLink);
        
        [PreserveSig]
        HRESULT Reassociate();
        
        [PreserveSig]
        HRESULT Disassociate();
    }
}
