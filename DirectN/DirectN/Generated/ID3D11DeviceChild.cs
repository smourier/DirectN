// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(1384,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("1841e5c8-16b0-489b-bcc8-44cfb0d5deae"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DeviceChild
    {
        [PreserveSig]
        void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
    }
}
