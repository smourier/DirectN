// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfcontentdecryptionmodule.h(624,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7d5abf16-4cbb-4e08-b977-9ba59049943e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModuleFactory
    {
        [PreserveSig]
        bool IsTypeSupported(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string keySystem, /* [optional][in] */ [MarshalAs(UnmanagedType.LPWStr)] string contentType);
        
        [PreserveSig]
        HRESULT CreateContentDecryptionModuleAccess(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string keySystem, /* [size_is][size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] IPropertyStore[] configurations, /* [in] */ uint numConfigurations, /* [out] */ out IMFContentDecryptionModuleAccess contentDecryptionModuleAccess);
    }
}
