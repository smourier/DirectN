// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(10972,5)
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
