// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_4.h(3551,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a9e2faa0-cb39-418f-a0b7-d8aad4de672e"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext3 : ID3D11VideoContext2
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
        
        // ID3D11VideoContext
        [PreserveSig]
        new HRESULT GetDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, /* [annotation] _Out_ */ out uint pBufferSize, /* [annotation] _Outptr_result_bytebuffer_(*pBufferSize) */ out IntPtr ppBuffer);
        
        [PreserveSig]
        new HRESULT ReleaseDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
        
        [PreserveSig]
        new HRESULT DecoderBeginFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ID3D11VideoDecoderOutputView pView, uint ContentKeySize, /* optional(void) */ IntPtr pContentKey);
        
        [PreserveSig]
        new HRESULT DecoderEndFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder);
        
        [PreserveSig]
        new HRESULT SubmitDecoderBuffers(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ int NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC[] pBufferDesc);
        
        [PreserveSig]
        new int DecoderExtension(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
        
        [PreserveSig]
        new void VideoProcessorSetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool YCbCr, /* [annotation] _In_ */ ref D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        new void VideoProcessorSetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, /* [annotation] _In_ */ uint StreamIndex);
        
        [PreserveSig]
        new void VideoProcessorSetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ tagSIZE Size);
        
        [PreserveSig]
        new void VideoProcessorSetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        new int VideoProcessorSetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ IntPtr pData);
        
        [PreserveSig]
        new void VideoProcessorGetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool Enabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pYCbCr, /* [annotation] _Out_ */ out D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        new void VideoProcessorGetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, /* [annotation] _Out_ */ out uint pStreamIndex);
        
        [PreserveSig]
        new void VideoProcessorGetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagSIZE pSize);
        
        [PreserveSig]
        new void VideoProcessorGetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        new int VideoProcessorGetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new void VideoProcessorSetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_FRAME_FORMAT FrameFormat);
        
        [PreserveSig]
        new void VideoProcessorSetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, /* [annotation] _In_ */ bool RepeatFrame, /* optional(DXGI_RATIONAL) */ IntPtr pCustomRate);
        
        [PreserveSig]
        new void VideoProcessorSetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        new void VideoProcessorSetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Alpha);
        
        [PreserveSig]
        new void VideoProcessorSetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ int Count, /* [annotation] _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        new void VideoProcessorSetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(DXGI_RATIONAL) */ IntPtr pSourceAspectRatio, /* optional(DXGI_RATIONAL) */ IntPtr pDestinationAspectRatio);
        
        [PreserveSig]
        new void VideoProcessorSetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Lower, /* [annotation] _In_ */ float Upper);
        
        [PreserveSig]
        new void VideoProcessorSetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, /* [annotation] _In_ */ bool LeftViewFrame0, /* [annotation] _In_ */ bool BaseViewFrame0, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, /* [annotation] _In_ */ int MonoOffset);
        
        [PreserveSig]
        new void VideoProcessorSetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        new void VideoProcessorSetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ int Level);
        
        [PreserveSig]
        new int VideoProcessorSetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ IntPtr pData);
        
        [PreserveSig]
        new void VideoProcessorGetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
        
        [PreserveSig]
        new void VideoProcessorGetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, /* [annotation] _Out_ */ out bool pRepeatFrame, /* [annotation] _Out_ */ out DXGI_RATIONAL pCustomRate);
        
        [PreserveSig]
        new void VideoProcessorGetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        new void VideoProcessorGetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pAlpha);
        
        [PreserveSig]
        new void VideoProcessorGetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ int Count, /* [annotation] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        new void VideoProcessorGetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out DXGI_RATIONAL pSourceAspectRatio, /* [annotation] _Out_ */ out DXGI_RATIONAL pDestinationAspectRatio);
        
        [PreserveSig]
        new void VideoProcessorGetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pLower, /* [annotation] _Out_ */ out float pUpper);
        
        [PreserveSig]
        new void VideoProcessorGetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, /* [annotation] _Out_ */ out bool pLeftViewFrame0, /* [annotation] _Out_ */ out bool pBaseViewFrame0, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, /* [annotation] _Out_ */ out int MonoOffset);
        
        [PreserveSig]
        new void VideoProcessorGetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        new void VideoProcessorGetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out int pLevel);
        
        [PreserveSig]
        new int VideoProcessorGetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT VideoProcessorBlt(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ID3D11VideoProcessorOutputView pView, /* [annotation] _In_ */ uint OutputFrame, /* [annotation] _In_ */ int StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_VIDEO_PROCESSOR_STREAM[] pStreams);
        
        [PreserveSig]
        new HRESULT NegotiateCryptoSessionKeyExchange(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new void EncryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* [annotation] _In_ */ uint IVSize, /* optional(void) */ IntPtr pIV);
        
        [PreserveSig]
        new void DecryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* optional(D3D11_ENCRYPTED_BLOCK_INFO) */ IntPtr pEncryptedBlockInfo, /* [annotation] _In_ */ uint ContentKeySize, /* optional(void) */ IntPtr pContentKey, /* [annotation] _In_ */ uint IVSize, /* optional(void) */ IntPtr pIV);
        
        [PreserveSig]
        new void StartSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint RandomNumberSize, /* [annotation] _Out_writes_bytes_(RandomNumberSize) */ IntPtr pRandomNumber);
        
        [PreserveSig]
        new void FinishSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession);
        
        [PreserveSig]
        new HRESULT GetEncryptionBltKey(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint KeySize, /* [annotation] _Out_writes_bytes_(KeySize) */ IntPtr pReadbackKey);
        
        [PreserveSig]
        new HRESULT NegotiateAuthenticatedChannelKeyExchange(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT QueryAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ IntPtr pInput, /* [annotation] _In_ */ uint OutputSize, /* [annotation] _Out_writes_bytes_(OutputSize) */ IntPtr pOutput);
        
        [PreserveSig]
        new HRESULT ConfigureAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ IntPtr pInput, /* [annotation] _Out_ */ out D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
        
        [PreserveSig]
        new void VideoProcessorSetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
        
        [PreserveSig]
        new void VideoProcessorGetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
        
        // ID3D11VideoContext1
        [PreserveSig]
        new HRESULT SubmitDecoderBuffers1(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ int NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC1[] pBufferDesc);
        
        [PreserveSig]
        new HRESULT GetDataForNewHardwareKey(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint PrivateInputSize, /* [annotation] _In_reads_(PrivateInputSize) */ IntPtr pPrivatInputData, /* [annotation] _Out_ */ out ulong pPrivateOutputData);
        
        [PreserveSig]
        new HRESULT CheckCryptoSessionStatus(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _Out_ */ out D3D11_CRYPTO_SESSION_STATUS pStatus);
        
        [PreserveSig]
        new HRESULT DecoderEnableDownsampling(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc, /* [annotation] _In_ */ uint ReferenceFrameCount);
        
        [PreserveSig]
        new HRESULT DecoderUpdateDownsampling(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc);
        
        [PreserveSig]
        new void VideoProcessorSetOutputColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetOutputShaderUsage(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool ShaderUsage);
        
        [PreserveSig]
        new void VideoProcessorGetOutputColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetOutputShaderUsage(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pShaderUsage);
        
        [PreserveSig]
        new void VideoProcessorSetStreamColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        new void VideoProcessorSetStreamMirror(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ bool FlipHorizontal, /* [annotation] _In_ */ bool FlipVertical);
        
        [PreserveSig]
        new void VideoProcessorGetStreamColorSpace1(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_COLOR_SPACE_TYPE pColorSpace);
        
        [PreserveSig]
        new void VideoProcessorGetStreamMirror(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out bool pFlipHorizontal, /* [annotation] _Out_ */ out bool pFlipVertical);
        
        [PreserveSig]
        new HRESULT VideoProcessorGetBehaviorHints(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint OutputWidth, /* [annotation] _In_ */ uint OutputHeight, /* [annotation] _In_ */ DXGI_FORMAT OutputFormat, /* [annotation] _In_ */ int StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT[] pStreams, /* [annotation] _Out_ */ out uint pBehaviorHints);
        
        // ID3D11VideoContext2
        [PreserveSig]
        new void VideoProcessorSetOutputHDRMetaData(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* optional(void) */ IntPtr pHDRMetaData);
        
        [PreserveSig]
        new void VideoProcessorGetOutputHDRMetaData(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* optional(void) */ IntPtr pMetaData);
        
        [PreserveSig]
        new void VideoProcessorSetStreamHDRMetaData(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ DXGI_HDR_METADATA_TYPE Type, /* [annotation] _In_ */ uint Size, /* optional(void) */ IntPtr pHDRMetaData);
        
        [PreserveSig]
        new void VideoProcessorGetStreamHDRMetaData(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out DXGI_HDR_METADATA_TYPE pType, /* [annotation] _In_ */ uint Size, /* optional(void) */ IntPtr pMetaData);
        
        // ID3D11VideoContext3
        [PreserveSig]
        HRESULT DecoderBeginFrame1(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ID3D11VideoDecoderOutputView pView, uint ContentKeySize, /* optional(void) */ IntPtr pContentKey, /* [annotation] _In_range_(0, D3D11_4_VIDEO_DECODER_MAX_HISTOGRAM_COMPONENTS) */ int NumComponentHistograms, /* [annotation] _In_reads_opt_(NumComponentHistograms) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] pHistogramOffsets, /* [annotation] _In_reads_opt_(NumComponentHistograms) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ID3D11Buffer[] ppHistogramBuffers);
        
        [PreserveSig]
        HRESULT SubmitDecoderBuffers2(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ int NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC2[] pBufferDesc);
    }
}
