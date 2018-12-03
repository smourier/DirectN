// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10477,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1d7b0652-185f-41c6-85ce-0c5be3d4ae6c"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoProcessor : ID3D11DeviceChild
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
        
        // ID3D11VideoProcessor
        [PreserveSig]
        void GetContentDesc(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc);
        
        [PreserveSig]
        void GetRateConversionCaps(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
    }
}
