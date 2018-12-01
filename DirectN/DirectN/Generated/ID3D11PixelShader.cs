// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(5410,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ea82e40d-51dc-4f33-93d4-db7c9125ae8c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11PixelShader : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_( *pDataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ out IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11PixelShader
    }
}
