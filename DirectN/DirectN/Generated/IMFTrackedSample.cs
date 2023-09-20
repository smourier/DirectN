// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("245bf8e9-0755-40f7-88a5-ae0f18d55e17"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTrackedSample
    {
        [PreserveSig]
        HRESULT SetAllocator(/* [annotation][in] _In_ */ IMFAsyncCallback pSampleAllocator, /* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkState);
    }
}
