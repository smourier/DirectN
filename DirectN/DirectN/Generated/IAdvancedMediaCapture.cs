// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediacapture.h(253,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d0751585-d216-4344-b5bf-463b68f977bb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdvancedMediaCapture
    {
        [PreserveSig]
        HRESULT GetAdvancedMediaCaptureSettings(/* [out] __RPC__deref_out_opt */ out IAdvancedMediaCaptureSettings value);
    }
}
