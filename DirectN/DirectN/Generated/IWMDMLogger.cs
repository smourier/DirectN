// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\wmdmlog.h(96,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("110a3200-5a79-11d3-8d78-444553540000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IWMDMLogger
    {
        [PreserveSig]
        HRESULT IsEnabled(/* [out] __RPC__out */ out bool pfEnabled);
        
        [PreserveSig]
        HRESULT Enable(/* [in] */ bool fEnable);
        
        [PreserveSig]
        HRESULT GetLogFileName(/* [max_is][string][out] __RPC__out_ecount_full_string(( 256 + 1 ) ) */ [MarshalAs(UnmanagedType.LPStr)] string pszFilename, /* [range][in] __RPC__in_range(0,256) */ uint nMaxChars);
        
        [PreserveSig]
        HRESULT SetLogFileName(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPStr)] string pszFilename);
        
        [PreserveSig]
        HRESULT LogString(/* [in] */ uint dwFlags, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPStr)] string pszSrcName, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPStr)] string pszLog);
        
        [PreserveSig]
        HRESULT LogDword(/* [in] */ uint dwFlags, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPStr)] string pszSrcName, /* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPStr)] string pszLogFormat, /* [in] */ uint dwLog);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT GetSizeParams(/* [out] __RPC__out */ out uint pdwMaxSize, /* [out] __RPC__out */ out uint pdwShrinkToSize);
        
        [PreserveSig]
        HRESULT SetSizeParams(/* [in] */ uint dwMaxSize, /* [in] */ uint dwShrinkToSize);
    }
}
