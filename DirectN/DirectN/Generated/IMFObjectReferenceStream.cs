// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfidl.h(16049,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("09ef5be3-c8a7-469e-8b70-73bf25bb193f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFObjectReferenceStream
    {
        [PreserveSig]
        HRESULT SaveReference(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pUnk);
        
        [PreserveSig]
        HRESULT LoadReference(/* [in] */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [out] */ [MarshalAs(UnmanagedType.IUnknown)] out object ppv);
    }
}
