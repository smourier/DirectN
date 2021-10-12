// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_1.h(4505,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("465217f2-5568-43cf-b5b9-f61d54531ca1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoProcessorEnumerator1 : ID3D11VideoProcessorEnumerator
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
        
        // ID3D11VideoProcessorEnumerator
        [PreserveSig]
        new HRESULT GetVideoProcessorContentDesc(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CONTENT_DESC pContentDesc);
        
        [PreserveSig]
        new HRESULT CheckVideoProcessorFormat(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out uint pFlags);
        
        [PreserveSig]
        new HRESULT GetVideoProcessorCaps(/* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CAPS pCaps);
        
        [PreserveSig]
        new HRESULT GetVideoProcessorRateConversionCaps(/* [annotation] _In_ */ uint TypeIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_RATE_CONVERSION_CAPS pCaps);
        
        [PreserveSig]
        new HRESULT GetVideoProcessorCustomRate(/* [annotation] _In_ */ uint TypeIndex, /* [annotation] _In_ */ uint CustomRateIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_CUSTOM_RATE pRate);
        
        [PreserveSig]
        new HRESULT GetVideoProcessorFilterRange(/* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_FILTER_RANGE pRange);
        
        // ID3D11VideoProcessorEnumerator1
        [PreserveSig]
        HRESULT CheckVideoProcessorFormatConversion(/* [annotation] _In_ */ DXGI_FORMAT InputFormat, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ DXGI_FORMAT OutputFormat, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE OutputColorSpace, /* [annotation] _Out_ */ out bool pSupported);
    }
}
