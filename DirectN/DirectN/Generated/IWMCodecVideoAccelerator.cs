// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmdxva.h(285,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("990641b0-739f-4e94-a808-9888da8f75af"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecVideoAccelerator
    {
        [PreserveSig]
        HRESULT NegotiateConnection(/* [in] */ IAMVideoAccelerator pIAMVA, /* [in] */ ref _DMOMediaType pMediaType);
        
        [PreserveSig]
        HRESULT SetPlayerNotify(/* [in] */ IWMPlayerTimestampHook pHook);
    }
}
