// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfreadwrite.h(1206,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("3137f1cd-fe5e-4805-a5d8-fb477448cb3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSinkWriter
    {
        [PreserveSig]
        HRESULT AddStream(/* [annotation][in] _In_ */ IMFMediaType pTargetMediaType, /* [annotation][out] _Out_ */ out uint pdwStreamIndex);
        
        [PreserveSig]
        HRESULT SetInputMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFMediaType pInputMediaType, /* [annotation][in] _In_opt_ */ IMFAttributes pEncodingParameters);
        
        [PreserveSig]
        HRESULT BeginWriting();
        
        [PreserveSig]
        HRESULT WriteSample(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IMFSample pSample);
        
        [PreserveSig]
        HRESULT SendStreamTick(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ long llTimestamp);
        
        [PreserveSig]
        HRESULT PlaceMarker(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ IntPtr pvContext);
        
        [PreserveSig]
        HRESULT NotifyEndOfSegment(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT Flush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT Finalize();
        
        [PreserveSig]
        HRESULT GetServiceForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT GetStatistics(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out _MF_SINK_WRITER_STATISTICS pStats);
    }
}
