// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmdeviceapi.h(969,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("41d949ab-9862-444a-80f6-c261334da5eb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IActivateAudioInterfaceCompletionHandler
    {
        [PreserveSig]
        HRESULT ActivateCompleted(/* [annotation][in] _In_ */ IActivateAudioInterfaceAsyncOperation activateOperation);
    }
}
