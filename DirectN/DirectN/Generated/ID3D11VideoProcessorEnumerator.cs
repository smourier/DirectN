// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(10155,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("31627037-53ab-4200-9061-05faa9ab45f9"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoProcessorEnumerator : ID3D11DeviceChild
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        // ID3D11VideoProcessorEnumerator
        [PreserveSig]
        HRESULT GetVideoProcessorContentDesc(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
        
        [PreserveSig]
        HRESULT CheckVideoProcessorFormat(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out uint pFlags);
        
        [PreserveSig]
        HRESULT GetVideoProcessorCaps(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CAPS pCaps);
        
        [PreserveSig]
        HRESULT GetVideoProcessorRateConversionCaps(/* [annotation] _In_ */ uint TypeIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
        
        [PreserveSig]
        HRESULT GetVideoProcessorCustomRate(/* [annotation] _In_ */ uint TypeIndex, /* [annotation] _In_ */ uint CustomRateIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
        
        [PreserveSig]
        HRESULT GetVideoProcessorFilterRange(/* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
    }
}
