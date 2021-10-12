// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(6119,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("da6fea51-564c-4487-9810-f0d0f9b4e3a5"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11SamplerState : ID3D11DeviceChild
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
        
        // ID3D11SamplerState
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_SAMPLER_DESC pDesc);
    }
}
