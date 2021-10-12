// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\documenttarget.h(153,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1b8efec4-3019-4c27-964e-367202156906"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IPrintDocumentPackageTarget
    {
        [PreserveSig]
        HRESULT GetPackageTargetTypes(/* [out] __RPC__out */ out uint targetCount, /* optional(GUID) */ out IntPtr targetTypes);
        
        [PreserveSig]
        HRESULT GetPackageTarget(/* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid guidTargetType, /* [in] __RPC__in */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [iid_is][out] __RPC__deref_out_opt */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvTarget);
        
        [PreserveSig]
        HRESULT Cancel();
    }
}
