// generated from <Windows SDK Path>\um\audiopolicy.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("24918acc-64b3-37c1-8ca9-74a66e9957a8"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionEvents
    {
        [PreserveSig]
        HRESULT OnDisplayNameChanged(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string NewDisplayName, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT OnIconPathChanged(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string NewIconPath, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT OnSimpleVolumeChanged(/* [annotation][in] _In_ */ float NewVolume, /* [annotation][in] _In_ */ bool NewMute, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT OnChannelVolumeChanged(/* [annotation][in] _In_ */ uint ChannelCount, /* [annotation][size_is][in] _In_reads_(ChannelCount) */ float [] NewChannelVolumeArray, /* [annotation][in] _In_ */ uint ChangedChannel, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT OnGroupingParamChanged(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid NewGroupingParam, /* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT OnStateChanged(/* [annotation][in] _In_ */ _AudioSessionState NewState);
        
        [PreserveSig]
        HRESULT OnSessionDisconnected(/* [annotation][in] _In_ */ AudioSessionDisconnectReason DisconnectReason);
    }
}
