// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_4.h(3551,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a9e2faa0-cb39-418f-a0b7-d8aad4de672e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext3 : ID3D11VideoContext2
    {
        // ID3D11VideoContext2
        [PreserveSig]
        new void VideoProcessorSetOutputHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* [annotation] _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pHDRMetaData);
        
        [PreserveSig]
        new void VideoProcessorGetOutputHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* [annotation] _Out_writes_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] out object pMetaData);
        
        [PreserveSig]
        new void VideoProcessorSetStreamHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* [annotation] _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pHDRMetaData);
        
        [PreserveSig]
        new void VideoProcessorGetStreamHDRMetaData(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* [annotation] _Out_writes_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] out object pMetaData);
        
        // ID3D11VideoContext3
        [PreserveSig]
        HRESULT DecoderBeginFrame1(/* [annotation] _In_ */ ref ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref ID3D11VideoDecoderOutputView pView, uint ContentKeySize, /* [annotation] _In_reads_bytes_opt_(ContentKeySize) */ [MarshalAs(UnmanagedType.IUnknown)] object pContentKey, /* [annotation] _In_range_(0, D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS) */ uint NumComponentHistograms, /* [annotation] _In_reads_opt_(NumComponentHistograms) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] pHistogramOffsets, /* optional(ID3D11Buffer) */ out IntPtr ppHistogramBuffers);
        
        [PreserveSig]
        HRESULT SubmitDecoderBuffers2(/* [annotation] _In_ */ ref ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ uint NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC2[] pBufferDesc);
    }
}
