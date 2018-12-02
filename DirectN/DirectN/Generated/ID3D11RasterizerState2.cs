// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(725,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("6fbd02fb-209f-46c4-b059-2ed15586a6ac"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RasterizerState2 : ID3D11RasterizerState1
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
        new void GetDesc1(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC1 pDesc);
        
        // ID3D11RasterizerState2
        [PreserveSig]
        void GetDesc2(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC2 pDesc);
    }
}
