// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("83ec1c30-23d1-11d1-99e6-00a0c9560266"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMTVAudio
    {
        [PreserveSig]
        HRESULT GetHardwareSupportedTVAudioModes(/* [annotation][out] _Out_ */ out long plModes);
        
        [PreserveSig]
        HRESULT GetAvailableTVAudioModes(/* [annotation][out] _Out_ */ out long plModes);
        
        [PreserveSig]
        HRESULT get_TVAudioMode(/* [annotation][out] _Out_ */ out long plMode);
        
        [PreserveSig]
        HRESULT put_TVAudioMode(/* [in] */ int lMode);
        
        [PreserveSig]
        HRESULT RegisterNotificationCallBack(/* [in] */ IAMTunerNotification pNotify, /* [in] */ int lEvents);
        
        [PreserveSig]
        HRESULT UnRegisterNotificationCallBack(IAMTunerNotification pNotify);
    }
}
