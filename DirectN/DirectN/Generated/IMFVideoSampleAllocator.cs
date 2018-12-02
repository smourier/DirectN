// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(2652,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("86cbc910-e533-4751-8e3b-f19b5b806a03"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocator
    {
        [PreserveSig]
        HRESULT SetDirectXManager(/* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
        
        [PreserveSig]
        HRESULT UninitializeSampleAllocator();
        
        [PreserveSig]
        HRESULT InitializeSampleAllocator(/* [in] */ uint cRequestedFrames, /* [in] */ ref IMFMediaType pMediaType);
        
        [PreserveSig]
        HRESULT AllocateSample(/* [out] */ out IntPtr ppSample);
    }
}
