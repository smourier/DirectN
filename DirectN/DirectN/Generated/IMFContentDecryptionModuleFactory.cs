// generated from <Windows SDK Path>\um\mfcontentdecryptionmodule.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("7d5abf16-4cbb-4e08-b977-9ba59049943e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFContentDecryptionModuleFactory
    {
        [PreserveSig]
        bool IsTypeSupported(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string keySystem, /* [optional][in] */ [MarshalAs(UnmanagedType.LPWStr)] string contentType);
        
        [PreserveSig]
        HRESULT CreateContentDecryptionModuleAccess(/* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string keySystem, /* [size_is][size_is][in] */ [MarshalAs(UnmanagedType.LPArray)] IPropertyStore[] configurations, /* [in] */ uint numConfigurations, /* [out] */ out IMFContentDecryptionModuleAccess contentDecryptionModuleAccess);
    }
}
