// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2347d60b-3fb5-480c-8803-8df3adcd3ef0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRealTimeClient
    {
        [PreserveSig]
        HRESULT RegisterThreads(/* [in] */ uint dwTaskIndex, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass);
        
        [PreserveSig]
        HRESULT UnregisterThreads();
        
        [PreserveSig]
        HRESULT SetWorkQueue(/* [in] */ uint dwWorkQueueId);
    }
}
