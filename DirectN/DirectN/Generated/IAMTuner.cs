// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("211a8761-03ac-11d1-8d13-00aa00bd8339"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTuner
    {
        [PreserveSig]
        HRESULT put_Channel(/* [in] */ int lChannel, /* [in] */ int lVideoSubChannel, /* [in] */ int lAudioSubChannel);
        
        [PreserveSig]
        HRESULT get_Channel(/* [annotation][out] _Out_ */ out long plChannel, /* [annotation][out] _Out_ */ out long plVideoSubChannel, /* [annotation][out] _Out_ */ out long plAudioSubChannel);
        
        [PreserveSig]
        HRESULT ChannelMinMax(/* [annotation][out] _Out_ */ out long lChannelMin, /* [annotation][out] _Out_ */ out long lChannelMax);
        
        [PreserveSig]
        HRESULT put_CountryCode(/* [in] */ int lCountryCode);
        
        [PreserveSig]
        HRESULT get_CountryCode(/* [annotation][out] _Out_ */ out long plCountryCode);
        
        [PreserveSig]
        HRESULT put_TuningSpace(/* [in] */ int lTuningSpace);
        
        [PreserveSig]
        HRESULT get_TuningSpace(/* [annotation][out] _Out_ */ out long plTuningSpace);
        
        [PreserveSig]
        HRESULT Logon(/* [in] */ IntPtr hCurrentUser);
        
        [PreserveSig]
        HRESULT Logout();
        
        [PreserveSig]
        HRESULT SignalPresent(/* [annotation][out] _Out_ */ out long plSignalStrength);
        
        [PreserveSig]
        HRESULT put_Mode(/* [in] */ tagAMTunerModeType lMode);
        
        [PreserveSig]
        HRESULT get_Mode(/* [annotation][out] _Out_ */ out tagAMTunerModeType plMode);
        
        [PreserveSig]
        HRESULT GetAvailableModes(/* [annotation][out] _Out_ */ out long plModes);
        
        [PreserveSig]
        HRESULT RegisterNotificationCallBack(/* [in] */ IAMTunerNotification pNotify, /* [in] */ int lEvents);
        
        [PreserveSig]
        HRESULT UnRegisterNotificationCallBack(/* [in] */ IAMTunerNotification pNotify);
    }
}
