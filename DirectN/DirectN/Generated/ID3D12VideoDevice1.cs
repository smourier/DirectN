// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d12video.h(2820,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("00000000-0000-0000-0000-000000000000"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDevice1 : ID3D12VideoDevice
    {
        // ID3D12VideoDevice
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoder(/* _In_ */ ref D3D12_VIDEO_DECODER_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoder);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoderHeap(/* _In_ */ ref D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoderHeap);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessor(uint NodeMask, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, uint NumInputStreamDescs, /* _In_reads_(NumInputStreamDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoProcessor);
        
        // ID3D12VideoDevice1
        [PreserveSig]
        HRESULT CreateVideoMotionEstimator(/* _In_ */ ref D3D12_VIDEO_MOTION_ESTIMATOR_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoMotionEstimator);
        
        [PreserveSig]
        HRESULT CreateVideoMotionVectorHeap(/* _In_ */ ref D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoMotionVectorHeap);
    }
}
