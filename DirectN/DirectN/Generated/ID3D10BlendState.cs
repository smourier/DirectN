// c:\program files (x86)\windows kits\10\include\10.0.22621.0\um\d3d10.h(1237,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("edad8d19-8a35-4d6d-8566-2ea276cde161"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10BlendState : ID3D10DeviceChild
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
        
        // ID3D10BlendState
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D10_BLEND_DESC pDesc);
    }
}
