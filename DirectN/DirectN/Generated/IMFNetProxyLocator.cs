// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(12882,5)
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
