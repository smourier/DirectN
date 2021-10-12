// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\audioengineextensionapo.h(539,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56b0c76f-02fd-4b21-a52e-9f8219fc86e4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAudioProcessingObjectNotifications
    {
        [PreserveSig]
        HRESULT GetApoNotificationRegistrationInfo(/* [annotation][out] _Out_writes_(*count) */ out IntPtr apoNotifications, /* [annotation][out] _Out_ */ out uint count);
        
        [PreserveSig]
        void HandleNotification(/* [annotation][in] _In_ */ ref APO_NOTIFICATION apoNotification);
    }
}
