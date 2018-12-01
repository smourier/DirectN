// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(8534,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("36b73881-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMStreamControl
    {
        [PreserveSig]
        HRESULT StartAt(/* [annotation][in] _In_opt_ */ ref long ptStart, /* [in] */ uint dwCookie);
        
        [PreserveSig]
        HRESULT StopAt(/* [annotation][in] _In_opt_ */ ref long ptStop, /* [in] */ bool bSendExtra, /* [in] */ uint dwCookie);
        
        [PreserveSig]
        HRESULT GetInfo(/* [annotation][out] _Out_ */ out AM_STREAM_INFO pInfo);
    }
}
