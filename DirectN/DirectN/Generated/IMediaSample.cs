// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;
using REFERENCE_TIME = System.Int64;

namespace DirectN
{
    [ComImport, Guid("56a8689a-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaSample
    {
        [PreserveSig]
        HRESULT GetPointer(/* [annotation][out] _Outptr_result_buffer_to_(_Inexpressible_(this->GetSize()), _Inexpressible_(this->GetActualDataLength())) */ out IntPtr ppBuffer);
        
        [PreserveSig]
        void GetSize();
        
        [PreserveSig]
        HRESULT GetTime(/* [annotation][out] _Out_ */ out REFERENCE_TIME pTimeStart, /* [annotation][out] _Out_ */ out REFERENCE_TIME pTimeEnd);
        
        [PreserveSig]
        HRESULT SetTime(/* optional(REFERENCE_TIME) */ IntPtr pTimeStart, /* optional(REFERENCE_TIME) */ IntPtr pTimeEnd);
        
        [PreserveSig]
        HRESULT IsSyncPoint();
        
        [PreserveSig]
        HRESULT SetSyncPoint(bool bIsSyncPoint);
        
        [PreserveSig]
        HRESULT IsPreroll();
        
        [PreserveSig]
        HRESULT SetPreroll(bool bIsPreroll);
        
        [PreserveSig]
        void GetActualDataLength();
        
        [PreserveSig]
        HRESULT SetActualDataLength(int __MIDL__IMediaSample0000);
        
        [PreserveSig]
        HRESULT GetMediaType(/* [annotation][out] _Out_ */ out IntPtr ppMediaType);
        
        [PreserveSig]
        HRESULT SetMediaType(/* [annotation][in] _In_ */ ref _AMMediaType pMediaType);
        
        [PreserveSig]
        HRESULT IsDiscontinuity();
        
        [PreserveSig]
        HRESULT SetDiscontinuity(bool bDiscontinuity);
        
        [PreserveSig]
        HRESULT GetMediaTime(/* [annotation][out] _Out_ */ out long pTimeStart, /* [annotation][out] _Out_ */ out long pTimeEnd);
        
        [PreserveSig]
        HRESULT SetMediaTime(/* optional(LONGLONG) */ IntPtr pTimeStart, /* optional(LONGLONG) */ IntPtr pTimeEnd);
    }
}
