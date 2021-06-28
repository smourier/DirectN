// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfmediaengine.h(1605,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("83015ead-b1e6-40d0-a98a-37145ffe1ad1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngineEx : IMFMediaEngine
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
        
        // IMFMediaEngineEx
        [PreserveSig]
        HRESULT SetSourceFromByteStream(/* [annotation][in] _In_ */ IMFByteStream pByteStream, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string pURL);
        
        [PreserveSig]
        HRESULT GetStatistics(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_STATISTIC StatisticID, /* [annotation][out] _Out_ */ [In, Out] PropVariant pStatistic);
        
        [PreserveSig]
        HRESULT UpdateVideoStream(/* optional(MFVideoNormalizedRect) */ IntPtr pSrc, /* optional(tagRECT) */ IntPtr pDst, /* optional(_MFARGB) */ IntPtr pBorderClr);
        
        [PreserveSig]
        void GetBalance();
        
        [PreserveSig]
        HRESULT SetBalance(/* [annotation][in] _In_ */ double balance);
        
        [PreserveSig]
        bool IsPlaybackRateSupported(/* [annotation][in] _In_ */ double rate);
        
        [PreserveSig]
        HRESULT FrameStep(/* [annotation][in] _In_ */ bool Forward);
        
        [PreserveSig]
        HRESULT GetResourceCharacteristics(/* [annotation][out] _Out_ */ out uint pCharacteristics);
        
        [PreserveSig]
        HRESULT GetPresentationAttribute(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvValue);
        
        [PreserveSig]
        HRESULT GetNumberOfStreams(/* [annotation][out] _Out_ */ out uint pdwStreamCount);
        
        [PreserveSig]
        HRESULT GetStreamAttribute(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute, /* [annotation][out] _Out_ */ [In, Out] PropVariant pvValue);
        
        [PreserveSig]
        HRESULT GetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][out] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        HRESULT SetStreamSelection(/* [annotation][in] _In_ */ uint dwStreamIndex, /* [annotation][in] _In_ */ bool Enabled);
        
        [PreserveSig]
        HRESULT ApplyStreamSelections();
        
        [PreserveSig]
        HRESULT IsProtected(/* [annotation][out] _Out_ */ out bool pProtected);
        
        [PreserveSig]
        HRESULT InsertVideoEffect(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pEffect, /* [annotation][in] _In_ */ bool fOptional);
        
        [PreserveSig]
        HRESULT InsertAudioEffect(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pEffect, /* [annotation][in] _In_ */ bool fOptional);
        
        [PreserveSig]
        HRESULT RemoveAllEffects();
        
        [PreserveSig]
        HRESULT SetTimelineMarkerTimer(/* [annotation][in] _In_ */ double timeToFire);
        
        [PreserveSig]
        HRESULT GetTimelineMarkerTimer(/* [annotation][out] _Out_ */ out double pTimeToFire);
        
        [PreserveSig]
        HRESULT CancelTimelineMarkerTimer();
        
        [PreserveSig]
        bool IsStereo3D();
        
        [PreserveSig]
        HRESULT GetStereo3DFramePackingMode(/* [annotation][out] _Out_ */ out MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode);
        
        [PreserveSig]
        HRESULT SetStereo3DFramePackingMode(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_S3D_PACKING_MODE packMode);
        
        [PreserveSig]
        HRESULT GetStereo3DRenderMode(/* [annotation][out] _Out_ */ out _MF3DVideoOutputType outputType);
        
        [PreserveSig]
        HRESULT SetStereo3DRenderMode(/* [annotation][in] _In_ */ _MF3DVideoOutputType outputType);
        
        [PreserveSig]
        HRESULT EnableWindowlessSwapchainMode(/* [annotation][in] _In_ */ bool fEnable);
        
        [PreserveSig]
        HRESULT GetVideoSwapchainHandle(/* [annotation][out] _Out_ */ out IntPtr phSwapchain);
        
        [PreserveSig]
        HRESULT EnableHorizontalMirrorMode(/* [annotation][in] _In_ */ bool fEnable);
        
        [PreserveSig]
        HRESULT GetAudioStreamCategory(/* [annotation][out] _Out_ */ out uint pCategory);
        
        [PreserveSig]
        HRESULT SetAudioStreamCategory(/* [annotation][in] _In_ */ uint category);
        
        [PreserveSig]
        HRESULT GetAudioEndpointRole(/* [annotation][out] _Out_ */ out uint pRole);
        
        [PreserveSig]
        HRESULT SetAudioEndpointRole(/* [annotation][in] _In_ */ uint role);
        
        [PreserveSig]
        HRESULT GetRealTimeMode(/* [annotation][out] _Out_ */ out bool pfEnabled);
        
        [PreserveSig]
        HRESULT SetRealTimeMode(/* [annotation][in] _In_ */ bool fEnable);
        
        [PreserveSig]
        HRESULT SetCurrentTimeEx(/* [annotation][in] _In_ */ double seekTime, /* [annotation][in] _In_ */ MF_MEDIA_ENGINE_SEEK_MODE seekMode);
        
        [PreserveSig]
        HRESULT EnableTimeUpdateTimer(/* [annotation][in] _In_ */ bool fEnableTimer);
    }
}
