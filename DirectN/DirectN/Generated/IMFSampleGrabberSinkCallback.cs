// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(8767,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("8c7b80bf-ee42-4b59-b1df-55668e1bdca8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSampleGrabberSinkCallback : IMFClockStateSink
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
        HRESULT OnSetPresentationClock(/* [in] */ IMFPresentationClock pPresentationClock);
        
        [PreserveSig]
        HRESULT OnProcessSample(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMajorMediaType, /* [in] */ uint dwSampleFlags, /* [in] */ long llSampleTime, /* [in] */ long llSampleDuration, /* [annotation][in] _In_reads_bytes_(dwSampleSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] pSampleBuffer, /* [in] */ int dwSampleSize);
        
        [PreserveSig]
        HRESULT OnShutdown();
    }
}
