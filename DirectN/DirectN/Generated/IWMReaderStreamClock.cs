// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\wmsdkidl.h(15015,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("96406bed-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderStreamClock
    {
        [PreserveSig]
        HRESULT GetTime(/* [in] */ ref ulong pcnsNow);
        
        [PreserveSig]
        HRESULT SetTimer(/* [in] */ ulong cnsWhen, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pvParam, /* [out] */ out uint pdwTimerId);
        
        [PreserveSig]
        HRESULT KillTimer(/* [in] */ uint dwTimerId);
    }
}
