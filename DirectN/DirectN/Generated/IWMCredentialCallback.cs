// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmsdkidl.h(4582,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("342e0eb7-e651-450c-975b-2ace2c90c48e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMCredentialCallback
    {
        [PreserveSig]
        HRESULT AcquireCredentials(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszRealm, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszSite, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszUser, /* [in] */ uint cchUser, /* [size_is][out] */ [MarshalAs(UnmanagedType.LPWStr)] string pwszPassword, /* [in] */ uint cchPassword, /* [in] */ HRESULT hrStatus, /* [out] */ out uint pdwFlags);
    }
}
