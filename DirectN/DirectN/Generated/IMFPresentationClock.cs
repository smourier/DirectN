// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(5345,5)
using System;
using System.Runtime.InteropServices;
using MFTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("868ce85c-8ea9-4f55-ab82-b009a910a805"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPresentationClock : IMFClock
    {
        // IMFClock
        [PreserveSig]
        new HRESULT GetClockCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        new HRESULT GetCorrelatedTime(/* [in] */ uint dwReserved, /* [out] __RPC__out */ out long pllClockTime, /* [out] __RPC__out */ out MFTIME phnsSystemTime);
        
        [PreserveSig]
        new HRESULT GetContinuityKey(/* [out] __RPC__out */ out uint pdwContinuityKey);
        
        [PreserveSig]
        new HRESULT GetState(/* [in] */ uint dwReserved, /* [out] __RPC__out */ out _MFCLOCK_STATE peClockState);
        
        [PreserveSig]
        new HRESULT GetProperties(/* [out] __RPC__out */ out _MFCLOCK_PROPERTIES pClockProperties);
        
        // IMFPresentationClock
        [PreserveSig]
        HRESULT SetTimeSource(/* [in] __RPC__in_opt */ IMFPresentationTimeSource pTimeSource);
        
        [PreserveSig]
        HRESULT GetTimeSource(/* [out] __RPC__deref_out_opt */ out IMFPresentationTimeSource ppTimeSource);
        
        [PreserveSig]
        HRESULT GetTime(/* [out] __RPC__out */ out MFTIME phnsClockTime);
        
        [PreserveSig]
        HRESULT AddClockStateSink(/* [in] __RPC__in_opt */ IMFClockStateSink pStateSink);
        
        [PreserveSig]
        HRESULT RemoveClockStateSink(/* [in] __RPC__in_opt */ IMFClockStateSink pStateSink);
        
        [PreserveSig]
        HRESULT Start(/* [in] */ long llClockStartOffset);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT Pause();
    }
}
