// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(4940,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("28acf509-7f5c-48f6-8611-f316010a6380"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11UnorderedAccessView : ID3D11View
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
        
        // ID3D11UnorderedAccessView
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
    }
}
