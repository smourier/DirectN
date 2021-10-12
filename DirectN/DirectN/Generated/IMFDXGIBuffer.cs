// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\mfobjects.h(1818,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("e7174cfa-1c9e-48b1-8866-626226bfc258"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFDXGIBuffer
    {
        [PreserveSig]
        HRESULT GetResource(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT GetSubresourceIndex(/* [annotation][out] _Out_ */ out uint puSubresource);
        
        [PreserveSig]
        HRESULT GetUnknown(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out] _Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject);
        
        [PreserveSig]
        HRESULT SetUnknown(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation][in] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pUnkData);
    }
}
