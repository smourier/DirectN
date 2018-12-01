// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\propsys.h(640,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("71604b0f-97b0-4764-8577-2f13e98a1422"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface INamedPropertyStore
    {
        [PreserveSig]
        HRESULT GetNamedValue(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [out] __RPC__out */ out PropVariant ppropvar);
        
        [PreserveSig]
        HRESULT SetNamedValue(/* [string][in] __RPC__in_string */ [MarshalAs(UnmanagedType.LPWStr)] string pszName, /* [in] __RPC__in */ PropVariant propvar);
        
        [PreserveSig]
        HRESULT GetNameCount(/* [out] __RPC__out */ out uint pdwCount);
        
        [PreserveSig]
        HRESULT GetNameAt(/* [in] */ uint iProp, /* [out] __RPC__deref_out_opt */ out IntPtr pbstrName);
    }
}
