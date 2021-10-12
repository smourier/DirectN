// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(9457,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ca86aa50-c46e-429e-ab27-16d6ac6844cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSampleGrabberSinkCallback2 : IMFSampleGrabberSinkCallback
    {
        // IMFClockStateSink
        [PreserveSig]
        new HRESULT OnClockStart(/* [in] */ long hnsSystemTime, /* [in] */ long llClockStartOffset);
        
        [PreserveSig]
        new HRESULT OnClockStop(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        new HRESULT OnClockPause(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        new HRESULT OnClockRestart(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        new HRESULT OnClockSetRate(/* [in] */ long hnsSystemTime, /* [in] */ float flRate);
        
        // IMFSampleGrabberSinkCallback
        [PreserveSig]
        new HRESULT OnSetPresentationClock(/* [in] */ IMFPresentationClock pPresentationClock);
        
        [PreserveSig]
        new HRESULT OnProcessSample(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMajorMediaType, /* [in] */ uint dwSampleFlags, /* [in] */ long llSampleTime, /* [in] */ long llSampleDuration, /* [annotation][in] _In_reads_bytes_(dwSampleSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] pSampleBuffer, /* [in] */ int dwSampleSize);
        
        [PreserveSig]
        new HRESULT OnShutdown();
        
        // IMFSampleGrabberSinkCallback2
        [PreserveSig]
        HRESULT OnProcessSampleEx(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMajorMediaType, /* [in] */ uint dwSampleFlags, /* [in] */ long llSampleTime, /* [in] */ long llSampleDuration, /* [annotation][in] _In_reads_bytes_(dwSampleSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] pSampleBuffer, /* [in] */ int dwSampleSize, /* [annotation][in] _In_ */ IMFAttributes pAttributes);
    }
}
