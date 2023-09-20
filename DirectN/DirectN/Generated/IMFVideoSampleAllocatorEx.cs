// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("545b3a48-3283-4f62-866f-a62d8f598f9f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator
    {
        // IMFVideoSampleAllocator
        [PreserveSig]
        new HRESULT SetDirectXManager(/* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
        
        [PreserveSig]
        new HRESULT UninitializeSampleAllocator();
        
        [PreserveSig]
        new HRESULT InitializeSampleAllocator(/* [in] */ uint cRequestedFrames, /* [in] */ IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT AllocateSample(/* [out] */ out IMFSample ppSample);
        
        // IMFVideoSampleAllocatorEx
        [PreserveSig]
        HRESULT InitializeSampleAllocatorEx(/* [annotation] _In_ */ uint cInitialSamples, /* [annotation] _In_ */ uint cMaximumSamples, /* [annotation] _In_opt_ */ IMFAttributes pAttributes, /* [annotation] _In_ */ IMFMediaType pMediaType);
    }
}
