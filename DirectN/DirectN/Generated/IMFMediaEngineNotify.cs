// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(748,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fee7c112-e776-42b5-9bbf-0048524e2bd5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineNotify
    {
        [PreserveSig]
        HRESULT EventNotify(/* [annotation][in] _In_ */ uint @event, /* [annotation][in] _In_ */ ulong param1, /* [annotation][in] _In_ */ uint param2);
    }
}
