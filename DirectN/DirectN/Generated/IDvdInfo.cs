// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(21710,5)
using System;
using System.Runtime.InteropServices;
using LCID = System.UInt32;
using VALID_UOP_SOMTHING_OR_OTHER = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("a70efe60-e2a3-11d0-a9be-00aa0061be93"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDvdInfo
    {
        [PreserveSig]
        HRESULT GetCurrentDomain(/* [out] */ out tagDVD_DOMAIN pDomain);
        
        [PreserveSig]
        HRESULT GetCurrentLocation(/* [annotation][out] _Out_ */ out tagDVD_PLAYBACK_LOCATION pLocation);
        
        [PreserveSig]
        HRESULT GetTotalTitleTime(/* [annotation][out] _Out_ */ out uint pulTotalTime);
        
        [PreserveSig]
        HRESULT GetCurrentButton(/* [annotation][out] _Out_ */ out uint pulButtonsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentButton);
        
        [PreserveSig]
        HRESULT GetCurrentAngle(/* [annotation][out] _Out_ */ out uint pulAnglesAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentAngle);
        
        [PreserveSig]
        HRESULT GetCurrentAudio(/* [annotation][out] _Out_ */ out uint pulStreamsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentStream);
        
        [PreserveSig]
        HRESULT GetCurrentSubpicture(/* [annotation][out] _Out_ */ out uint pulStreamsAvailable, /* [annotation][out] _Out_ */ out uint pulCurrentStream, /* [annotation][out] _Out_ */ out bool pIsDisabled);
        
        [PreserveSig]
        HRESULT GetCurrentUOPS(/* [annotation][out] _Out_ */ out VALID_UOP_SOMTHING_OR_OTHER pUOP);
        
        [PreserveSig]
        HRESULT GetAllSPRMs(/* [annotation][out] _Out_ */ out IntPtr pRegisterArray);
        
        [PreserveSig]
        HRESULT GetAllGPRMs(/* [annotation][out] _Out_ */ out IntPtr pRegisterArray);
        
        [PreserveSig]
        HRESULT GetAudioLanguage(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out LCID pLanguage);
        
        [PreserveSig]
        HRESULT GetSubpictureLanguage(/* [in] */ uint ulStream, /* [annotation][out] _Out_ */ out LCID pLanguage);
        
        [PreserveSig]
        HRESULT GetTitleAttributes(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out tagDVD_ATR pATR);
        
        [PreserveSig]
        HRESULT GetVMGAttributes(/* [annotation][out] _Out_ */ out tagDVD_ATR pATR);
        
        [PreserveSig]
        HRESULT GetCurrentVideoAttributes(/* [annotation][out] _Out_ */ out IntPtr pATR);
        
        [PreserveSig]
        HRESULT GetCurrentAudioAttributes(/* [annotation][out] _Out_ */ out IntPtr pATR);
        
        [PreserveSig]
        HRESULT GetCurrentSubpictureAttributes(/* [annotation][out] _Out_ */ out IntPtr pATR);
        
        [PreserveSig]
        HRESULT GetCurrentVolumeInfo(/* [annotation][out] _Out_ */ out uint pulNumOfVol, /* [annotation][out] _Out_ */ out uint pulThisVolNum, /* [annotation][out] _Out_ */ out tagDVD_DISC_SIDE pSide, /* [annotation][out] _Out_ */ out uint pulNumOfTitles);
        
        [PreserveSig]
        HRESULT GetDVDTextInfo(/* [annotation][size_is][out] _Out_writes_bytes_to_(ulBufSize, *pulActualSize) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] pTextManager, /* [in] */ int ulBufSize, /* [annotation][out] _Out_ */ out uint pulActualSize);
        
        [PreserveSig]
        HRESULT GetPlayerParentalLevel(/* [annotation][out] _Out_ */ out uint pulParentalLevel, /* [annotation][out] _Out_ */ out uint pulCountryCode);
        
        [PreserveSig]
        HRESULT GetNumberOfChapters(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out uint pulNumberOfChapters);
        
        [PreserveSig]
        HRESULT GetTitleParentalLevels(/* [in] */ uint ulTitle, /* [annotation][out] _Out_ */ out uint pulParentalLevels);
        
        [PreserveSig]
        HRESULT GetRoot(/* [annotation][size_is][out] _Out_writes_to_(ulBufSize, *pulActualSize) */ [MarshalAs(UnmanagedType.LPStr)] string pRoot, /* [in] */ uint ulBufSize, /* [annotation][out] _Out_ */ out uint pulActualSize);
    }
}
