// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(2056,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9bb4ab81-ab1a-4d8f-b506-fc04200b6ee7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11RasterizerState : ID3D11DeviceChild
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
        
        // ID3D11RasterizerState
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_RASTERIZER_DESC pDesc);
    }
}
