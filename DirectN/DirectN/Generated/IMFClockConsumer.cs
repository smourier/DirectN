// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6ef2a662-47c0-4666-b13d-cbb717f2fa2c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFClockConsumer
    {
        [PreserveSig]
        HRESULT SetPresentationClock(/* [in] __RPC__in_opt */ IMFPresentationClock pPresentationClock);
        
        [PreserveSig]
        HRESULT GetPresentationClock(/* [out] __RPC__deref_out_opt */ out IMFPresentationClock ppPresentationClock);
    }
}
