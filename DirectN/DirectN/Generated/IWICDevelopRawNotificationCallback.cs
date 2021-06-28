// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(7193,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("95c75a6e-3e8c-4ec2-85a8-aebcc551e59b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICDevelopRawNotificationCallback
    {
        [PreserveSig]
        HRESULT Notify(/* [in] */ uint NotificationMask);
    }
}
