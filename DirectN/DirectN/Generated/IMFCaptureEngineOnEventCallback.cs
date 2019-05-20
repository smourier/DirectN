// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfcaptureengine.h(248,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("aeda51c0-9025-4983-9012-de597b88b089"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnEventCallback
    {
        [PreserveSig]
        HRESULT OnEvent(/* [annotation][in] _In_ */ IMFMediaEvent pEvent);
    }
}
