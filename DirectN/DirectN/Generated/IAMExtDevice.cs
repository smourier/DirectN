// generated from <Windows SDK Path>\um\strmif.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("b5730a90-1a2c-11cf-8c23-00aa006b6814"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAMExtDevice
    {
        [PreserveSig]
        HRESULT GetCapability(/* [in] */ int Capability, /* [annotation][out] _Out_ */ out long pValue, /* [annotation][out] _Out_ */ out double pdblValue);
        
        [PreserveSig]
        HRESULT get_ExternalDeviceID(/* [annotation][out] _Out_ */ out IntPtr ppszData);
        
        [PreserveSig]
        HRESULT get_ExternalDeviceVersion(/* [annotation][out] _Out_ */ out IntPtr ppszData);
        
        [PreserveSig]
        HRESULT put_DevicePower(/* [in] */ int PowerMode);
        
        [PreserveSig]
        HRESULT get_DevicePower(/* [annotation][out] _Out_ */ out long pPowerMode);
        
        [PreserveSig]
        HRESULT Calibrate(/* [in] */ IntPtr hEvent, /* [in] */ int Mode, /* [annotation][out] _Out_ */ out long pStatus);
        
        [PreserveSig]
        HRESULT put_DevicePort(/* [in] */ int DevicePort);
        
        [PreserveSig]
        HRESULT get_DevicePort(/* [annotation][out] _Out_ */ out long pDevicePort);
    }
}
