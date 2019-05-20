// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(6666,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e56e4cbd-8f70-49d8-a0f8-edb3d6ab9bf2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimer
    {
        [PreserveSig]
        HRESULT SetTimer(/* [in] */ uint dwFlags, /* [in] */ long llClockTime, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppunkKey);
        
        [PreserveSig]
        HRESULT CancelTimer(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkKey);
    }
}
