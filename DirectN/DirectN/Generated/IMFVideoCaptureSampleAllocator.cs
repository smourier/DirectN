// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(22947,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("725b77c7-ca9f-4fe5-9d72-9946bf9b3c70"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoCaptureSampleAllocator : IMFVideoSampleAllocator
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
        
        // IMFVideoCaptureSampleAllocator
        [PreserveSig]
        HRESULT InitializeCaptureSampleAllocator(/* [annotation][in] _In_ */ uint cbSampleSize, /* [annotation][in] _In_ */ uint cbCaptureMetadataSize, /* [annotation][in] _In_ */ uint cbAlignment, /* [annotation][in] _In_ */ uint cMinimumSamples, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][in] _In_ */ IMFMediaType pMediaType);
    }
}
