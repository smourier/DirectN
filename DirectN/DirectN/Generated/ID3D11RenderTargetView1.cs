// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(1470,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("ffbe2e23-f011-418a-ac56-5ceed7c5b94b"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RenderTargetView1 : ID3D11RenderTargetView
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_( *pDataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11View
        [PreserveSig]
        new void GetResource(/* [annotation] _Outptr_ */ out ID3D11Resource ppResource);
        
        // ID3D11RenderTargetView
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_RENDER_TARGET_VIEW_DESC pDesc);
        
        // ID3D11RenderTargetView1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_RENDER_TARGET_VIEW_DESC1 pDesc1);
    }
}
