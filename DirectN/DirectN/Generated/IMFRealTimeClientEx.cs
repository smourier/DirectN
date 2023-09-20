// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("03910848-ab16-4611-b100-17b88ae2f248"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFRealTimeClientEx
    {
        [PreserveSig]
        HRESULT RegisterThreadsEx(/* [out][in] __RPC__inout */ ref uint pdwTaskIndex, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string wszClassName, /* [in] */ int lBasePriority);
        
        [PreserveSig]
        HRESULT UnregisterThreads();
        
        [PreserveSig]
        HRESULT SetWorkQueueEx(/* [in] */ uint dwMultithreadedWorkQueueId, /* [in] */ int lWorkItemBasePriority);
    }
}
