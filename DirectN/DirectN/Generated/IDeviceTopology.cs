// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\devicetopology.h(3432,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2a07407e-6497-4a18-9787-32f79bd0d98f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDeviceTopology
    {
        [PreserveSig]
        HRESULT GetConnectorCount(/* [annotation][out] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetConnector(/* [annotation][in] _In_ */ uint nIndex, /* [annotation][out] _Out_ */ out IConnector ppConnector);
        
        [PreserveSig]
        HRESULT GetSubunitCount(/* [annotation][out] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetSubunit(/* [annotation][in] _In_ */ uint nIndex, /* [annotation][out] _Outptr_ */ out ISubunit ppSubunit);
        
        [PreserveSig]
        HRESULT GetPartById(/* [annotation][in] _In_ */ uint nId, /* [annotation][out] _Outptr_ */ out IPart ppPart);
        
        [PreserveSig]
        HRESULT GetDeviceId(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrDeviceId);
        
        [PreserveSig]
        HRESULT GetSignalPath(/* [annotation][in] _In_ */ IPart pIPartFrom, /* [annotation][in] _In_ */ IPart pIPartTo, /* [annotation][in] _In_ */ bool bRejectMixedPaths, /* [annotation][out] _Outptr_ */ out IPartsList ppParts);
    }
}
