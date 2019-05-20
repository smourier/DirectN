// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(2640,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("36b73885-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IReferenceClock2 : IReferenceClock
    {
        // IReferenceClock
        [PreserveSig]
        new HRESULT GetTime(/* [annotation][out] _Out_ */ out REFERENCE_TIME pTime);
        
        [PreserveSig]
        new HRESULT AdviseTime(/* [in] */ long baseTime, /* [in] */ long streamTime, /* [in] */ IntPtr hEvent, /* [annotation][out] _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        new HRESULT AdvisePeriodic(/* [in] */ long startTime, /* [in] */ long periodTime, /* [in] */ ulong hSemaphore, /* [annotation][out] _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        new HRESULT Unadvise(/* [in] */ IntPtr dwAdviseCookie);
        
        // IReferenceClock2
    }
}
