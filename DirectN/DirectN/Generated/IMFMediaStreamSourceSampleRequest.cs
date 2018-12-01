// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(16565,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("380b9af9-a85b-4e78-a2af-ea5ce645c6b4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaStreamSourceSampleRequest
    {
        [PreserveSig]
        HRESULT SetSample(/* [in] __RPC__in_opt */ IMFSample value);
    }
}
