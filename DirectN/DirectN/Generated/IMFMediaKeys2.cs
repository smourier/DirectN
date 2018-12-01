// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(8438,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("45892507-ad66-4de2-83a2-acbb13cd8d43"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeys2 : IMFMediaKeys
    {
        // IMFMediaKeys
        [PreserveSig]
        new HRESULT CreateSession(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string mimeType, /* [annotation] _In_reads_bytes_opt_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] initData, /* [annotation] _In_opt_ */ uint cb, /* [annotation] _In_reads_bytes_opt_(cbCustomData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] customData, /* [annotation] _In_ */ uint cbCustomData, /* [annotation] _In_ */ IMFMediaKeySessionNotify notify, /* [annotation] _COM_Outptr_ */ out IMFMediaKeySession ppSession);
        
        [PreserveSig]
        new HRESULT get_KeySystem(/* [annotation] _COM_Outptr_ */ out IntPtr keySystem);
        
        [PreserveSig]
        new HRESULT Shutdown();
        
        [PreserveSig]
        new HRESULT GetSuspendNotify(/* [annotation] _COM_Outptr_ */ out IMFCdmSuspendNotify notify);
        
        // IMFMediaKeys2
        [PreserveSig]
        HRESULT CreateSession2(/* [annotation] _In_ */ MF_MEDIAKEYSESSION_TYPE eSessionType, /* [annotation] _In_ */ IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2, /* [annotation] _COM_Outptr_ */ out IMFMediaKeySession2 ppSession);
        
        [PreserveSig]
        HRESULT SetServerCertificate(/* [annotation] _In_reads_bytes_opt_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbServerCertificate, /* [annotation] _In_ */ uint cb);
        
        [PreserveSig]
        HRESULT GetDOMException(/* [annotation] _In_ */ HRESULT systemCode, /* [annotation] _Out_ */ out HRESULT code);
    }
}
