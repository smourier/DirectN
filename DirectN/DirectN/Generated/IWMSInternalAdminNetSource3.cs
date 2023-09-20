// generated from <Windows SDK Path>\um\wmsinternaladminnetsource.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("6b63d08e-4590-44af-9eb3-57ff1e73bf80"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSInternalAdminNetSource3 : IWMSInternalAdminNetSource2
    {
        // IWMSInternalAdminNetSource2
        [PreserveSig]
        new HRESULT SetCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPassword, /* [in] */ bool fPersist, /* [in] */ bool fConfirmedGood);
        
        [PreserveSig]
        new HRESULT GetCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [out] */ out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, /* [out] */ out IntPtr pbstrName, /* [out] */ out IntPtr pbstrPassword, /* [out] */ out bool pfConfirmedGood);
        
        [PreserveSig]
        new HRESULT DeleteCredentialsEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy);
        
        [PreserveSig]
        new HRESULT FindProxyForURLEx(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrHost, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [out] */ out bool pfProxyEnabled, /* [out] */ out IntPtr pbstrProxyServer, /* [out] */ out uint pdwProxyPort, /* [out][in] */ ref uint pdwProxyContext);
        
        // IWMSInternalAdminNetSource3
        [PreserveSig]
        HRESULT GetNetSourceCreator2(/* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppNetSourceCreator);
        
        [PreserveSig]
        HRESULT FindProxyForURLEx2(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrHost, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [out] */ out bool pfProxyEnabled, /* [out] */ out IntPtr pbstrProxyServer, /* [out] */ out uint pdwProxyPort, /* [out][in] */ ref ulong pqwProxyContext);
        
        [PreserveSig]
        HRESULT RegisterProxyFailure2(/* [in] */ HRESULT hrParam, /* [in] */ ulong qwProxyContext);
        
        [PreserveSig]
        HRESULT ShutdownProxyContext2(/* [in] */ ulong qwProxyContext);
        
        [PreserveSig]
        HRESULT IsUsingIE2(/* [in] */ ulong qwProxyContext, /* [out] */ out bool pfIsUsingIE);
        
        [PreserveSig]
        HRESULT SetCredentialsEx2(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPassword, /* [in] */ bool fPersist, /* [in] */ bool fConfirmedGood, /* [in] */ bool fClearTextAuthentication);
        
        [PreserveSig]
        HRESULT GetCredentialsEx2(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrUrl, /* [in] */ bool fProxy, /* [in] */ bool fClearTextAuthentication, /* [out] */ out NETSOURCE_URLCREDPOLICY_SETTINGS pdwUrlPolicy, /* [out] */ out IntPtr pbstrName, /* [out] */ out IntPtr pbstrPassword, /* [out] */ out bool pfConfirmedGood);
    }
}
