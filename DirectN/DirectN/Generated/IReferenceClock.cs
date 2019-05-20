// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\strmif.h(2410,5)
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [Guid("56a86897-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IReferenceClock
    {
        [PreserveSig]
        HRESULT GetTime(/* [annotation][out] _Out_ */ out REFERENCE_TIME pTime);
        
        [PreserveSig]
        HRESULT AdviseTime(/* [in] */ long baseTime, /* [in] */ long streamTime, /* [in] */ IntPtr hEvent, /* [annotation][out] _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        HRESULT AdvisePeriodic(/* [in] */ long startTime, /* [in] */ long periodTime, /* [in] */ ulong hSemaphore, /* [annotation][out] _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        HRESULT Unadvise(/* [in] */ IntPtr dwAdviseCookie);
    }
}
