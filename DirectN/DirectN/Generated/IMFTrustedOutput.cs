// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(14084,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("d19f8e95-b126-4446-890c-5dcb7ad71453"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFTrustedOutput
    {
        [PreserveSig]
        HRESULT GetOutputTrustAuthorityCount(/* [annotation][out] _Out_ */ out uint pcOutputTrustAuthorities);
        
        [PreserveSig]
        HRESULT GetOutputTrustAuthorityByIndex(/* [in] */ uint dwIndex, /* [annotation][out] _Outptr_ */ out IMFOutputTrustAuthority ppauthority);
        
        [PreserveSig]
        HRESULT IsFinal(/* [annotation][out] _Out_ */ out bool pfIsFinal);
    }
}
