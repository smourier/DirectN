// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(3007,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("037e866e-f56d-4357-a8af-9dabbe6e250e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Texture3D : ID3D11Resource
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
        
        // ID3D11Resource
        [PreserveSig]
        new void GetType(/* [annotation] _Out_ */ out D3D11_RESOURCE_DIMENSION pResourceDimension);
        
        [PreserveSig]
        new void SetEvictionPriority(/* [annotation] _In_ */ uint EvictionPriority);
        
        [PreserveSig]
        new uint GetEvictionPriority();
        
        // ID3D11Texture3D
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_TEXTURE3D_DESC pDesc);
    }
}
