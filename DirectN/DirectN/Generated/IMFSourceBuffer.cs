// generated from <Windows SDK Path>\um\mfmediaengine.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceBuffer
    {
        [PreserveSig]
        bool GetUpdating();
        
        [PreserveSig]
        HRESULT GetBuffered(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppBuffered);
        
        [PreserveSig]
        void GetTimeStampOffset();
        
        [PreserveSig]
        HRESULT SetTimeStampOffset(/* [annotation][in] _In_ */ double offset);
        
        [PreserveSig]
        void GetAppendWindowStart();
        
        [PreserveSig]
        HRESULT SetAppendWindowStart(/* [annotation][in] _In_ */ double time);
        
        [PreserveSig]
        void GetAppendWindowEnd();
        
        [PreserveSig]
        HRESULT SetAppendWindowEnd(/* [annotation][in] _In_ */ double time);
        
        [PreserveSig]
        HRESULT Append(/* [annotation][in] _In_reads_bytes_(len) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pData, /* [annotation][in] _In_ */ int len);
        
        [PreserveSig]
        HRESULT AppendByteStream(/* [annotation][in] _In_ */ IMFByteStream pStream, /* optional(DWORDLONG) */ IntPtr pMaxLen);
        
        [PreserveSig]
        HRESULT Abort();
        
        [PreserveSig]
        HRESULT Remove(/* [annotation][in] _In_ */ double start, /* [annotation][in] _In_ */ double end);
    }
}
