// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("19f68549-ca8a-4706-a4ef-481dbc95e12c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
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
