// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10_1.h(365,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b7e4c87-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10ShaderResourceView1 : ID3D10ShaderResourceView
    {
        // ID3D10DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Out_ */ out ID3D10Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D10View
        [PreserveSig]
        new void GetResource(/* [annotation] _Out_ */ out ID3D10Resource ppResource);
        
        // ID3D10ShaderResourceView
        [PreserveSig]
        new void GetDesc(/* [annotation] _Out_ */ out D3D10_SHADER_RESOURCE_VIEW_DESC pDesc);
        
        // ID3D10ShaderResourceView1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D10_SHADER_RESOURCE_VIEW_DESC1 pDesc);
    }
}
