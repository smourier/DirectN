// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfcontentdecryptionmodule.h(544,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("a853d1f4-e2a0-4303-9edc-f1a68ee43136"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModuleAccess
    {
        [PreserveSig]
        HRESULT CreateContentDecryptionModule(/* optional(IPropertyStore) */ IntPtr contentDecryptionModuleProperties, /* [out] __RPC__deref_out_opt */ out IMFContentDecryptionModule contentDecryptionModule);
        
        [PreserveSig]
        HRESULT GetConfiguration(/* [out] __RPC__deref_out_opt */ out IntPtr configuration);
        
        [PreserveSig]
        HRESULT GetKeySystem(/* [out] __RPC__deref_out_opt */ out IntPtr keySystem);
    }
}
