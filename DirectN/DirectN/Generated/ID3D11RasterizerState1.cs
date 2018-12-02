// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(435,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1217d7a6-5039-418c-b042-9cbe256afd6e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RasterizerState1 : ID3D11RasterizerState
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11RasterizerState
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC pDesc);
        
        // ID3D11RasterizerState1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC1 pDesc);
    }
}
