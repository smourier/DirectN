// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\devicetopology.h(2780,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ae2de0e4-5bca-4f2d-aa46-5d13f8fdb3a9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPart
    {
        [PreserveSig]
        HRESULT GetName(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrName);
        
        [PreserveSig]
        HRESULT GetLocalId(/* [annotation][out] _Out_ */ out uint pnId);
        
        [PreserveSig]
        HRESULT GetGlobalId(/* [annotation][out] _Outptr_ */ out IntPtr ppwstrGlobalId);
        
        [PreserveSig]
        HRESULT GetPartType(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_devicetopology_0000_0000_0012 pPartType);
        
        [PreserveSig]
        HRESULT GetSubType(/* [out] */ out Guid pSubType);
        
        [PreserveSig]
        HRESULT GetControlInterfaceCount(/* [annotation][out] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetControlInterface(/* [annotation][in] _In_ */ uint nIndex, /* [annotation][out] _Out_ */ out IControlInterface ppInterfaceDesc);
        
        [PreserveSig]
        HRESULT EnumPartsIncoming(/* [annotation][out] _Out_ */ out IPartsList ppParts);
        
        [PreserveSig]
        HRESULT EnumPartsOutgoing(/* [annotation][out] _Out_ */ out IPartsList ppParts);
        
        [PreserveSig]
        HRESULT GetTopologyObject(/* [annotation][out] _Out_ */ out IDeviceTopology ppTopology);
        
        [PreserveSig]
        HRESULT Activate(/* [annotation][in] _In_ */ uint dwClsContext, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid refiid, /* [annotation][iid_is][out] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT RegisterControlChangeCallback(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][in] _In_ */ IControlChangeNotify pNotify);
        
        [PreserveSig]
        HRESULT UnregisterControlChangeCallback(/* [annotation][in] _In_ */ IControlChangeNotify pNotify);
    }
}
