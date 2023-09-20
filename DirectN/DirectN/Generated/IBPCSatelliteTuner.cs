// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("211a8765-03ac-11d1-8d13-00aa00bd8339"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IBPCSatelliteTuner : IAMTuner
    {
        // IAMTuner
        [PreserveSig]
        new HRESULT put_Channel(/* [in] */ int lChannel, /* [in] */ int lVideoSubChannel, /* [in] */ int lAudioSubChannel);
        
        [PreserveSig]
        new HRESULT get_Channel(/* [annotation][out] _Out_ */ out long plChannel, /* [annotation][out] _Out_ */ out long plVideoSubChannel, /* [annotation][out] _Out_ */ out long plAudioSubChannel);
        
        [PreserveSig]
        new HRESULT ChannelMinMax(/* [annotation][out] _Out_ */ out long lChannelMin, /* [annotation][out] _Out_ */ out long lChannelMax);
        
        [PreserveSig]
        new HRESULT put_CountryCode(/* [in] */ int lCountryCode);
        
        [PreserveSig]
        new HRESULT get_CountryCode(/* [annotation][out] _Out_ */ out long plCountryCode);
        
        [PreserveSig]
        new HRESULT put_TuningSpace(/* [in] */ int lTuningSpace);
        
        [PreserveSig]
        new HRESULT get_TuningSpace(/* [annotation][out] _Out_ */ out long plTuningSpace);
        
        [PreserveSig]
        new HRESULT Logon(/* [in] */ IntPtr hCurrentUser);
        
        [PreserveSig]
        new HRESULT Logout();
        
        [PreserveSig]
        new HRESULT SignalPresent(/* [annotation][out] _Out_ */ out long plSignalStrength);
        
        [PreserveSig]
        new HRESULT put_Mode(/* [in] */ tagAMTunerModeType lMode);
        
        [PreserveSig]
        new HRESULT get_Mode(/* [annotation][out] _Out_ */ out tagAMTunerModeType plMode);
        
        [PreserveSig]
        new HRESULT GetAvailableModes(/* [annotation][out] _Out_ */ out long plModes);
        
        [PreserveSig]
        new HRESULT RegisterNotificationCallBack(/* [in] */ IAMTunerNotification pNotify, /* [in] */ int lEvents);
        
        [PreserveSig]
        new HRESULT UnRegisterNotificationCallBack(/* [in] */ IAMTunerNotification pNotify);
        
        // IBPCSatelliteTuner
        [PreserveSig]
        HRESULT get_DefaultSubChannelTypes(/* [annotation][out] _Out_ */ out long plDefaultVideoType, /* [annotation][out] _Out_ */ out long plDefaultAudioType);
        
        [PreserveSig]
        HRESULT put_DefaultSubChannelTypes(/* [in] */ int lDefaultVideoType, /* [in] */ int lDefaultAudioType);
        
        [PreserveSig]
        HRESULT IsTapingPermitted();
    }
}
