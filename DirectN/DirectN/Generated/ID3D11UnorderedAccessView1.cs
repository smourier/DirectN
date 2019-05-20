// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_3.h(1805,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("7b3b6153-a886-4544-ab37-6537c8500403"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11UnorderedAccessView1 : ID3D11UnorderedAccessView
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
        new void GetDesc(/* [annotation] _Out_ */ out D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc);
        
        // ID3D11UnorderedAccessView1
        [PreserveSig]
        void GetDesc1(/* [annotation] _Out_ */ out D3D11_UNORDERED_ACCESS_VIEW_DESC1 pDesc1);
    }
}
