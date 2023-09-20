// generated from <Windows SDK Path>\um\audioengineendpoint.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("eddce3e4-f3c1-453a-b461-223563cbd886"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IHardwareAudioEngineBase
    {
        [PreserveSig]
        HRESULT GetAvailableOffloadConnectorCount(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string _pwstrDeviceId, /* [annotation][in] _In_ */ uint _uConnectorId, /* [annotation][out] _Out_ */ out uint _pAvailableConnectorInstanceCount);
        
        [PreserveSig]
        HRESULT GetEngineFormat(/* [annotation][in] _In_ */ IMMDevice pDevice, /* [annotation][in] _In_ */ bool _bRequestDeviceFormat, /* [out] */ out IntPtr _ppwfxFormat);
        
        [PreserveSig]
        HRESULT SetEngineDeviceFormat(/* [annotation][in] _In_ */ IMMDevice pDevice, /* [in] */ ref tWAVEFORMATEX _pwfxFormat);
        
        [PreserveSig]
        HRESULT SetGfxState(/* [annotation][in] _In_ */ IMMDevice pDevice, /* [annotation][in] _In_ */ bool _bEnable);
        
        [PreserveSig]
        HRESULT GetGfxState(/* [annotation][in] _In_ */ IMMDevice pDevice, /* [annotation][out] _Out_ */ out bool _pbEnable);
    }
}
