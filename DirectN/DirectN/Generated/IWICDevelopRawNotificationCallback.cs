// generated from <Windows SDK Path>\um\wincodec.h
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
