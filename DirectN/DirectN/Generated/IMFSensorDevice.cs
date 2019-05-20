// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\mfidl.h(18577,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("fb9f48f2-2a18-4e28-9730-786f30f04dc4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorDevice
    {
        [PreserveSig]
        HRESULT GetDeviceId(/* [annotation][out] _Out_ */ out ulong pDeviceId);
        
        [PreserveSig]
        HRESULT GetDeviceType(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mfidl_0000_0109_0001 pType);
        
        [PreserveSig]
        HRESULT GetFlags(/* [annotation][out] _Out_ */ out ulong pFlags);
        
        [PreserveSig]
        HRESULT GetSymbolicLink(/* [annotation][size_is][out] _Out_writes_z_(cchSymbolicLink) */ [MarshalAs(UnmanagedType.LPWStr)] string SymbolicLink, /* [annotation][in] _In_ */ int cchSymbolicLink, /* [annotation][out] _Out_ */ out int pcchWritten);
        
        [PreserveSig]
        HRESULT GetDeviceAttributes(/* [annotation][out] _COM_Outptr_result_maybenull_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT GetStreamAttributesCount(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mfidl_0000_0109_0002 eType, /* [annotation][out] _Out_ */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetStreamAttributes(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mfidl_0000_0109_0002 eType, /* [annotation][in] _In_ */ uint dwIndex, /* [annotation][out] _COM_Outptr_ */ out IMFAttributes ppAttributes);
        
        [PreserveSig]
        HRESULT SetSensorDeviceMode(/* [annotation][in] _In_ */ __MIDL___MIDL_itf_mfidl_0000_0109_0003 eMode);
        
        [PreserveSig]
        HRESULT GetSensorDeviceMode(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mfidl_0000_0109_0003 peMode);
    }
}
