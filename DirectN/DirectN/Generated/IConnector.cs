// generated from <Windows SDK Path>\um\devicetopology.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9c2c4058-23f5-41de-877a-df3af236a09e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IConnector
    {
        [PreserveSig]
        HRESULT GetType(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_devicetopology_0000_0000_0013 pType);
        
        [PreserveSig]
        HRESULT GetDataFlow(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_devicetopology_0000_0000_0011 pFlow);
        
        [PreserveSig]
        HRESULT ConnectTo(/* [annotation][in] _In_ */ IConnector pConnectTo);
        
        [PreserveSig]
        HRESULT Disconnect();
        
        [PreserveSig]
        HRESULT IsConnected(/* [annotation][out] _Out_ */ out bool pbConnected);
        
        [PreserveSig]
        HRESULT GetConnectedTo(/* [annotation][out] _Out_ */ out IConnector ppConTo);
        
        [PreserveSig]
        HRESULT GetConnectorIdConnectedTo(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrConnectorId);
        
        [PreserveSig]
        HRESULT GetDeviceIdConnectedTo(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrDeviceId);
    }
}
