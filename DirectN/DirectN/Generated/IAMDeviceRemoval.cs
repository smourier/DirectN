// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(15271,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f90a6130-b658-11d2-ae49-0000f8754b99"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
