// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e56e4cbd-8f70-49d8-a0f8-edb3d6ab9bf2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTimer
    {
        [PreserveSig]
        HRESULT SetTimer(/* [in] */ uint dwFlags, /* [in] */ long llClockTime, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkState, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppunkKey);
        
        [PreserveSig]
        HRESULT CancelTimer(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object punkKey);
    }
}
