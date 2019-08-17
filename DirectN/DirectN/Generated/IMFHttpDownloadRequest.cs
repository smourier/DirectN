// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(17635,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f779fddf-26e7-4270-8a8b-b983d1859de0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFHttpDownloadRequest
    {
        [PreserveSig]
        HRESULT AddHeader(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szHeader);
        
        [PreserveSig]
        HRESULT BeginSendRequest(/* [annotation][size_is][in] _In_reads_opt_(cbPayload) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pbPayload, /* [annotation][in] _In_ */ int cbPayload, /* [annotation][in] _In_ */ IMFAsyncCallback pCallback, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndSendRequest(/* [annotation][in] _In_ */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT BeginReceiveResponse(/* [annotation][in] _In_ */ IMFAsyncCallback pCallback, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndReceiveResponse(/* [annotation][in] _In_ */ IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT BeginReadPayload(/* [annotation][size_is][out] _Out_writes_(cb) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pb, /* [annotation][in] _In_ */ int cb, /* [annotation][in] _In_ */ IMFAsyncCallback pCallback, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object punkState);
        
        [PreserveSig]
        HRESULT EndReadPayload(/* [annotation][in] _In_ */ IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out ulong pqwOffset, /* [annotation][out] _Out_ */ out uint pcbRead);
        
        [PreserveSig]
        HRESULT QueryHeader(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string szHeaderName, /* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _Outptr_ */ out IntPtr ppszHeaderValue);
        
        [PreserveSig]
        HRESULT GetURL(/* [annotation][out] _Outptr_ */ out IntPtr ppszURL);
        
        [PreserveSig]
        HRESULT HasNullSourceOrigin(/* [annotation][out] _Out_ */ out bool pfNullSourceOrigin);
        
        [PreserveSig]
        HRESULT GetTimeSeekResult(/* [annotation][out] _Out_ */ out ulong pqwStartTime, /* [annotation][out] _Out_ */ out ulong pqwStopTime, /* [annotation][out] _Out_ */ out ulong pqwDuration);
        
        [PreserveSig]
        HRESULT GetHttpStatus(/* [annotation][out] _Out_ */ out uint pdwHttpStatus);
        
        [PreserveSig]
        HRESULT GetAtEndOfPayload(/* [annotation][out] _Out_ */ out bool pfAtEndOfPayload);
        
        [PreserveSig]
        HRESULT GetTotalLength(/* [annotation][out] _Out_ */ out ulong pqwTotalLength);
        
        [PreserveSig]
        HRESULT GetRangeEndOffset(/* [annotation][out] _Out_ */ out ulong pqwRangeEnd);
        
        [PreserveSig]
        HRESULT Close();
    }
}
