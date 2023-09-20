// generated from <Windows SDK Path>\um\mmdeviceapi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("41d949ab-9862-444a-80f6-c261334da5eb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IActivateAudioInterfaceCompletionHandler
    {
        [PreserveSig]
        HRESULT ActivateCompleted(/* [annotation][in] _In_ */ IActivateAudioInterfaceAsyncOperation activateOperation);
    }
}
