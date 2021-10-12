// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(24220,5)
using System;
using System.Runtime.InteropServices;
using LCID = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("34151510-eec0-11d2-8201-00a0c9d74842"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdInfo2
    {
        [PreserveSig]
        HRESULT GetCurrentDomain(/* [annotation][out] _Out_ */ out tagDVD_DOMAIN pDomain);
        
        [PreserveSig]
        HRESULT GetCurrentLocation(/* [annotation][out] _Out_ */ out tagDVD_PLAYBACK_LOCATION2 pLocation);
        
        [PreserveSig]
        HRESULT GetTotalTitleTime(/* [annotation][out] _Out_ */ out tagDVD_HMSF_TIMECODE pTotalTime, /* [annotation][out] _Out_ */ out uint ulTimeCodeFlags);
        
        [PreserveSig]
        HRESULT GetCurrentButton(/* [annotation][out] _Out_ */ out uint pulButtonsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentButton);
        
        [PreserveSig]
        HRESULT GetCurrentAngle(/* [annotation][out] _Out_ */ out uint pulAnglesAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentAngle);
        
        [PreserveSig]
        HRESULT GetCurrentAudio(/* [annotation][out] _Out_ */ out uint pulStreamsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentStream);
        
        [PreserveSig]
        HRESULT GetCurrentSubpicture(/* [annotation][out] _Out_ */ out uint pulStreamsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentStream, /* [annotation][out] _Out_ */ out bool pbIsDisabled);
        
        [PreserveSig]
        HRESULT GetCurrentUOPS(/* [annotation][out] _Out_ */ out uint pulUOPs);
        
        [PreserveSig]
        HRESULT GetAllSPRMs(/* [annotation][out] _Out_ */ out IntPtr pRegisterArray);
        
        [PreserveSig]
        HRESULT GetAllGPRMs(/* [annotation][out] _Out_ */ out IntPtr pRegisterArray);
        
        [PreserveSig]
        HRESULT GetAudioLanguage(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out LCID pLanguage);
        
        [PreserveSig]
        HRESULT GetSubpictureLanguage(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out LCID pLanguage);
        
        [PreserveSig]
        HRESULT GetTitleAttributes(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out tagDVD_MenuAttributes pMenu, /* [annotation][out] _Out_ */ out tagDVD_TitleMainAttributes pTitle);
        
        [PreserveSig]
        HRESULT GetVMGAttributes(/* [annotation][out] _Out_ */ out tagDVD_MenuAttributes pATR);
        
        [PreserveSig]
        HRESULT GetCurrentVideoAttributes(/* [annotation][out] _Out_ */ out IntPtr pATR);
        
        [PreserveSig]
        HRESULT GetAudioAttributes(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out tagDVD_AudioAttributes pATR);
        
        [PreserveSig]
        HRESULT GetKaraokeAttributes(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out tagDVD_KaraokeAttributes pAttributes);
        
        [PreserveSig]
        HRESULT GetSubpictureAttributes(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out tagDVD_SubpictureAttributes pATR);
        
        [PreserveSig]
        HRESULT GetDVDVolumeInfo(/* [annotation][out] _Out_ */ out uint pulNumOfVolumes, /* [annotation][out] _Out_ */ out uint pulVolume, /* [annotation][out] _Out_ */ out tagDVD_DISC_SIDE pSide, /* [annotation][out] _Out_ */ out uint pulNumOfTitles);
        
        [PreserveSig]
        HRESULT GetDVDTextNumberOfLanguages(/* [annotation][out] _Out_ */ out uint pulNumOfLangs);
        
        [PreserveSig]
        HRESULT GetDVDTextLanguageInfo(/* [in] */ uint ulLangIndex, /* [annotation][out] _Out_ */ out uint pulNumOfStrings, /* [annotation][out] _Out_ */ out LCID pLangCode, /* [annotation][out] _Out_ */ out DVD_TextCharSet pbCharacterSet);
        
        [PreserveSig]
        HRESULT GetDVDTextStringAsNative(/* [in] */ uint ulLangIndex, /* [in] */ uint ulStringIndex, /* [annotation][out] _Out_ */ out byte pbBuffer, /* [in] */ uint ulMaxBufferSize, /* [annotation][out] _Out_ */ out uint pulActualSize, /* [annotation][out] _Out_ */ out DVD_TextStringType pType);
        
        [PreserveSig]
        HRESULT GetDVDTextStringAsUnicode(/* [in] */ uint ulLangIndex, /* [in] */ uint ulStringIndex, /* [annotation][out] _Out_ */ [MarshalAs(UnmanagedType.LPWStr)] out string pchwBuffer, /* [in] */ uint ulMaxBufferSize, /* [annotation][out] _Out_ */ out uint pulActualSize, /* [annotation][out] _Out_ */ out DVD_TextStringType pType);
        
        [PreserveSig]
        HRESULT GetPlayerParentalLevel(/* [annotation][out] _Out_ */ out uint pulParentalLevel, /* [annotation][out] _Out_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] byte[] pbCountryCode);
        
        [PreserveSig]
        HRESULT GetNumberOfChapters(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out uint pulNumOfChapters);
        
        [PreserveSig]
        HRESULT GetTitleParentalLevels(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out uint pulParentalLevels);
        
        [PreserveSig]
        HRESULT GetDVDDirectory(/* [annotation][size_is][out] _Out_writes_to_(ulMaxSize, *pulActualSize) */ [MarshalAs(UnmanagedType.LPWStr)] string pszwPath, /* [in] */ uint ulMaxSize, /* [annotation][out] _Out_ */ out uint pulActualSize);
        
        [PreserveSig]
        HRESULT IsAudioStreamEnabled(/* [in] */ uint ulStreamNum, /* [annotation][out] _Out_ */ out bool pbEnabled);
        
        [PreserveSig]
        HRESULT GetDiscID(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszwPath, /* [annotation][out] _Out_ */ out ulong pullDiscID);
        
        [PreserveSig]
        HRESULT GetState(/* [annotation][out] _Out_ */ out IDvdState pStateData);
        
        [PreserveSig]
        HRESULT GetMenuLanguages(/* [annotation][out] _Out_ */ out LCID pLanguages, /* [in] */ uint ulMaxLanguages, /* [annotation][out] _Out_ */ out uint pulActualLanguages);
        
        [PreserveSig]
        HRESULT GetButtonAtPosition(/* [in] */ tagPOINT point, /* [annotation][out] _Out_ */ out uint pulButtonIndex);
        
        [PreserveSig]
        HRESULT GetCmdFromEvent(/* [in] */ IntPtr lParam1, /* [annotation][out] _Out_ */ out IDvdCmd pCmdObj);
        
        [PreserveSig]
        HRESULT GetDefaultMenuLanguage(/* [annotation][out] _Out_ */ out LCID pLanguage);
        
        [PreserveSig]
        HRESULT GetDefaultAudioLanguage(/* [annotation][out] _Out_ */ out LCID pLanguage, /* [annotation][out] _Out_ */ out tagDVD_AUDIO_LANG_EXT pAudioExtension);
        
        [PreserveSig]
        HRESULT GetDefaultSubpictureLanguage(/* [annotation][out] _Out_ */ out LCID pLanguage, /* [annotation][out] _Out_ */ out tagDVD_SUBPICTURE_LANG_EXT pSubpictureExtension);
        
        [PreserveSig]
        HRESULT GetDecoderCaps(/* [annotation][out] _Out_ */ out tagDVD_DECODER_CAPS pCaps);
        
        [PreserveSig]
        HRESULT GetButtonRect(/* [in] */ uint ulButton, /* [annotation][out] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        HRESULT IsSubpictureStreamEnabled(/* [in] */ uint ulStreamNum, /* [annotation][out] _Out_ */ out bool pbEnabled);
    }
}
