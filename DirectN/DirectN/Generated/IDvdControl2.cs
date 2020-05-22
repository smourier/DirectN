// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(22304,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("33bc7430-eec0-11d2-8201-00a0c9d74842"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdControl2
    {
        [PreserveSig]
        HRESULT PlayTitle(/* [in] */ uint ulTitle, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayChapterInTitle(/* [in] */ uint ulTitle, /* [in] */ uint ulChapter, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayAtTimeInTitle(/* [in] */ uint ulTitle, /* [in] */ ref tagDVD_HMSF_TIMECODE pStartTime, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT Stop();
        
        [PreserveSig]
        HRESULT ReturnFromSubmenu(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayAtTime(/* [in] */ ref tagDVD_HMSF_TIMECODE pTime, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayChapter(/* [in] */ uint ulChapter, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayPrevChapter(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT ReplayChapter(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayNextChapter(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayForwards(/* [in] */ double dSpeed, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayBackwards(/* [in] */ double dSpeed, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT ShowMenu(/* [in] */ tagDVD_MENU_ID MenuID, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT Resume(/* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SelectRelativeButton(__MIDL___MIDL_itf_strmif_0000_0132_0004 buttonDir);
        
        [PreserveSig]
        HRESULT ActivateButton();
        
        [PreserveSig]
        HRESULT SelectButton(/* [in] */ uint ulButton);
        
        [PreserveSig]
        HRESULT SelectAndActivateButton(/* [in] */ uint ulButton);
        
        [PreserveSig]
        HRESULT StillOff();
        
        [PreserveSig]
        HRESULT Pause(/* [in] */ bool bState);
        
        [PreserveSig]
        HRESULT SelectAudioStream(/* [in] */ uint ulAudio, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SelectSubpictureStream(/* [in] */ uint ulSubPicture, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SetSubpictureState(/* [in] */ bool bState, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SelectAngle(/* [in] */ uint ulAngle, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SelectParentalLevel(/* [in] */ uint ulParentalLevel);
        
        [PreserveSig]
        HRESULT SelectParentalCountry(/* [in] */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] bCountry);
        
        [PreserveSig]
        HRESULT SelectKaraokeAudioPresentationMode(/* [in] */ uint ulMode);
        
        [PreserveSig]
        HRESULT SelectVideoModePreference(/* [in] */ uint ulPreferredDisplayMode);
        
        [PreserveSig]
        HRESULT SetDVDDirectory(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszwPath);
        
        [PreserveSig]
        HRESULT ActivateAtPosition(/* [in] */ tagPOINT point);
        
        [PreserveSig]
        HRESULT SelectAtPosition(/* [in] */ tagPOINT point);
        
        [PreserveSig]
        HRESULT PlayChaptersAutoStop(/* [in] */ uint ulTitle, /* [in] */ uint ulChapter, /* [in] */ uint ulChaptersToPlay, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT AcceptParentalLevelChange(/* [in] */ bool bAccept);
        
        [PreserveSig]
        HRESULT SetOption(/* [in] */ __MIDL___MIDL_itf_strmif_0000_0132_0003 flag, /* [in] */ bool fState);
        
        [PreserveSig]
        HRESULT SetState(/* [in] */ IDvdState pState, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT PlayPeriodInTitleAutoStop(/* [in] */ uint ulTitle, /* [in] */ ref tagDVD_HMSF_TIMECODE pStartTime, /* [in] */ ref tagDVD_HMSF_TIMECODE pEndTime, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SetGPRM(/* [in] */ uint ulIndex, /* [in] */ ushort wValue, /* [in] */ uint dwFlags, /* [annotation][out] _Out_ */ out IDvdCmd ppCmd);
        
        [PreserveSig]
        HRESULT SelectDefaultMenuLanguage(/* [in] */ uint Language);
        
        [PreserveSig]
        HRESULT SelectDefaultAudioLanguage(/* [in] */ uint Language, /* [in] */ tagDVD_AUDIO_LANG_EXT audioExtension);
        
        [PreserveSig]
        HRESULT SelectDefaultSubpictureLanguage(/* [in] */ uint Language, /* [in] */ tagDVD_SUBPICTURE_LANG_EXT subpictureExtension);
    }
}
