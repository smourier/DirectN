// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\audiopolicy.h(531,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("bfb7ff88-7239-4fc9-8fa2-07c950be9c6d"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioSessionControl2 : IAudioSessionControl
    {
        // IAudioSessionControl
        [PreserveSig]
        new HRESULT GetState(/* [annotation][out] _Out_ */ out _AudioSessionState pRetVal);
        
        [PreserveSig]
        new HRESULT GetDisplayName(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        new HRESULT SetDisplayName(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Value, /* [unique][in] */ Guid EventContext);
        
        [PreserveSig]
        new HRESULT GetIconPath(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        new HRESULT SetIconPath(/* [annotation][string][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string Value, /* [unique][in] */ Guid EventContext);
        
        [PreserveSig]
        new HRESULT GetGroupingParam(/* [annotation][out] _Out_ */ out Guid pRetVal);
        
        [PreserveSig]
        new HRESULT SetGroupingParam(/* [annotation][in] _In_ */ Guid Override, /* [unique][in] */ Guid EventContext);
        
        [PreserveSig]
        new HRESULT RegisterAudioSessionNotification(/* [annotation][in] _In_ */ IAudioSessionEvents NewNotifications);
        
        [PreserveSig]
        new HRESULT UnregisterAudioSessionNotification(/* [annotation][in] _In_ */ IAudioSessionEvents NewNotifications);
        
        // IAudioSessionControl2
        [PreserveSig]
        HRESULT GetSessionIdentifier(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        HRESULT GetSessionInstanceIdentifier(/* [annotation][string][out] _Out_ */ out IntPtr pRetVal);
        
        [PreserveSig]
        HRESULT GetProcessId(/* [annotation][out] _Out_ */ out uint pRetVal);
        
        [PreserveSig]
        HRESULT IsSystemSoundsSession();
        
        [PreserveSig]
        HRESULT SetDuckingPreference(/* [in] */ bool optOut);
    }
}
