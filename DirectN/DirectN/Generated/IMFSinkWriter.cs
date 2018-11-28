using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3137f1cd-fe5e-4805-a5d8-fb477448cb3d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSinkWriter
    {
        [PreserveSig]
        HRESULT AddStream(IMFMediaType pTargetMediaType, out int pdwStreamIndex);

        [PreserveSig]
        HRESULT SetInputMediaType(int dwStreamIndex, IMFMediaType pInputMediaType, IMFAttributes pEncodingParameters);

        [PreserveSig]
        HRESULT BeginWriting();

        [PreserveSig]
        HRESULT WriteSample(int dwStreamIndex, IMFSample pSample);

        [PreserveSig]
        HRESULT SendStreamTick(int dwStreamIndex, long llTimestamp);

        [PreserveSig]
        HRESULT PlaceMarker(int dwStreamIndex, IntPtr pvContext);

        [PreserveSig]
        HRESULT NotifyEndOfSegment(int dwStreamIndex);

        [PreserveSig]
        HRESULT Flush(int dwStreamIndex);

        [PreserveSig]
        HRESULT Finalize();

        [PreserveSig]
        HRESULT GetServiceForStream(int dwStreamIndex, [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);

        [PreserveSig]
        HRESULT GetStatistics(int dwStreamIndex, out MF_SINK_WRITER_STATISTICS pStats);
    }
}
