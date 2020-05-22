// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfplay.h(156,5)
using System;
using System.Runtime.InteropServices;
using COLORREF = System.UInt32;

namespace DirectN
{
    [Guid("a714590a-58af-430a-85bf-44f5ec838d85"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFPMediaPlayer
    {
        [PreserveSig]
        HRESULT Play();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT FrameStep();
        
        [PreserveSig]
        HRESULT SetPosition(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType, /* [annotation][in] _In_ */ [In, Out] PropVariant pvPositionValue);
        
        [PreserveSig]
        HRESULT GetPosition(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvPositionValue);
        
        [PreserveSig]
        HRESULT GetDuration(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvDurationValue);
        
        [PreserveSig]
        HRESULT SetRate(/* [annotation][in] _In_ */ float flRate);
        
        [PreserveSig]
        HRESULT GetRate(/* [annotation][out] _Out_ */ out float pflRate);
        
        [PreserveSig]
        HRESULT GetSupportedRates(/* [annotation][in] _In_ */ bool fForwardDirection, /* [annotation][out] _Out_ */ out float pflSlowestRate, /* [annotation][out] _Out_ */ out float pflFastestRate);
        
        [PreserveSig]
        HRESULT GetState(/* [annotation][out] _Out_ */ out MFP_MEDIAPLAYER_STATE peState);
        
        [PreserveSig]
        HRESULT CreateMediaItemFromURL(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwszURL, /* [annotation][in] _In_ */ bool fSync, /* [annotation][in] _In_ */ IntPtr dwUserData, /* [annotation][out] _Out_opt_ */ out IMFPMediaItem ppMediaItem);
        
        [PreserveSig]
        HRESULT CreateMediaItemFromObject(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pIUnknownObj, /* [annotation][in] _In_ */ bool fSync, /* [annotation][in] _In_ */ IntPtr dwUserData, /* [annotation][out] _Out_opt_ */ out IMFPMediaItem ppMediaItem);
        
        [PreserveSig]
        HRESULT SetMediaItem(/* [annotation][in] _In_ */ IMFPMediaItem pIMFPMediaItem);
        
        [PreserveSig]
        HRESULT ClearMediaItem();
        
        [PreserveSig]
        HRESULT GetMediaItem(/* [annotation][out] _Out_ */ out IMFPMediaItem ppIMFPMediaItem);
        
        [PreserveSig]
        HRESULT GetVolume(/* [annotation][out] _Out_ */ out float pflVolume);
        
        [PreserveSig]
        HRESULT SetVolume(/* [annotation][in] _In_ */ float flVolume);
        
        [PreserveSig]
        HRESULT GetBalance(/* [annotation][out] _Out_ */ out float pflBalance);
        
        [PreserveSig]
        HRESULT SetBalance(/* [annotation][in] _In_ */ float flBalance);
        
        [PreserveSig]
        HRESULT GetMute(/* [annotation][out] _Out_ */ out bool pfMute);
        
        [PreserveSig]
        HRESULT SetMute(/* [annotation][in] _In_ */ bool fMute);
        
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* optional(tagSIZE) */ IntPtr pszVideo, /* optional(tagSIZE) */ IntPtr pszARVideo);
        
        [PreserveSig]
        HRESULT GetIdealVideoSize(/* optional(tagSIZE) */ IntPtr pszMin, /* optional(tagSIZE) */ IntPtr pszMax);
        
        [PreserveSig]
        HRESULT SetVideoSourceRect(/* [annotation][in] _In_ */ ref MFVideoNormalizedRect pnrcSource);
        
        [PreserveSig]
        HRESULT GetVideoSourceRect(/* [annotation][out] _Out_ */ out MFVideoNormalizedRect pnrcSource);
        
        [PreserveSig]
        HRESULT SetAspectRatioMode(/* [annotation][in] _In_ */ uint dwAspectRatioMode);
        
        [PreserveSig]
        HRESULT GetAspectRatioMode(/* [annotation][out] _Out_ */ out uint pdwAspectRatioMode);
        
        [PreserveSig]
        HRESULT GetVideoWindow(/* [annotation][out] _Out_ */ out IntPtr phwndVideo);
        
        [PreserveSig]
        HRESULT UpdateVideo();
        
        [PreserveSig]
        HRESULT SetBorderColor(/* [annotation][in] _In_ */ uint Clr);
        
        [PreserveSig]
        HRESULT GetBorderColor(/* [annotation][out] _Out_ */ out COLORREF pClr);
        
        [PreserveSig]
        HRESULT InsertEffect(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pEffect, /* [annotation][in] _In_ */ bool fOptional);
        
        [PreserveSig]
        HRESULT RemoveEffect(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pEffect);
        
        [PreserveSig]
        HRESULT RemoveAllEffects();
        
        [PreserveSig]
        HRESULT Shutdown();
    }
}
