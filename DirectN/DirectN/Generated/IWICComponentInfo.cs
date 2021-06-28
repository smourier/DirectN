// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wincodec.h(4749,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("23bc3f0a-698b-4357-886b-f24d50671334"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWICComponentInfo
    {
        [PreserveSig]
        HRESULT GetComponentType(/* [out] __RPC__out */ out WICComponentType pType);
        
        [PreserveSig]
        HRESULT GetCLSID(/* [out] __RPC__out */ out Guid pclsid);
        
        [PreserveSig]
        HRESULT GetSigningStatus(/* [out] __RPC__out */ out uint pStatus);
        
        [PreserveSig]
        HRESULT GetAuthor(/* [in] */ uint cchAuthor, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchAuthor) */ [MarshalAs(UnmanagedType.LPWStr)] string wzAuthor, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT GetVendorGUID(/* [out] __RPC__out */ out Guid pguidVendor);
        
        [PreserveSig]
        HRESULT GetVersion(/* [in] */ uint cchVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string wzVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT GetSpecVersion(/* [in] */ uint cchSpecVersion, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchSpecVersion) */ [MarshalAs(UnmanagedType.LPWStr)] string wzSpecVersion, /* [out] __RPC__out */ out uint pcchActual);
        
        [PreserveSig]
        HRESULT GetFriendlyName(/* [in] */ uint cchFriendlyName, /* [size_is][unique][out][in] __RPC__inout_ecount_full_opt(cchFriendlyName) */ [MarshalAs(UnmanagedType.LPWStr)] string wzFriendlyName, /* [out] __RPC__out */ out uint pcchActual);
    }
}
