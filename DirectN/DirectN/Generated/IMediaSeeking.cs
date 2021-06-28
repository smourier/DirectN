// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(4023,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("36b73880-c2c8-11cf-8b46-00805f6cef60"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
        HRESULT ConvertTimeFormat(/* [annotation][out] _Out_ */ out long pTarget, /* optional(GUID) */ IntPtr pTargetFormat, /* [in] */ long Source, /* optional(GUID) */ IntPtr pSourceFormat);
        
        [PreserveSig]
        HRESULT SetPositions(/* optional(LONGLONG) */ IntPtr pCurrent, /* [in] */ uint dwCurrentFlags, /* optional(LONGLONG) */ IntPtr pStop, /* [in] */ uint dwStopFlags);
        
        [PreserveSig]
        HRESULT GetPositions(/* optional(LONGLONG) */ IntPtr pCurrent, /* optional(LONGLONG) */ IntPtr pStop);
        
        [PreserveSig]
        HRESULT GetAvailable(/* optional(LONGLONG) */ IntPtr pEarliest, /* optional(LONGLONG) */ IntPtr pLatest);
        
        [PreserveSig]
        HRESULT SetRate(/* [in] */ double dRate);
        
        [PreserveSig]
        HRESULT GetRate(/* [annotation][out] _Out_ */ out double pdRate);
        
        [PreserveSig]
        HRESULT GetPreroll(/* [annotation][out] _Out_ */ out long pllPreroll);
    }
}
