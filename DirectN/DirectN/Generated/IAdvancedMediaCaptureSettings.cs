// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediacapture.h(173,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("24e0485f-a33e-4aa1-b564-6019b1d14f65"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAdvancedMediaCaptureSettings
    {
        [PreserveSig]
        HRESULT GetDirectxDeviceManager(/* [out] */ out IMFDXGIDeviceManager value);
    }
}
