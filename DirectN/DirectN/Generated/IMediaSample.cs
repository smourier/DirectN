// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(2758,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("56a8689a-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaSample
    {
        [PreserveSig]
        HRESULT GetPointer(/* [annotation][out] _Outptr_result_buffer_to_(_Inexpressible_(this->GetSize()), _Inexpressible_(this->GetActualDataLength())) */ out byte[] ppBuffer);
        
        [PreserveSig]
        void GetSize();
        
        [PreserveSig]
        HRESULT GetTime(/* [annotation][out] _Out_ */ out long pTimeStart, /* [annotation][out] _Out_ */ out long pTimeEnd);
        
        [PreserveSig]
        HRESULT SetTime(/* [annotation][in] _In_opt_ */ ref long pTimeStart, /* [annotation][in] _In_opt_ */ ref long pTimeEnd);
        
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
        HRESULT GetMediaType(/* [annotation][out] _Out_ */ out _AMMediaType ppMediaType);
        
        [PreserveSig]
        HRESULT SetMediaType(/* [annotation][in] _In_ */ ref _AMMediaType pMediaType);
        
        [PreserveSig]
        HRESULT IsDiscontinuity();
        
        [PreserveSig]
        HRESULT SetDiscontinuity(bool bDiscontinuity);
        
        [PreserveSig]
        HRESULT GetMediaTime(/* [annotation][out] _Out_ */ out long pTimeStart, /* [annotation][out] _Out_ */ out long pTimeEnd);
        
        [PreserveSig]
        HRESULT SetMediaTime(/* [annotation][in] _In_opt_ */ ref long pTimeStart, /* [annotation][in] _In_opt_ */ ref long pTimeEnd);
    }
}
