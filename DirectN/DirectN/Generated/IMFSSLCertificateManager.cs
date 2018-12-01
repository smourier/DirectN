// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(11691,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("61f7d887-1230-4a8b-aeba-8ad434d1a64d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSSLCertificateManager
    {
        [PreserveSig]
        HRESULT GetClientCertificate(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszURL, /* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*pcbData) */ out IntPtr ppbData, /* [annotation][out] _Out_ */ out uint pcbData);
        
        [PreserveSig]
        HRESULT BeginGetClientCertificate(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszURL, /* [in] */ IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndGetClientCertificate(/* [in] */ IMFAsyncResult pResult, /* [annotation][size_is][size_is][out] _Outptr_result_bytebuffer_(*pcbData) */ out IntPtr ppbData, /* [annotation][out] _Out_ */ out uint pcbData);
        
        [PreserveSig]
        HRESULT GetCertificatePolicy(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszURL, /* [out] */ out bool pfOverrideAutomaticCheck, /* [out] */ out bool pfClientCertificateAvailable);
        
        [PreserveSig]
        HRESULT OnServerCertificate(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszURL, /* [annotation][size_is][in] _In_reads_bytes_(cbData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] pbData, /* [in] */ uint cbData, /* [out] */ out bool pfIsGood);
    }
}
