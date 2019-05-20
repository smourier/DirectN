// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\wmsinternaladminnetsource.h(115,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("8bb23e5f-d127-4afb-8d02-ae5b66d54c78"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMSInternalAdminNetSource
    {
        [PreserveSig]
        HRESULT Initialize(/* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pSharedNamespace, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pNamespaceNode, /* [in] */ INSNetSourceCreator pNetSourceCreator, /* [in] */ bool fEmbeddedInServer);
        
        [PreserveSig]
        HRESULT GetNetSourceCreator(/* [out] */ out INSNetSourceCreator ppNetSourceCreator);
        
        [PreserveSig]
        HRESULT SetCredentials(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrName, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrPassword, /* [in] */ bool fPersist, /* [in] */ bool fConfirmedGood);
        
        [PreserveSig]
        HRESULT GetCredentials(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm, /* [out] */ out IntPtr pbstrName, /* [out] */ out IntPtr pbstrPassword, /* [out] */ out bool pfConfirmedGood);
        
        [PreserveSig]
        HRESULT DeleteCredentials(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrRealm);
        
        [PreserveSig]
        HRESULT GetCredentialFlags(/* [out] */ out uint lpdwFlags);
        
        [PreserveSig]
        HRESULT SetCredentialFlags(/* [in] */ uint dwFlags);
        
        [PreserveSig]
        HRESULT FindProxyForURL(/* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrProtocol, /* [in] */ [MarshalAs(UnmanagedType.BStr)] string bstrHost, /* [out] */ out bool pfProxyEnabled, /* [out] */ out IntPtr pbstrProxyServer, /* [out] */ out uint pdwProxyPort, /* [out][in] */ ref uint pdwProxyContext);
        
        [PreserveSig]
        HRESULT RegisterProxyFailure(/* [in] */ HRESULT hrParam, /* [in] */ uint dwProxyContext);
        
        [PreserveSig]
        HRESULT ShutdownProxyContext(/* [in] */ uint dwProxyContext);
        
        [PreserveSig]
        HRESULT IsUsingIE(/* [in] */ uint dwProxyContext, /* [out] */ out bool pfIsUsingIE);
    }
}
