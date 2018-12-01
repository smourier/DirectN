// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(7486,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("f88cfb8c-ef16-4991-b450-cb8c69e51704"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFMetadata
    {
        [PreserveSig]
        HRESULT SetLanguage(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszRFC1766);
        
        [PreserveSig]
        HRESULT GetLanguage(/* optional(LPWSTR) */ out IntPtr ppwszRFC1766);
        
        [PreserveSig]
        HRESULT GetAllLanguages(/* [out] __RPC__out */ PropVariant ppvLanguages);
        
        [PreserveSig]
        HRESULT SetProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [in] __RPC__in */ PropVariant ppvValue);
        
        [PreserveSig]
        HRESULT GetProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName, /* [out] __RPC__out */ PropVariant ppvValue);
        
        [PreserveSig]
        HRESULT DeleteProperty(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPWStr)] string pwszName);
        
        [PreserveSig]
        HRESULT GetAllPropertyNames(/* [out] __RPC__out */ PropVariant ppvNames);
    }
}
