// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcontentdecryptionmodule.h(357,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("87be986c-10be-4943-bf48-4b54ce1983a2"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModule
    {
        [PreserveSig]
        HRESULT SetContentEnabler(/* [in] __RPC__in_opt */ IMFContentEnabler contentEnabler, /* [in] __RPC__in_opt */ IMFAsyncResult result);
        
        [PreserveSig]
        HRESULT GetSuspendNotify(/* [out] __RPC__deref_out_opt */ out IMFCdmSuspendNotify notify);
        
        [PreserveSig]
        HRESULT SetPMPHostApp(/* [in] __RPC__in_opt */ IMFPMPHostApp pmpHostApp);
        
        [PreserveSig]
        HRESULT CreateSession(/* [in] */ MF_MEDIAKEYSESSION_TYPE sessionType, /* [in] __RPC__in_opt */ IMFContentDecryptionModuleSessionCallbacks callbacks, /* [out] __RPC__deref_out_opt */ out IMFContentDecryptionModuleSession session);
        
        [PreserveSig]
        HRESULT SetServerCertificate(/* [size_is][in] __RPC__in_ecount_full(certificateSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] certificate, /* [in] */ int certificateSize);
        
        [PreserveSig]
        HRESULT CreateTrustedInput(/* [size_is][in] __RPC__in_ecount_full(contentInitDataSize) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] contentInitData, /* [in] */ int contentInitDataSize, /* [out] __RPC__deref_out_opt */ out IMFTrustedInput trustedInput);
        
        [PreserveSig]
        HRESULT GetProtectionSystemIds(/* optional(GUID) */ out IntPtr systemIds, /* [out] __RPC__out */ out uint count);
    }
}
