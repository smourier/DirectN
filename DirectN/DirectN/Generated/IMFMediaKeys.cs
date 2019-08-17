// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfmediaengine.h(4494,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("5cb31c05-61ff-418f-afda-caaf41421a38"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaKeys
    {
        [PreserveSig]
        HRESULT CreateSession(/* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.BStr)] string mimeType, /* [annotation] _In_reads_bytes_opt_(cb) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] byte[] initData, /* [annotation] _In_opt_ */ int cb, /* [annotation] _In_reads_bytes_opt_(cbCustomData) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] customData, /* [annotation] _In_ */ int cbCustomData, /* [annotation] _In_ */ IMFMediaKeySessionNotify notify, /* [annotation] _COM_Outptr_ */ out IMFMediaKeySession ppSession);
        
        [PreserveSig]
        HRESULT get_KeySystem(/* [annotation] _COM_Outptr_ */ out IntPtr keySystem);
        
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT GetSuspendNotify(/* [annotation] _COM_Outptr_ */ out IMFCdmSuspendNotify notify);
    }
}
