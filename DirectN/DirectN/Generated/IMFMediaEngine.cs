// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfmediaengine.h(1048,5)
using System;
using System.Runtime.InteropServices;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("98a1b0bb-03eb-4935-ae7c-93c1fa0e1c93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMediaEngine
    {
        [PreserveSig]
        HRESULT GetError(/* [annotation][out] _Outptr_ */ out IMFMediaError ppError);
        
        [PreserveSig]
        HRESULT SetErrorCode(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_ERR error);
        
        [PreserveSig]
        HRESULT SetSourceElements(/* [annotation][in] _In_ */ IMFMediaEngineSrcElements pSrcElements);
        
        [PreserveSig]
        HRESULT SetSource(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string pUrl);
        
        [PreserveSig]
        HRESULT GetCurrentSource(/* [annotation][out] _Out_ */ out IntPtr ppUrl);
        
        [PreserveSig]
        ushort GetNetworkState();
        
        [PreserveSig]
        MF_MEDIA_ENGINE_PRELOAD GetPreload();
        
        [PreserveSig]
        HRESULT SetPreload(/* [annotation][in] _In_ */ MF_MEDIA_ENGINE_PRELOAD Preload);
        
        [PreserveSig]
        HRESULT GetBuffered(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppBuffered);
        
        [PreserveSig]
        HRESULT Load();
        
        [PreserveSig]
        HRESULT CanPlayType(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.BStr)] string type, /* [annotation][out] _Out_ */ out MF_MEDIA_ENGINE_CANPLAY pAnswer);
        
        [PreserveSig]
        ushort GetReadyState();
        
        [PreserveSig]
        bool IsSeeking();
        
        [PreserveSig]
        void GetCurrentTime();
        
        [PreserveSig]
        HRESULT SetCurrentTime(/* [annotation][in] _In_ */ double seekTime);
        
        [PreserveSig]
        void GetStartTime();
        
        [PreserveSig]
        void GetDuration();
        
        [PreserveSig]
        bool IsPaused();
        
        [PreserveSig]
        void GetDefaultPlaybackRate();
        
        [PreserveSig]
        HRESULT SetDefaultPlaybackRate(/* [annotation][in] _In_ */ double Rate);
        
        [PreserveSig]
        void GetPlaybackRate();
        
        [PreserveSig]
        HRESULT SetPlaybackRate(/* [annotation][in] _In_ */ double Rate);
        
        [PreserveSig]
        HRESULT GetPlayed(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppPlayed);
        
        [PreserveSig]
        HRESULT GetSeekable(/* [annotation][out] _Outptr_ */ out IMFMediaTimeRange ppSeekable);
        
        [PreserveSig]
        bool IsEnded();
        
        [PreserveSig]
        bool GetAutoPlay();
        
        [PreserveSig]
        HRESULT SetAutoPlay(/* [annotation][in] _In_ */ bool AutoPlay);
        
        [PreserveSig]
        bool GetLoop();
        
        [PreserveSig]
        HRESULT SetLoop(/* [annotation][in] _In_ */ bool Loop);
        
        [PreserveSig]
        HRESULT Play();
        
        [PreserveSig]
        HRESULT Pause();
        
        [PreserveSig]
        bool GetMuted();
        
        [PreserveSig]
        HRESULT SetMuted(/* [annotation][in] _In_ */ bool Muted);
        
        [PreserveSig]
        void GetVolume();
        
        [PreserveSig]
        HRESULT SetVolume(/* [annotation][in] _In_ */ double Volume);
        
        [PreserveSig]
        bool HasVideo();
        
        [PreserveSig]
        bool HasAudio();
        
        [PreserveSig]
        HRESULT GetNativeVideoSize(/* [annotation][out] _Out_opt_ */ out uint cx, /* [annotation][out] _Out_opt_ */ out uint cy);
        
        [PreserveSig]
        HRESULT GetVideoAspectRatio(/* [annotation][out] _Out_opt_ */ out uint cx, /* [annotation][out] _Out_opt_ */ out uint cy);
        
        [PreserveSig]
        HRESULT Shutdown();
        
        [PreserveSig]
        HRESULT TransferVideoFrame(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pDstSurf, /* optional(MFVideoNormalizedRect) */ IntPtr pSrc, /* [annotation][in] _In_ */ ref RECT pDst, /* optional(_MFARGB) */ IntPtr pBorderClr);
        
        [PreserveSig]
        HRESULT OnVideoStreamTick(/* [annotation][out] _Out_ */ out long pPts);
    }
}
