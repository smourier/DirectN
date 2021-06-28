// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(5549,5)
using System;
using System.Runtime.InteropServices;
using MFTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("7ff12cce-f76f-41c2-863b-1666c8e5e139"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPresentationTimeSource : IMFClock
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
        
        // IMFPresentationTimeSource
        [PreserveSig]
        HRESULT GetUnderlyingClock(/* [out] __RPC__deref_out_opt */ out IMFClock ppClock);
    }
}
