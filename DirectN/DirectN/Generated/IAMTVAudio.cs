// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(12623,5)
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
