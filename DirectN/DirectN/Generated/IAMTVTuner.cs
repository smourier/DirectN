// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\strmif.h(11399,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("211a8766-03ac-11d1-8d13-00aa00bd8339"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTVTuner : IAMTuner
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
        
        // IAMTVTuner
        [PreserveSig]
        HRESULT get_AvailableTVFormats(/* [annotation][out] _Out_ */ out long lAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT get_TVFormat(/* [annotation][out] _Out_ */ out long plAnalogVideoStandard);
        
        [PreserveSig]
        HRESULT AutoTune(/* [in] */ int lChannel, /* [annotation][out] _Out_ */ out long plFoundSignal);
        
        [PreserveSig]
        HRESULT StoreAutoTune();
        
        [PreserveSig]
        HRESULT get_NumInputConnections(/* [annotation][out] _Out_ */ out long plNumInputConnections);
        
        [PreserveSig]
        HRESULT put_InputType(/* [in] */ int lIndex, /* [in] */ tagTunerInputType InputType);
        
        [PreserveSig]
        HRESULT get_InputType(/* [in] */ int lIndex, /* [annotation][out] _Out_ */ out tagTunerInputType pInputType);
        
        [PreserveSig]
        HRESULT put_ConnectInput(/* [in] */ int lIndex);
        
        [PreserveSig]
        HRESULT get_ConnectInput(/* [annotation][out] _Out_ */ out long plIndex);
        
        [PreserveSig]
        HRESULT get_VideoFrequency(/* [annotation][out] _Out_ */ out long lFreq);
        
        [PreserveSig]
        HRESULT get_AudioFrequency(/* [annotation][out] _Out_ */ out long lFreq);
    }
}
