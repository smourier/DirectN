// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_4.h(1912,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("c4e7374c-6243-4d1b-ae87-52b4f740e261"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext2
    {
        [PreserveSig]
        void VideoProcessorSetOutputHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* [annotation] _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pHDRMetaData);
        
        [PreserveSig]
        void VideoProcessorGetOutputHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* [annotation] _Out_writes_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] out object pMetaData);
        
        [PreserveSig]
        void VideoProcessorSetStreamHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* [annotation] _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pHDRMetaData);
        
        [PreserveSig]
        void VideoProcessorGetStreamHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* [annotation] _Out_writes_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] out object pMetaData);
    }
}
