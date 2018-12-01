// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(2936,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("992388b4-3372-4f67-8b6f-c84c071f4751"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorCallback
    {
        [PreserveSig]
        HRESULT SetCallback(/* [unique][in] */ IMFVideoSampleAllocatorNotify pNotify);
        
        [PreserveSig]
        HRESULT GetFreeSampleCount(/* [out] */ out int plSamples);
    }
}
