// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(4459,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9fdac92a-1876-48c3-afad-25b94f84a9b6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DepthStencilView : ID3D11View
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
        
        // ID3D11DepthStencilView
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_DEPTH_STENCIL_VIEW_DESC pDesc);
    }
}
