// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mmdeviceapi.h(242,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7991eec9-7e89-4d85-8390-6c703cec60c0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMMNotificationClient
    {
        [PreserveSig]
        HRESULT OnDeviceStateChanged(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrDeviceId, /* [annotation][in] _In_ */ uint dwNewState);
        
        [PreserveSig]
        HRESULT OnDeviceAdded(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrDeviceId);
        
        [PreserveSig]
        HRESULT OnDeviceRemoved(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrDeviceId);
        
        [PreserveSig]
        HRESULT OnDefaultDeviceChanged(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0001 flow, /* [annotation][in] _In_ */ __MIDL___MIDL_itf_mmdeviceapi_0000_0000_0002 role, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrDefaultDeviceId);
        
        [PreserveSig]
        HRESULT OnPropertyValueChanged(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pwstrDeviceId, /* [annotation][in] _In_ */ _tagpropertykey key);
    }
}
