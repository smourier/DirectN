﻿// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfidl.h(16402,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("19f68549-ca8a-4706-a4ef-481dbc95e12c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCapturePhotoConfirmation
    {
        [PreserveSig]
        HRESULT SetPhotoConfirmationCallback(/* [annotation][in] _In_ */ IMFAsyncCallback pNotificationCallback);
        
        [PreserveSig]
        HRESULT SetPixelFormat(/* [annotation][in] _In_ */ Guid subtype);
        
        [PreserveSig]
        HRESULT GetPixelFormat(/* [annotation][out] _Out_ */ out Guid subtype);
    }
}
