// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6599,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("4243adb4-3a32-4666-973c-0ccc5625dc44"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12VideoDevice3 : ID3D12VideoDevice2
    {
        // ID3D12VideoDevice
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D3D12_FEATURE_VIDEO FeatureVideo, /* _Inout_updates_bytes_(FeatureSupportDataSize) */ IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoder(/* _In_ */ ref D3D12_VIDEO_DECODER_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoder);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoderHeap(/* _In_ */ ref D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoderHeap);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessor(uint NodeMask, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, int NumInputStreamDescs, /* _In_reads_(NumInputStreamDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoProcessor);
        
        // ID3D12VideoDevice1
        [PreserveSig]
        new HRESULT CreateVideoMotionEstimator(/* _In_ */ ref D3D12_VIDEO_MOTION_ESTIMATOR_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoMotionEstimator);
        
        [PreserveSig]
        new HRESULT CreateVideoMotionVectorHeap(/* _In_ */ ref D3D12_VIDEO_MOTION_VECTOR_HEAP_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoMotionVectorHeap);
        
        // ID3D12VideoDevice2
        [PreserveSig]
        new HRESULT CreateVideoDecoder1(/* _In_ */ ref D3D12_VIDEO_DECODER_DESC pDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoder);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoderHeap1(/* _In_ */ ref D3D12_VIDEO_DECODER_HEAP_DESC pVideoDecoderHeapDesc, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoDecoderHeap);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessor1(uint NodeMask, /* _In_ */ ref D3D12_VIDEO_PROCESS_OUTPUT_STREAM_DESC pOutputStreamDesc, int NumInputStreamDescs, /* _In_reads_(NumInputStreamDescs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_VIDEO_PROCESS_INPUT_STREAM_DESC[] pInputStreamDescs, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoProcessor);
        
        [PreserveSig]
        new HRESULT CreateVideoExtensionCommand(/* _In_ */ ref D3D12_VIDEO_EXTENSION_COMMAND_DESC pDesc, /* _In_reads_bytes_(CreationParametersDataSizeInBytes) */ IntPtr pCreationParameters, IntPtr CreationParametersDataSizeInBytes, /* _In_opt_ */ ID3D12ProtectedResourceSession pProtectedResourceSession, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoExtensionCommand);
        
        [PreserveSig]
        new HRESULT ExecuteExtensionCommand(/* _In_ */ ID3D12VideoExtensionCommand pExtensionCommand, /* _In_reads_bytes_(ExecutionParametersSizeInBytes) */ IntPtr pExecutionParameters, IntPtr ExecutionParametersSizeInBytes, /* _Out_writes_bytes_(OutputDataSizeInBytes) */ IntPtr pOutputData, IntPtr OutputDataSizeInBytes);
        
        // ID3D12VideoDevice3
        [PreserveSig]
        HRESULT CreateVideoEncoder(/* _In_ */ ref D3D12_VIDEO_ENCODER_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoEncoder);
        
        [PreserveSig]
        HRESULT CreateVideoEncoderHeap(/* _In_ */ ref D3D12_VIDEO_ENCODER_HEAP_DESC pDesc, /* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppVideoEncoderHeap);
    }
}
