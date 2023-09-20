// generated from <Windows SDK Path>\um\d3d11_1.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("cc86fabe-da55-401d-85e7-e3c9de2877e9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11BlendState1 : ID3D11BlendState
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
        
        // ID3D11BlendState
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_BLEND_DESC pDesc);
        
        // ID3D11BlendState1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_BLEND_DESC1 pDesc);
    }
}
