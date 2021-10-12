// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_3.h(1170,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("91308b87-9040-411d-8c67-c39253ce3802"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11ShaderResourceView1 : ID3D11ShaderResourceView
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11View
        [PreserveSig]
        new void GetResource(/* [annotation] _Outptr_ */ out ID3D11Resource ppResource);
        
        // ID3D11ShaderResourceView
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_SHADER_RESOURCE_VIEW_DESC pDesc);
        
        // ID3D11ShaderResourceView1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_SHADER_RESOURCE_VIEW_DESC1 pDesc1);
    }
}
