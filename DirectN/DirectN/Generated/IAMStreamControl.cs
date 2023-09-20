// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("36b73881-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMStreamControl
    {
        [PreserveSig]
        HRESULT StartAt(/* optional(REFERENCE_TIME) */ IntPtr ptStart, /* [in] */ uint dwCookie);
        
        [PreserveSig]
        HRESULT StopAt(/* optional(REFERENCE_TIME) */ IntPtr ptStop, /* [in] */ bool bSendExtra, /* [in] */ uint dwCookie);
        
        [PreserveSig]
        HRESULT GetInfo(/* [annotation][out] _Out_ */ out AM_STREAM_INFO pInfo);
    }
}
