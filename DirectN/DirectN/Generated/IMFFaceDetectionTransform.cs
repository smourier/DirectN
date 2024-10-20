// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("ddd59578-d0e7-46e2-be8c-1ce76ad147c0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFFaceDetectionTransform
    {
        [PreserveSig]
        HRESULT SetDetectionCallback(/* [annotation][in] _In_ */ IMFFaceDetectionTransformCallback callback, /* [annotation][out] _Out_ */ out IntPtr callbackToken);
        
        [PreserveSig]
        HRESULT ClearDetectionCallback(/* [annotation][in] _In_ */ IntPtr callbackToken);
    }
}
