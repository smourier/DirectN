// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(3417,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a27003cf-2354-4f2a-8d6a-ab7cff15437e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFAsyncCallback
    {
        [PreserveSig]
        HRESULT GetParameters(/* [out] __RPC__out */ out uint pdwFlags, /* [out] __RPC__out */ out uint pdwQueue);
        
        [PreserveSig]
        HRESULT Invoke(/* [in] __RPC__in_opt */ IMFAsyncResult pAsyncResult);
    }
}
