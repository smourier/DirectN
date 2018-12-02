// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(2646,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a7f026da-a5f8-4487-a564-15e34357651e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext1
    {
        [PreserveSig]
        HRESULT SubmitDecoderBuffers1(/* [annotation] _In_ */ ref ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ uint NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC1[] pBufferDesc);
        
        [PreserveSig]
        HRESULT GetDataForNewHardwareKey(/* [annotation] _In_ */ ref ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint PrivateInputSize, /* [annotation] _In_reads_(PrivateInputSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pPrivatInputData, /* [annotation] _Out_ */ out ulong pPrivateOutputData);
        
        [PreserveSig]
        HRESULT CheckCryptoSessionStatus(/* [annotation] _In_ */ ref ID3D11CryptoSession pCryptoSession, /* [annotation] _Out_ */ out D3D11_CRYPTO_SESSION_STATUS pStatus);
        
        [PreserveSig]
        HRESULT DecoderEnableDownsampling(/* [annotation] _In_ */ ref ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc, /* [annotation] _In_ */ uint ReferenceFrameCount);
        
        [PreserveSig]
        HRESULT DecoderUpdateDownsampling(/* [annotation] _In_ */ ref ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc);
        
        [PreserveSig]
        void VideoProcessorSetOutputColorSpace1(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetOutputShaderUsage(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool ShaderUsage);
        
        [PreserveSig]
        void VideoProcessorGetOutputColorSpace1(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetOutputShaderUsage(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pShaderUsage);
        
        [PreserveSig]
        void VideoProcessorSetStreamColorSpace1(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetStreamMirror(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ bool FlipHorizontal, /* [annotation] _In_ */ bool FlipVertical);
        
        [PreserveSig]
        void VideoProcessorGetStreamColorSpace1(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetStreamMirror(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out bool pFlipHorizontal, /* [annotation] _Out_ */ out bool pFlipVertical);
        
        [PreserveSig]
        HRESULT VideoProcessorGetBehaviorHints(/* [annotation] _In_ */ ref ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint OutputWidth, /* [annotation] _In_ */ uint OutputHeight, /* [annotation] _In_ */ DXGI_FORMAT OutputFormat, /* [annotation] _In_ */ uint StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT[] pStreams, /* [annotation] _Out_ */ out uint pBehaviorHints);
    }
}
