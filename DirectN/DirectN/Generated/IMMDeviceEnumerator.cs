// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mmdeviceapi.h(704,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a95664d2-9614-4f35-a746-de8db63617e6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMDeviceEnumerator
    {
        [PreserveSig]
        HRESULT EnumAudioEndpoints(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0001 dataFlow, /* [annotation][in] _In_ */ uint dwStateMask, /* [annotation][out] _Out_ */ out IMMDeviceCollection ppDevices);
        
        [PreserveSig]
        HRESULT GetDefaultAudioEndpoint(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0001 dataFlow, /* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0002 role, /* [annotation][out] _Out_ */ out IMMDevice ppEndpoint);
        
        [PreserveSig]
        HRESULT GetDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrId, /* [annotation][out] _Out_ */ out IMMDevice ppDevice);
        
        [PreserveSig]
        HRESULT RegisterEndpointNotificationCallback(/* [annotation][in] _In_ */ IMMNotificationClient pClient);
        
        [PreserveSig]
        HRESULT UnregisterEndpointNotificationCallback(/* [annotation][in] _In_ */ IMMNotificationClient pClient);
    }
}
