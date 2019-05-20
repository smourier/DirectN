// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\amvideo.h(221,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IBaseVideoMixer
    {
        [PreserveSig]
        HRESULT SetLeadPin(int iPin);
        
        [PreserveSig]
        HRESULT GetLeadPin(/* THIS_ _Out_ */ out int piPin);
        
        [PreserveSig]
        HRESULT GetInputPinCount(/* THIS_ _Out_ */ out int piPinCount);
        
        [PreserveSig]
        HRESULT IsUsingClock(/* THIS_ _Out_ */ out int pbValue);
        
        [PreserveSig]
        HRESULT SetUsingClock(int bValue);
        
        [PreserveSig]
        HRESULT GetClockPeriod(/* THIS_ _Out_ */ out int pbValue);
        
        [PreserveSig]
        HRESULT SetClockPeriod(int bValue);
    }
}
