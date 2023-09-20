// generated from <Windows SDK Path>\um\mfidl.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e9cd0383-a268-4bb4-82de-658d53574d41"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFNetProxyLocator
    {
        [PreserveSig]
        HRESULT FindFirstProxy(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszHost, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string pszUrl, /* [in] */ bool fReserved);
        
        [PreserveSig]
        HRESULT FindNextProxy();
        
        [PreserveSig]
        HRESULT RegisterProxyResult(/* [in] */ HRESULT hrOp);
        
        [PreserveSig]
        HRESULT GetCurrentProxy(/* [annotation][size_is][out] _Out_writes_opt_(*pcchStr) */ [MarshalAs(UnmanagedType.LPWStr)] string pszStr, /* [out][in] */ ref uint pcchStr);
        
        [PreserveSig]
        HRESULT Clone(/* [out] */ out IMFNetProxyLocator ppProxyLocator);
    }
}
