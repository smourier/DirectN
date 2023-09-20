// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("5b87ef6c-7ed8-434f-ba0e-184fac1628d1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetCredentialCache
    {
        [PreserveSig]
        HRESULT GetCredential(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszUrl, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszRealm, /* [in] */ uint dwAuthenticationFlags, /* [annotation][out] _Outptr_ */ out IMFNetCredential ppCred, /* [annotation][out] _Out_ */ out uint pdwRequirementsFlags);
        
        [PreserveSig]
        HRESULT SetGood(/* [in] */ IMFNetCredential pCred, /* [in] */ bool fGood);
        
        [PreserveSig]
        HRESULT SetUserOptions(/* [in] */ IMFNetCredential pCred, /* [in] */ uint dwOptionsFlags);
    }
}
