// generated from <Windows SDK Path>\um\mfvirtualcamera.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6338b23a-3042-49d2-a3ea-ec0fed815407"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCameraSyncObject
    {
        [PreserveSig]
        HRESULT WaitOnSignal(/* [annotation][in] _In_ */ uint timeOutInMs);
        
        [PreserveSig]
        void Shutdown();
    }
}
