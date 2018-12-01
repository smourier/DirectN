// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audiopolicy.h(143,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("24918acc-64b3-37c1-8ca9-74a66e9957a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionEvents
    {
        [PreserveSig]
        HRESULT OnDisplayNameChanged(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string NewDisplayName, /* [in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT OnIconPathChanged(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string NewIconPath, /* [in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT OnSimpleVolumeChanged(/* [annotation][in] _In_ */ float NewVolume, /* [annotation][in] _In_ */ bool NewMute, /* [in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT OnChannelVolumeChanged(/* [annotation][in] _In_ */ uint ChannelCount, /* [annotation][size_is][in] _In_reads_(ChannelCount) */ float [] NewChannelVolumeArray, /* [annotation][in] _In_ */ uint ChangedChannel, /* [in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT OnGroupingParamChanged(/* [annotation][in] _In_ */ Guid NewGroupingParam, /* [in] */ Guid EventContext);
        
        [PreserveSig]
        HRESULT OnStateChanged(/* [annotation][in] _In_ */ _AudioSessionState NewState);
        
        [PreserveSig]
        HRESULT OnSessionDisconnected(/* [annotation][in] _In_ */ AudioSessionDisconnectReason DisconnectReason);
    }
}
