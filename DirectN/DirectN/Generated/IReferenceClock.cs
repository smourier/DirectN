// generated from <Windows SDK Path>\um\dsound.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("56a86897-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IReferenceClock
    {
        [PreserveSig]
        HRESULT GetTime(/* THIS_ _Out_ */ out REFERENCE_TIME pTime);
        
        [PreserveSig]
        HRESULT AdviseTime(long rtBaseTime, long rtStreamTime, IntPtr hEvent, /* _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        HRESULT AdvisePeriodic(long rtStartTime, long rtPeriodTime, IntPtr hSemaphore, /* _Out_ */ out IntPtr pdwAdviseCookie);
        
        [PreserveSig]
        HRESULT Unadvise(IntPtr dwAdviseCookie);
    }
}
