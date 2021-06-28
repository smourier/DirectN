// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3d11.h(11232,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c2931aea-2a85-4f20-860f-fba1fd256e18"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDecoderOutputView : ID3D11View
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
        
        // ID3D11VideoDecoderOutputView
        [PreserveSig]
        void GetDesc(/* [annotation] _Out_ */ out D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc);
    }
}
