// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(3128,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("992388b4-3372-4f67-8b6f-c84c071f4751"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorCallback
    {
        [PreserveSig]
        HRESULT SetCallback(/* [unique][in] */ IMFVideoSampleAllocatorNotify pNotify);
        
        [PreserveSig]
        HRESULT GetFreeSampleCount(/* [out] */ out int plSamples);
    }
}
