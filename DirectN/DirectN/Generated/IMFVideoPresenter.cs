// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\evr.h(732,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("29aff080-182a-4a5d-af3b-448f3a6346cb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoPresenter : IMFClockStateSink
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
        
        // IMFVideoPresenter
        [PreserveSig]
        HRESULT ProcessMessage(MFVP_MESSAGE_TYPE eMessage, ulong ulParam);
        
        [PreserveSig]
        HRESULT GetCurrentMediaType(/* [annotation][out] _Outptr_ */ out IMFVideoMediaType ppMediaType);
    }
}
