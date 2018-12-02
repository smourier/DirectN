// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(19489,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("22f765d1-8dab-4107-846d-56baf72215e7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSensorProfile
    {
        [PreserveSig]
        HRESULT GetProfileId(/* [annotation][out] _Out_ */ out __MIDL___MIDL_itf_mfidl_0000_0113_0001 pId);
        
        [PreserveSig]
        HRESULT AddProfileFilter(/* [annotation][in] _In_ */ uint StreamId, /* [annotation][in] _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string wzFilterSetString);
        
        [PreserveSig]
        HRESULT IsMediaTypeSupported(/* [annotation][in] _In_ */ uint StreamId, /* [annotation][in] _In_ */ IMFMediaType pMediaType, /* [annotation][out] _Out_ */ out bool pfSupported);
        
        [PreserveSig]
        HRESULT AddBlockedControl(/* [annotation][in] _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string wzBlockedControl);
    }
}
