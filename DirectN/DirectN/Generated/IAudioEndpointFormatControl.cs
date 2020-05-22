// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\audioendpoints.h(80,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("784cfd40-9f89-456e-a1a6-873b006a664e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioEndpointFormatControl
    {
        [PreserveSig]
        HRESULT ResetToDefault(/* [annotation][in] _In_ */ uint ResetFlags);
    }
}
