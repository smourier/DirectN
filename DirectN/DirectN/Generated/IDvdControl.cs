// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(21308,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a70efe61-e2a3-11d0-a9be-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdControl
    {
        [PreserveSig]
        HRESULT TitlePlay(/* [in] */ uint ulTitle);
        
        [PreserveSig]
        HRESULT ChapterPlay(/* [in] */ uint ulTitle, /* [in] */ uint ulChapter);
        
        [PreserveSig]
        HRESULT TimePlay(/* [in] */ uint ulTitle, /* [in] */ uint bcdTime);
        
        [PreserveSig]
        HRESULT StopForResume();
        
        [PreserveSig]
        HRESULT GoUp();
        
        [PreserveSig]
        HRESULT TimeSearch(/* [in] */ uint bcdTime);
        
        [PreserveSig]
        HRESULT ChapterSearch(/* [in] */ uint ulChapter);
        
        [PreserveSig]
        HRESULT PrevPGSearch();
        
        [PreserveSig]
        HRESULT TopPGSearch();
        
        [PreserveSig]
        HRESULT NextPGSearch();
        
        [PreserveSig]
        HRESULT ForwardScan(/* [in] */ double dwSpeed);
        
        [PreserveSig]
        HRESULT BackwardScan(/* [in] */ double dwSpeed);
        
        [PreserveSig]
        HRESULT MenuCall(/* [in] */ tagDVD_MENU_ID MenuID);
        
        [PreserveSig]
        HRESULT Resume();
        
        [PreserveSig]
        HRESULT UpperButtonSelect();
        
        [PreserveSig]
        HRESULT LowerButtonSelect();
        
        [PreserveSig]
        HRESULT LeftButtonSelect();
        
        [PreserveSig]
        HRESULT RightButtonSelect();
        
        [PreserveSig]
        HRESULT ButtonActivate();
        
        [PreserveSig]
        HRESULT ButtonSelectAndActivate(/* [in] */ uint ulButton);
        
        [PreserveSig]
        HRESULT StillOff();
        
        [PreserveSig]
        HRESULT PauseOn();
        
        [PreserveSig]
        HRESULT PauseOff();
        
        [PreserveSig]
        HRESULT MenuLanguageSelect(/* [in] */ int Language);
        
        [PreserveSig]
        HRESULT AudioStreamChange(/* [in] */ uint ulAudio);
        
        [PreserveSig]
        HRESULT SubpictureStreamChange(/* [in] */ uint ulSubPicture, /* [in] */ bool bDisplay);
        
        [PreserveSig]
        HRESULT AngleChange(/* [in] */ uint ulAngle);
        
        [PreserveSig]
        HRESULT ParentalLevelSelect(/* [in] */ uint ulParentalLevel);
        
        [PreserveSig]
        HRESULT ParentalCountrySelect(/* [in] */ ushort wCountry);
        
        [PreserveSig]
        HRESULT KaraokeAudioPresentationModeChange(/* [in] */ uint ulMode);
        
        [PreserveSig]
        HRESULT VideoModePreferrence(/* [in] */ uint ulPreferredDisplayMode);
        
        [PreserveSig]
        HRESULT SetRoot(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszPath);
        
        [PreserveSig]
        HRESULT MouseActivate(/* [in] */ tagPOINT point);
        
        [PreserveSig]
        HRESULT MouseSelect(/* [in] */ tagPOINT point);
        
        [PreserveSig]
        HRESULT ChapterPlayAutoStop(/* [in] */ uint ulTitle, /* [in] */ uint ulChapter, /* [in] */ uint ulChaptersToPlay);
    }
}
