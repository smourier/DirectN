// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfcaptureengine.h(562,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3323b55a-f92a-4fe2-8edc-e9bfc0634d77"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureRecordSink : IMFCaptureSink
    {
        // IMFCaptureSink
        [PreserveSig]
        new HRESULT GetOutputMediaType(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][out] _Out_opt_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT GetService(/* [annotation][in] _In_ */ uint dwSinkStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid rguidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown);
        
        [PreserveSig]
        new HRESULT AddStream(/* [annotation][in] _In_ */ uint dwSourceStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pAttributes, /* [annotation][out] _Out_opt_ */ out uint pdwSinkStreamIndex);
        
        [PreserveSig]
        new HRESULT Prepare();
        
        [PreserveSig]
        new HRESULT RemoveAllStreams();
        
        // IMFCaptureRecordSink
        [PreserveSig]
        HRESULT SetOutputByteStream(/* [annotation][in] _In_ */ IMFByteStream pByteStream, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerType);
        
        [PreserveSig]
        HRESULT SetOutputFileName(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string fileName);
        
        [PreserveSig]
        HRESULT SetSampleCallback(/* [annotation][in] _In_ */ uint dwStreamSinkIndex, /* [annotation][in] _In_ */ IMFCaptureEngineOnSampleCallback pCallback);
        
        [PreserveSig]
        HRESULT SetCustomSink(/* [annotation][in] _In_ */ IMFMediaSink pMediaSink);
        
        [PreserveSig]
        HRESULT GetRotation(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out uint pdwRotationValue);
        
        [PreserveSig]
        HRESULT SetRotation(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwRotationValue);
    }
}
