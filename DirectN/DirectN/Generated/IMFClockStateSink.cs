// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(5680,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("f6696e82-74f7-4f3d-a178-8a5e09c3659f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFClockStateSink
    {
        [PreserveSig]
        HRESULT OnClockStart(/* [in] */ long hnsSystemTime, /* [in] */ long llClockStartOffset);
        
        [PreserveSig]
        HRESULT OnClockStop(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        HRESULT OnClockPause(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        HRESULT OnClockRestart(/* [in] */ long hnsSystemTime);
        
        [PreserveSig]
        HRESULT OnClockSetRate(/* [in] */ long hnsSystemTime, /* [in] */ float flRate);
    }
}
