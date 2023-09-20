// generated from <Windows SDK Path>\um\wmsdkidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("96406bed-2b2b-11d3-b36b-00c04f6108ff"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMReaderStreamClock
    {
        [PreserveSig]
        HRESULT GetTime(/* [in] */ ref ulong pcnsNow);
        
        [PreserveSig]
        HRESULT SetTimer(/* [in] */ ulong cnsWhen, /* [in] */ IntPtr pvParam, /* [out] */ out uint pdwTimerId);
        
        [PreserveSig]
        HRESULT KillTimer(/* [in] */ uint dwTimerId);
    }
}
