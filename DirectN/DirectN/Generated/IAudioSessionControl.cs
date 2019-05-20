// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\audiopolicy.h(335,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f4b1a599-7266-4319-a8ca-e70acb11e8cd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionControl
    {
        [PreserveSig]
        HRESULT GetState(/* [annotation][out] _Out_ */ out _AudioSessionState pRetVal);
        
        [PreserveSig]
        HRESULT GetDisplayName(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        HRESULT SetDisplayName(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Value, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetIconPath(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        HRESULT SetIconPath(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Value, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT GetGroupingParam(/* [annotation][out] _Out_ */ out Guid pRetVal);
        
        [PreserveSig]
        HRESULT SetGroupingParam(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Override, /* [unique][in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid EventContext);
        
        [PreserveSig]
        HRESULT RegisterAudioSessionNotification(/* [annotation][in] _In_ */ IAudioSessionEvents NewNotifications);
        
        [PreserveSig]
        HRESULT UnregisterAudioSessionNotification(/* [annotation][in] _In_ */ IAudioSessionEvents NewNotifications);
    }
}
