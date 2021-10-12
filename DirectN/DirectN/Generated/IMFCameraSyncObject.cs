// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfvirtualcamera.h(142,5)
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
