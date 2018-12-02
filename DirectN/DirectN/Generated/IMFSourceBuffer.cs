// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(3414,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        HRESULT Append(/* [annotation][in] _In_reads_bytes_(len) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pData, /* [annotation][in] _In_ */ uint len);
        
        [PreserveSig]
        HRESULT AppendByteStream(/* [annotation][in] _In_ */ IMFByteStream pStream, /* optional(DWORDLONG) */ IntPtr pMaxLen);
        
        [PreserveSig]
        HRESULT Abort();
        
        [PreserveSig]
        HRESULT Remove(/* [annotation][in] _In_ */ double start, /* [annotation][in] _In_ */ double end);
    }
}
