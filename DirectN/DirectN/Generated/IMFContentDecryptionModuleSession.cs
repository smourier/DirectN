// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcontentdecryptionmodule.h(107,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("4e233efd-1dd2-49e8-b577-d63eee4c0d33"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModuleSession
    {
        [PreserveSig]
        HRESULT GetSessionId(/* [out] __RPC__deref_out_opt */ out IntPtr sessionId);
        
        [PreserveSig]
        HRESULT GetExpiration(/* [out] __RPC__out */ out double expiration);
        
        [PreserveSig]
        HRESULT GetKeyStatuses(/* optional(MFMediaKeyStatus) */ out IntPtr keyStatuses, /* [out] __RPC__out */ out uint numKeyStatuses);
        
        [PreserveSig]
        HRESULT Load(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string sessionId, /* [out] __RPC__out */ out bool loaded);
        
        [PreserveSig]
        HRESULT GenerateRequest(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string initDataType, /* [size_is][in] __RPC__in_ecount_full(initDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] initData, /* [in] */ int initDataSize);
        
        [PreserveSig]
        HRESULT Update(/* [size_is][in] __RPC__in_ecount_full(responseSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] response, /* [in] */ int responseSize);
        
        [PreserveSig]
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Remove();
    }
}
