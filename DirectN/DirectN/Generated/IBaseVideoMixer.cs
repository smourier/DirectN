// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\amvideo.h(221,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("61ded640-e912-11ce-a099-00aa00479a58"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
