// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(13042,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("d19f8e98-b126-4446-890c-5dcb7ad71453"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFInputTrustAuthority
    {
        [PreserveSig]
        HRESULT GetDecrypter(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][iid_is][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
        
        [PreserveSig]
        HRESULT RequestAccess(/* [in] */ _MFPOLICYMANAGER_ACTION Action, /* [annotation][out] _Outptr_ */ out IntPtr ppContentEnablerActivate);
        
        [PreserveSig]
        HRESULT GetPolicy(/* [in] */ _MFPOLICYMANAGER_ACTION Action, /* [annotation][out] _Outptr_ */ out IMFOutputPolicy ppPolicy);
        
        [PreserveSig]
        HRESULT BindAccess(/* [annotation][in] _In_ */ ref _MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS pParam);
        
        [PreserveSig]
        HRESULT UpdateAccess(/* [annotation][in] _In_ */ ref _MFINPUTTRUSTAUTHORITY_ACCESS_PARAMS pParam);
        
        [PreserveSig]
        HRESULT Reset();
    }
}
