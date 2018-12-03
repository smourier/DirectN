// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(9788,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("3c9c5b51-995d-48d1-9b8d-fa5caeded65c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDecoder : ID3D11DeviceChild
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
        
        // ID3D11VideoDecoder
        [PreserveSig]
        HRESULT GetCreationParameters(/* [annotation] _Out_ */ out D3D11_VIDEO_DECODER_DESC pVideoDesc, /* [annotation] _Out_ */ out D3D11_VIDEO_DECODER_CONFIG pConfig);
        
        [PreserveSig]
        HRESULT GetDriverHandle(/* [annotation] _Out_ */ out IntPtr pDriverHandle);
    }
}
