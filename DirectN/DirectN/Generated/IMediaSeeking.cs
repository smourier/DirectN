// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(4023,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("36b73880-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMediaSeeking
    {
        [PreserveSig]
        HRESULT GetCapabilities(/* [annotation][out] _Out_ */ out uint pCapabilities);
        
        [PreserveSig]
        HRESULT CheckCapabilities(/* [out][in] */ ref uint pCapabilities);
        
        [PreserveSig]
        HRESULT IsFormatSupported(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pFormat);
        
        [PreserveSig]
        HRESULT QueryPreferredFormat(/* [annotation][out] _Out_ */ out Guid pFormat);
        
        [PreserveSig]
        HRESULT GetTimeFormatW(/* [annotation][out] _Out_ */ out Guid pFormat);
        
        [PreserveSig]
        HRESULT IsUsingTimeFormat(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pFormat);
        
        [PreserveSig]
        HRESULT SetTimeFormat(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid pFormat);
        
        [PreserveSig]
        HRESULT GetDuration(/* [annotation][out] _Out_ */ out long pDuration);
        
        [PreserveSig]
        HRESULT GetStopPosition(/* [annotation][out] _Out_ */ out long pStop);
        
        [PreserveSig]
        HRESULT GetCurrentPosition(/* [annotation][out] _Out_ */ out long pCurrent);
        
        [PreserveSig]
        HRESULT ConvertTimeFormat(/* [annotation][out] _Out_ */ out long pTarget, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pTargetFormat, /* [in] */ long Source, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pSourceFormat);
        
        [PreserveSig]
        HRESULT SetPositions(/* [annotation][out][in] _Inout_opt_ */ ref long pCurrent, /* [in] */ uint dwCurrentFlags, /* [annotation][out][in] _Inout_opt_ */ ref long pStop, /* [in] */ uint dwStopFlags);
        
        [PreserveSig]
        HRESULT GetPositions(/* [annotation][out] _Out_opt_ */ out long pCurrent, /* [annotation][out] _Out_opt_ */ out long pStop);
        
        [PreserveSig]
        HRESULT GetAvailable(/* [annotation][out] _Out_opt_ */ out long pEarliest, /* [annotation][out] _Out_opt_ */ out long pLatest);
        
        [PreserveSig]
        HRESULT SetRate(/* [in] */ double dRate);
        
        [PreserveSig]
        HRESULT GetRate(/* [annotation][out] _Out_ */ out double pdRate);
        
        [PreserveSig]
        HRESULT GetPreroll(/* [annotation][out] _Out_ */ out long pllPreroll);
    }
}
