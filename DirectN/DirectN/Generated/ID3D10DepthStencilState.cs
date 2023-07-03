// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10.h(1041,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("2b4b1cc8-a4ad-41f8-8322-ca86fc3ec675"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10DepthStencilState : ID3D10DeviceChild
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
        
        // ID3D10DepthStencilState
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D10_DEPTH_STENCIL_DESC pDesc);
    }
}
