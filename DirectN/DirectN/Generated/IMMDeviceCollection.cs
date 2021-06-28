// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmdeviceapi.h(524,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("0bd7a1be-7a1a-44db-8397-cc5392387b5e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMDeviceCollection
    {
        [PreserveSig]
        HRESULT GetCount(/* [annotation][out] _Out_ */ out uint pcDevices);
        
        [PreserveSig]
        HRESULT Item(/* [annotation][in] _In_ */ uint nDevice, /* [annotation][out] _Out_ */ out IMMDevice ppDevice);
    }
}
