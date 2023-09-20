// generated from <Windows SDK Path>\um\wmdxva.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("990641b0-739f-4e94-a808-9888da8f75af"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCodecVideoAccelerator
    {
        [PreserveSig]
        HRESULT NegotiateConnection(/* [in] */ IAMVideoAccelerator pIAMVA, /* [in] */ ref _DMOMediaType pMediaType);
        
        [PreserveSig]
        HRESULT SetPlayerNotify(/* [in] */ IWMPlayerTimestampHook pHook);
    }
}
