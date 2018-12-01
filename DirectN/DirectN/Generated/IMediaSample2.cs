// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(3047,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("36b73884-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaSample2 : IMediaSample
    {
        // IMediaSample
        [PreserveSig]
        new HRESULT GetPointer(/* [annotation][out] _Outptr_result_buffer_to_(_Inexpressible_(this->GetSize()), _Inexpressible_(this->GetActualDataLength())) */ out byte[] ppBuffer);
        
        [PreserveSig]
        new void GetSize();
        
        [PreserveSig]
        new HRESULT GetTime(/* [annotation][out] _Out_ */ out long pTimeStart, /* [annotation][out] _Out_ */ out long pTimeEnd);
        
        [PreserveSig]
        new HRESULT SetTime(/* [annotation][in] _In_opt_ */ ref long pTimeStart, /* [annotation][in] _In_opt_ */ ref long pTimeEnd);
        
        [PreserveSig]
        new HRESULT IsSyncPoint();
        
        [PreserveSig]
        new HRESULT SetSyncPoint(bool bIsSyncPoint);
        
        [PreserveSig]
        new HRESULT IsPreroll();
        
        [PreserveSig]
        new HRESULT SetPreroll(bool bIsPreroll);
        
        [PreserveSig]
        new void GetActualDataLength();
        
        [PreserveSig]
        new HRESULT SetActualDataLength(int __MIDL__IMediaSample0000);
        
        [PreserveSig]
        new HRESULT GetMediaType(/* [annotation][out] _Out_ */ out _AMMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT SetMediaType(/* [annotation][in] _In_ */ ref _AMMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT IsDiscontinuity();
        
        [PreserveSig]
        new HRESULT SetDiscontinuity(bool bDiscontinuity);
        
        [PreserveSig]
        new HRESULT GetMediaTime(/* [annotation][out] _Out_ */ out long pTimeStart, /* [annotation][out] _Out_ */ out long pTimeEnd);
        
        [PreserveSig]
        new HRESULT SetMediaTime(/* [annotation][in] _In_opt_ */ ref long pTimeStart, /* [annotation][in] _In_opt_ */ ref long pTimeEnd);
        
        // IMediaSample2
        [PreserveSig]
        HRESULT GetProperties(/* [in] */ uint cbProperties, /* [annotation][size_is][out] _Out_writes_bytes_(cbProperties) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbProperties);
        
        [PreserveSig]
        HRESULT SetProperties(/* [in] */ uint cbProperties, /* [annotation][size_is][in] _In_reads_bytes_(cbProperties) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] byte[] pbProperties);
    }
}
