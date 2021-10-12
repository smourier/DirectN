// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsinternaladminnetsource.h(351,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e74d58c3-cf77-4b51-af17-744687c43eae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSInternalAdminNetSource2
    {
        [PreserveSig]
        HRESULT SetCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPassword, /* [in] */ bool fPersist, /* [in] */ bool fConfirmedGood);
        
        [PreserveSig]
        HRESULT GetCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [out] */ out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, /* [out] */ out IntPtr pbstrName, /* [out] */ out IntPtr pbstrPassword, /* [out] */ out bool pfConfirmedGood);
        
        [PreserveSig]
        HRESULT DeleteCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy);
        
        [PreserveSig]
        HRESULT FindProxyForURLEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrHost, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [out] */ out bool pfProxyEnabled, /* [out] */ out IntPtr pbstrProxyServer, /* [out] */ out uint pdwProxyPort, /* [out][in] */ ref uint pdwProxyContext);
    }
}
