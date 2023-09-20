// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;
using PFN_DXCORE_NOTIFICATION_CALLBACK = System.IntPtr;
using uint32_t = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("78ee5945-c36e-4b13-a669-005dd11c0f06"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXCoreAdapterFactory
    {
        [PreserveSig]
        HRESULT CreateAdapterList(int numAttributes, /* _In_reads_(numAttributes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] filterAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapterList);
        
        [PreserveSig]
        HRESULT GetAdapterByLuid(ref LUID adapterLUID, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
        
        [PreserveSig]
        void IsNotificationTypeSupported(DXCoreNotificationType notificationType);
        
        [PreserveSig]
        HRESULT RegisterEventNotification(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object dxCoreObject, DXCoreNotificationType notificationType, /* _In_ */ ref PFN_DXCORE_NOTIFICATION_CALLBACK callbackFunction, /* optional(void) */ IntPtr callbackContext, /* _Out_ */ out uint32_t eventCookie);
        
        [PreserveSig]
        HRESULT UnregisterEventNotification(uint eventCookie);
    }
}
