// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(343,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a38d9567-5a9c-4f3c-b293-8eb415b279ba"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoDeviceID
    {
        [PreserveSig]
        HRESULT GetDeviceID(/* [annotation][out] _Out_ */ out Guid pDeviceID);
    }
}
