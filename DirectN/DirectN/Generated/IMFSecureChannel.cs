// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(14445,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d0ae555d-3b12-4d97-b060-0990bc5aeb67"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSecureChannel
    {
        [PreserveSig]
        HRESULT GetCertificate(/* [annotation][out] _Outptr_result_bytebuffer_(*pcbCert) */ out IntPtr ppCert, /* [annotation][out] _Out_ */ out uint pcbCert);
        
        [PreserveSig]
        HRESULT SetupSession(/* [annotation][in] _In_reads_bytes_(cbSessionKey) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbEncryptedSessionKey, /* [in] */ int cbSessionKey);
    }
}
