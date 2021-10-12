// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(5500,5)
using System;
using System.Runtime.InteropServices;
using MFTIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("2eb1e945-18b8-4139-9b1a-d5d584818530"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFClock
    {
        [PreserveSig]
        HRESULT GetClockCharacteristics(/* [out] __RPC__out */ out uint pdwCharacteristics);
        
        [PreserveSig]
        HRESULT GetCorrelatedTime(/* [in] */ uint dwReserved, /* [out] __RPC__out */ out long pllClockTime, /* [out] __RPC__out */ out MFTIME phnsSystemTime);
        
        [PreserveSig]
        HRESULT GetContinuityKey(/* [out] __RPC__out */ out uint pdwContinuityKey);
        
        [PreserveSig]
        HRESULT GetState(/* [in] */ uint dwReserved, /* [out] __RPC__out */ out _MFCLOCK_STATE peClockState);
        
        [PreserveSig]
        HRESULT GetProperties(/* [out] __RPC__out */ out _MFCLOCK_PROPERTIES pClockProperties);
    }
}
