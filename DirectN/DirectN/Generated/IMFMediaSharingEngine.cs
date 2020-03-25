// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfsharingengine.h(245,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8d3ce1bf-2367-40e0-9eee-40d377cc1b46"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaSharingEngine : IMFMediaEngine
    {
        // IMFMediaEngine
        [PreserveSig]
        new HRESULT GetError(/* [annotation][out] _Outptr_ */ out IMFMediaError ppError);
        
        [PreserveSig]
        new HRESULT SetErrorCode(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_ERR error);
        
        [PreserveSig]
        new HRESULT SetSourceElements(/* [annotation][in] _In_ */ IMFMediaEngineSrcElements pSrcElements);
        
        [PreserveSig]
        new HRESULT SetSource(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string pUrl);
        
        [PreserveSig]
        new HRESULT GetCurrentSource(/* [annotation][out] _Out_ */ out IntPtr ppUrl);
        
        [PreserveSig]
        new ushort GetNetworkState();
        
        [PreserveSig]
        new MF_MEDIA_ENGINE_PRELOAD GetPreload();
        
        [PreserveSig]
        new HRESULT SetPreload(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_PRELOAD Preload);
        
        [PreserveSig]
        new HRESULT GetBuffered(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppBuffered);
        
        [PreserveSig]
        new HRESULT Load();
        
        [PreserveSig]
        new HRESULT CanPlayType(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string type, /* [annotation][out] _Out_ */ out MF_MEDIA_ENGINE_CANPLAY pAnswer);
        
        [PreserveSig]
        new ushort GetReadyState();
        
        [PreserveSig]
        new bool IsSeeking();
        
        [PreserveSig]
        new void GetCurrentTime();
        
        [PreserveSig]
        new HRESULT SetCurrentTime(/* [annotation][in] _In_ */ double seekTime);
        
        [PreserveSig]
        new void GetStartTime();
        
        [PreserveSig]
        new void GetDuration();
        
        [PreserveSig]
        new bool IsPaused();
        
        [PreserveSig]
        new void GetDefaultPlaybackRate();
        
        [PreserveSig]
        new HRESULT SetDefaultPlaybackRate(/* [annotation][in] _In_ */ double Rate);
        
        [PreserveSig]
        new void GetPlaybackRate();
        
        [PreserveSig]
        new HRESULT SetPlaybackRate(/* [annotation][in] _In_ */ double Rate);
        
        [PreserveSig]
        new HRESULT GetPlayed(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppPlayed);
        
        [PreserveSig]
        new HRESULT GetSeekable(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppSeekable);
        
        [PreserveSig]
        new bool IsEnded();
        
        [PreserveSig]
        new bool GetAutoPlay();
        
        [PreserveSig]
        new HRESULT SetAutoPlay(/* [annotation][in] _In_ */ bool AutoPlay);
        
        [PreserveSig]
        new bool GetLoop();
        
        [PreserveSig]
        new HRESULT SetLoop(/* [annotation][in] _In_ */ bool Loop);
        
        [PreserveSig]
        new HRESULT Play();
        
        [PreserveSig]
        new HRESULT Pause();
        
        [PreserveSig]
        new bool GetMuted();
        
        [PreserveSig]
        new HRESULT SetMuted(/* [annotation][in] _In_ */ bool Muted);
        
        [PreserveSig]
        new void GetVolume();
        
        [PreserveSig]
        new HRESULT SetVolume(/* [annotation][in] _In_ */ double Volume);
        
        [PreserveSig]
        new bool HasVideo();
        
        [PreserveSig]
        new bool HasAudio();
        
        [PreserveSig]
        new HRESULT GetNativeVideoSize(/* optional(DWORD) */ IntPtr cx, /* optional(DWORD) */ IntPtr cy);
        
        [PreserveSig]
        new HRESULT GetVideoAspectRatio(/* optional(DWORD) */ IntPtr cx, /* optional(DWORD) */ IntPtr cy);
        
        [PreserveSig]
        new HRESULT Shutdown();
        
        [PreserveSig]
        new HRESULT TransferVideoFrame(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDstSurf, /* optional(MFVideoNormalizedRect) */ IntPtr pSrc, /* [annotation][in] _In_ */ ref tagRECT pDst, /* optional(_MFARGB) */ IntPtr pBorderClr);
        
        [PreserveSig]
        new HRESULT OnVideoStreamTick(/* [annotation][out] _Out_ */ out long pPts);
        
        // IMFMediaSharingEngine
        [PreserveSig]
        HRESULT GetDevice(/* [annotation][out] _Out_ */ out DEVICE_INFO pDevice);
    }
}
