// generated from <Windows SDK Path>\um\mfreadwrite.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7b981cf0-560e-4116-9875-b099895f23d7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSourceReaderEx : IMFSourceReader
    {
        // IMFSourceReader
        [PreserveSig]
        new HRESULT GetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out bool pfSelected);
        
        [PreserveSig]
        new HRESULT SetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ bool fSelected);
        
        [PreserveSig]
        new HRESULT GetNativeMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwMediaTypeIndex, /* [annotation][out] _Out_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT GetCurrentMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out IMFMediaType ppMediaType);
        
        [PreserveSig]
        new HRESULT SetCurrentMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out][in] _Reserved_ */ ref uint pdwReserved, /* [annotation][in] _In_ */ IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT SetCurrentPosition(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidTimeFormat, /* [annotation][in] _In_ */ [In, Out] PROPVARIANT varPosition);
        
        [PreserveSig]
        new HRESULT ReadSample(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwControlFlags, /* optional(DWORD) */ IntPtr pdwActualStreamIndex, /* optional(DWORD) */ IntPtr pdwStreamFlags, /* optional(LONGLONG) */ IntPtr pllTimestamp, /* [annotation][out] _Out_opt_ */ out IMFSample ppSample);
        
        [PreserveSig]
        new HRESULT Flush(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        new HRESULT GetServiceForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidService, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Out_ */ out IntPtr ppvObject);
        
        [PreserveSig]
        new HRESULT GetPresentationAttribute(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidAttribute, /* [annotation][out] _Out_ */ [In, Out] PROPVARIANT pvarAttribute);
        
        // IMFSourceReaderEx
        [PreserveSig]
        HRESULT SetNativeMediaType(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_opt_ */ IMFMediaType pMediaType, /* [annotation][out] _Out_ */ out uint pdwStreamFlags);
        
        [PreserveSig]
        HRESULT AddTransformForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pTransformOrActivate);
        
        [PreserveSig]
        HRESULT RemoveAllTransformsForStream(/* [annotation][in] _In_ */ uint dwStreamIndex);
        
        [PreserveSig]
        HRESULT GetTransformForStream(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ uint dwTransformIndex, /* [annotation][out] _Out_opt_ */ out Guid pGuidCategory, /* [annotation][out] _Out_ */ out IMFTransform ppTransform);
    }
}
