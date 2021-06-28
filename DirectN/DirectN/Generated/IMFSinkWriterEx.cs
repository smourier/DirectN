// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfreadwrite.h(1449,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("588d72ab-5bc1-496a-8714-b70617141b25"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSinkWriterEx : IMFSinkWriter
    {
        // IMFSinkWriter
        [PreserveSig]
        new HRESULT AddStream(/* [annotation][in] _In_ */ IMFMediaType pTargetMediaType, /* [annotation][out] _Out_ */ out uint pdwStreamIndex);
        
        [PreserveSig]
        new HRESULT SetInputMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pInputMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pEncodingParameters);
        
        [PreserveSig]
        new HRESULT BeginWriting();
        
        [PreserveSig]
        new HRESULT WriteSample(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFSample pSample);
        
        [PreserveSig]
        new HRESULT SendStreamTick(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ long llTimestamp);
        
        [PreserveSig]
        new HRESULT PlaceMarker(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IntPtr pvContext);
        
        [PreserveSig]
        new HRESULT NotifyEndOfSegment(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        new HRESULT Flush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        new HRESULT Finalize();
        
        [PreserveSig]
        new HRESULT GetServiceForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        new HRESULT GetStatistics(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out _MF_SINK_WRITER_STATISTICS pStats);
        
        // IMFSinkWriterEx
        [PreserveSig]
        HRESULT GetTransformForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwTransformIndex, /* [annotation][out] _Out_opt_ */ out Guid pGuidCategory, /* [annotation][out] _Out_ */ out IMFTransform ppTransform);
    }
}
