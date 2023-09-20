// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5dfd4b2a-7674-4110-a4e6-8a68fd5f3688"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSinkPreroll
    {
        [PreserveSig]
        HRESULT NotifyPreroll(/* [in] */ long hnsUpcomingStartTime);
    }
}
