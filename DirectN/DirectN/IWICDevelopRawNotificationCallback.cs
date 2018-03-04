using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7B816B45-1996-4476-B132-DE9E247C8AF0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWICDevelopRawNotificationCallback
    {
        [PreserveSig]
        HRESULT Notify(WICRawChangeNotification NotificationMask);
    }
}
