// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(477,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("1f052807-0b46-4acc-8a89-364f793718a4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDevice
    {
        [PreserveSig]
        HRESULT CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        HRESULT CreateVideoDecoder(/* _In_ */ ref D3D12_VIDEO_DECODER_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoder);
        
        [PreserveSig]
        HRESULT CreateVideoDecoderHeap(/* _In_ */ ref D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoderHeap);
        
        [PreserveSig]
        HRESULT CreateVideoProcessor(uint NodeMask, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, int NumInputStreamDescs, /* _In_reads_(NumInputStreamDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoProcessor);
    }
}
