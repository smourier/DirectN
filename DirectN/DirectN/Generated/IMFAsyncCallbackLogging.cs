// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfobjects.h(3514,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c7a4dca1-f5f0-47b6-b92b-bf0106d25791"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAsyncCallbackLogging : IMFAsyncCallback
    {
        // IMFAsyncCallback
        [PreserveSig]
        new HRESULT GetParameters(/* [out] __RPC__out */ out uint pdwFlags, /* [out] __RPC__out */ out uint pdwQueue);
        
        [PreserveSig]
        new HRESULT Invoke(/* [in] __RPC__in_opt */ IMFAsyncResult pAsyncResult);
        
        // IMFAsyncCallbackLogging
        [PreserveSig]
        void GetObjectPointer();
        
        [PreserveSig]
        uint GetObjectTag();
    }
}
