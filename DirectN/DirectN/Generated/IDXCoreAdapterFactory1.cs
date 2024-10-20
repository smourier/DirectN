// generated from <Windows SDK Path>\um\dxcore_interface.h
using System;
using System.Runtime.InteropServices;
using LUID = DirectN._LUID;
using PFN_DXCORE_NOTIFICATION_CALLBACK = System.IntPtr;
using uint32_t = System.UInt32;

namespace DirectN
{
    [ComImport, Guid("d5682e19-6d21-401c-827a-9a51a4ea35d7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXCoreAdapterFactory1 : IDXCoreAdapterFactory
    {
        // IDXCoreAdapterFactory
        [PreserveSig]
        new HRESULT CreateAdapterList(int numAttributes, /* _In_reads_(numAttributes) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] Guid[] filterAttributes, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapterList);
        
        [PreserveSig]
        new HRESULT GetAdapterByLuid(ref LUID adapterLUID, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapter);
        
        [PreserveSig]
        new void IsNotificationTypeSupported(DXCoreNotificationType notificationType);
        
        [PreserveSig]
        new HRESULT RegisterEventNotification(/* _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object dxCoreObject, DXCoreNotificationType notificationType, /* _In_ */ ref PFN_DXCORE_NOTIFICATION_CALLBACK callbackFunction, /* optional(void) */ IntPtr callbackContext, /* _Out_ */ out uint32_t eventCookie);
        
        [PreserveSig]
        new HRESULT UnregisterEventNotification(uint eventCookie);
        
        // IDXCoreAdapterFactory1
        [PreserveSig]
        HRESULT CreateAdapterListByWorkload(DXCoreWorkload workload, DXCoreRuntimeFilterFlags runtimeFilter, DXCoreHardwareTypeFilterFlags hardwareTypeFilter, [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvAdapterList);
    }
}
