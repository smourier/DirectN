// generated from <Windows SDK Path>\um\audioengineextensionapo.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ca2cfbde-a9d6-4eb0-bc95-c4d026b380f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectNotifications2 : IAudioProcessingObjectNotifications
    {
        // IAudioProcessingObjectNotifications
        [PreserveSig]
        new HRESULT GetApoNotificationRegistrationInfo(/* [annotation][out] _Out_writes_(*count) */ IntPtr apoNotifications, /* [annotation][out] _Out_ */ out uint count);
        
        [PreserveSig]
        new void HandleNotification(/* [annotation][in] _In_ */ ref APO_NOTIFICATION apoNotification);
        
        // IAudioProcessingObjectNotifications2
        [PreserveSig]
        HRESULT GetApoNotificationRegistrationInfo2(APO_NOTIFICATION_TYPE maxApoNotificationTypeSupported, /* [annotation][out] _Out_writes_(count) */ IntPtr apoNotifications, /* [annotation][out] _Out_ */ out uint count);
    }
}
