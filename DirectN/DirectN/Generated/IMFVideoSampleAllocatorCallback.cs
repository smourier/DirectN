// generated from <Windows SDK Path>\um\mfidl.h
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
