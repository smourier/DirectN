// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfplay.h(691,5)
using System;
using System.Runtime.InteropServices;
using MFP_MEDIAITEM_CHARACTERISTICS = System.UInt32;

namespace DirectN
{
    [Guid("90eb3e6b-ecbf-45cc-b1da-c6fe3ea70d57"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMediaItem
    {
        [PreserveSig]
        HRESULT GetMediaPlayer(/* [annotation][out] _Out_ */ out IMFPMediaPlayer ppMediaPlayer);
        
        [PreserveSig]
        HRESULT GetURL(/* [annotation][out] _Out_ */ out IntPtr ppwszURL);
        
        [PreserveSig]
        HRESULT GetObjectW(/* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknown);
        
        [PreserveSig]
        HRESULT GetUserData(/* [annotation][out] _Out_ */ out IntPtr pdwUserData);
        
        [PreserveSig]
        HRESULT SetUserData(/* [annotation][in] _In_ */ IntPtr dwUserData);
        
        [PreserveSig]
        HRESULT GetStartStopPosition(/* [annotation][out] _Out_opt_ */ out Guid pguidStartPositionType, /* [annotation][out] _Out_opt_ */ [In, Out] PropVariant pvStartValue, /* [annotation][out] _Out_opt_ */ out Guid pguidStopPositionType, /* [annotation][out] _Out_opt_ */ [In, Out] PropVariant pvStopValue);
        
        [PreserveSig]
        HRESULT SetStartStopPosition(/* optional(GUID) */ IntPtr pguidStartPositionType, /* [annotation][in] _In_opt_ */ [In, Out] PropVariant pvStartValue, /* optional(GUID) */ IntPtr pguidStopPositionType, /* [annotation][in] _In_opt_ */ [In, Out] PropVariant pvStopValue);
        
        [PreserveSig]
        HRESULT HasVideo(/* [annotation][out] _Out_opt_ */ out bool pfHasVideo, /* [annotation][out] _Out_opt_ */ out bool pfSelected);
        
        [PreserveSig]
        HRESULT HasAudio(/* [annotation][out] _Out_opt_ */ out bool pfHasAudio, /* [annotation][out] _Out_opt_ */ out bool pfSelected);
        
        [PreserveSig]
        HRESULT IsProtected(/* [annotation][out] _Out_ */ out bool pfProtected);
        
        [PreserveSig]
        HRESULT GetDuration(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvDurationValue);
        
        [PreserveSig]
        HRESULT GetNumberOfStreams(/* [annotation][out] _Out_ */ out uint pdwStreamCount);
        
        [PreserveSig]
        HRESULT GetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out bool pfEnabled);
        
        [PreserveSig]
        HRESULT SetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ bool fEnabled);
        
        [PreserveSig]
        HRESULT GetStreamAttribute(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvValue);
        
        [PreserveSig]
        HRESULT GetPresentationAttribute(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvValue);
        
        [PreserveSig]
        HRESULT GetCharacteristics(/* [annotation][out] _Out_ */ out MFP_MEDIAITEM_CHARACTERISTICS pCharacteristics);
        
        [PreserveSig]
        HRESULT SetStreamSink(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pMediaSink);
        
        [PreserveSig]
        HRESULT GetMetadata(/* [annotation][out] _Out_ */ out IntPtr ppMetadataStore);
    }
}
