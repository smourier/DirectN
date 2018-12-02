// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfcaptureengine.h(1758,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e37ceed7-340f-4514-9f4d-9c2ae026100b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback
    {
        // IMFCaptureEngineOnSampleCallback
        [PreserveSig]
        new HRESULT OnSample(/* optional(IMFSample) */ IntPtr pSample);
        
        // IMFCaptureEngineOnSampleCallback2
        [PreserveSig]
        HRESULT OnSynchronizedEvent(/* [annotation][in] _In_ */ ref IMFMediaEvent pEvent);
    }
}
