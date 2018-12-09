// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(11719,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("61f21c45-3c0e-4a74-9cea-67100d9ad5e4"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoContext : ID3D11DeviceChild
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
        HRESULT GetDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, D3D11_VIDEO_DECODER_BUFFER_TYPE Type, /* [annotation] _Out_ */ out uint pBufferSize, /* [annotation] _Outptr_result_bytebuffer_(*pBufferSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object ppBuffer);
        
        [PreserveSig]
        HRESULT ReleaseDecoderBuffer(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ D3D11_VIDEO_DECODER_BUFFER_TYPE Type);
        
        [PreserveSig]
        HRESULT DecoderBeginFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ID3D11VideoDecoderOutputView pView, uint ContentKeySize, /* optional(void) */ IntPtr pContentKey);
        
        [PreserveSig]
        HRESULT DecoderEndFrame(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder);
        
        [PreserveSig]
        HRESULT SubmitDecoderBuffers(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ uint NumBuffers, /* [annotation] _In_reads_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_VIDEO_DECODER_BUFFER_DESC[] pBufferDesc);
        
        [PreserveSig]
        int DecoderExtension(/* [annotation] _In_ */ ID3D11VideoDecoder pDecoder, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_EXTENSION pExtensionData);
        
        [PreserveSig]
        void VideoProcessorSetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        void VideoProcessorSetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool YCbCr, /* [annotation] _In_ */ ref D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        void VideoProcessorSetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE AlphaFillMode, /* [annotation] _In_ */ uint StreamIndex);
        
        [PreserveSig]
        void VideoProcessorSetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ tagSIZE Size);
        
        [PreserveSig]
        void VideoProcessorSetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        int VideoProcessorSetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        void VideoProcessorGetOutputTargetRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool Enabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        void VideoProcessorGetOutputBackgroundColor(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pYCbCr, /* [annotation] _Out_ */ out D3D11_VIDEO_COLOR pColor);
        
        [PreserveSig]
        void VideoProcessorGetOutputColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetOutputAlphaFillMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ALPHA_FILL_MODE pAlphaFillMode, /* [annotation] _Out_ */ out uint pStreamIndex);
        
        [PreserveSig]
        void VideoProcessorGetOutputConstriction(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagSIZE pSize);
        
        [PreserveSig]
        void VideoProcessorGetOutputStereoMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        int VideoProcessorGetOutputExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        void VideoProcessorSetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_FRAME_FORMAT FrameFormat);
        
        [PreserveSig]
        void VideoProcessorSetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorSetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_OUTPUT_RATE OutputRate, /* [annotation] _In_ */ bool RepeatFrame, /* optional(DXGI_RATIONAL) */ IntPtr pCustomRate);
        
        [PreserveSig]
        void VideoProcessorSetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        void VideoProcessorSetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(tagRECT) */ IntPtr pRect);
        
        [PreserveSig]
        void VideoProcessorSetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Alpha);
        
        [PreserveSig]
        void VideoProcessorSetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ uint Count, /* [annotation] _In_reads_opt_(Count) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        void VideoProcessorSetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* optional(DXGI_RATIONAL) */ IntPtr pSourceAspectRatio, /* optional(DXGI_RATIONAL) */ IntPtr pDestinationAspectRatio);
        
        [PreserveSig]
        void VideoProcessorSetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ float Lower, /* [annotation] _In_ */ float Upper);
        
        [PreserveSig]
        void VideoProcessorSetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FORMAT Format, /* [annotation] _In_ */ bool LeftViewFrame0, /* [annotation] _In_ */ bool BaseViewFrame0, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE FlipMode, /* [annotation] _In_ */ int MonoOffset);
        
        [PreserveSig]
        void VideoProcessorSetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable);
        
        [PreserveSig]
        void VideoProcessorSetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ int Level);
        
        [PreserveSig]
        int VideoProcessorSetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        void VideoProcessorGetStreamFrameFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_FRAME_FORMAT pFrameFormat);
        
        [PreserveSig]
        void VideoProcessorGetStreamColorSpace(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_COLOR_SPACE pColorSpace);
        
        [PreserveSig]
        void VideoProcessorGetStreamOutputRate(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_OUTPUT_RATE pOutputRate, /* [annotation] _Out_ */ out bool pRepeatFrame, /* [annotation] _Out_ */ out DXGI_RATIONAL pCustomRate);
        
        [PreserveSig]
        void VideoProcessorGetStreamSourceRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        void VideoProcessorGetStreamDestRect(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out tagRECT pRect);
        
        [PreserveSig]
        void VideoProcessorGetStreamAlpha(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pAlpha);
        
        [PreserveSig]
        void VideoProcessorGetStreamPalette(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ uint Count, /* [annotation] _Out_writes_(Count) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] uint[] pEntries);
        
        [PreserveSig]
        void VideoProcessorGetStreamPixelAspectRatio(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out DXGI_RATIONAL pSourceAspectRatio, /* [annotation] _Out_ */ out DXGI_RATIONAL pDestinationAspectRatio);
        
        [PreserveSig]
        void VideoProcessorGetStreamLumaKey(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out float pLower, /* [annotation] _Out_ */ out float pUpper);
        
        [PreserveSig]
        void VideoProcessorGetStreamStereoFormat(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FORMAT pFormat, /* [annotation] _Out_ */ out bool pLeftViewFrame0, /* [annotation] _Out_ */ out bool pBaseViewFrame0, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_STEREO_FLIP_MODE pFlipMode, /* [annotation] _Out_ */ out int MonoOffset);
        
        [PreserveSig]
        void VideoProcessorGetStreamAutoProcessingMode(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnabled);
        
        [PreserveSig]
        void VideoProcessorGetStreamFilter(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_FILTER Filter, /* [annotation] _Out_ */ out bool pEnabled, /* [annotation] _Out_ */ out int pLevel);
        
        [PreserveSig]
        int VideoProcessorGetStreamExtension(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pExtensionGuid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Out_writes_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        HRESULT VideoProcessorBlt(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ ID3D11VideoProcessorOutputView pView, /* [annotation] _In_ */ uint OutputFrame, /* [annotation] _In_ */ uint StreamCount, /* [annotation] _In_reads_(StreamCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_VIDEO_PROCESSOR_STREAM[] pStreams);
        
        [PreserveSig]
        HRESULT NegotiateCryptoSessionKeyExchange(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        void EncryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* [annotation] _In_ */ uint IVSize, /* [annotation] _Inout_opt_bytecount_(IVSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pIV);
        
        [PreserveSig]
        void DecryptionBlt(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ ID3D11Texture2D pSrcSurface, /* [annotation] _In_ */ ID3D11Texture2D pDstSurface, /* optional(D3D11_ENCRYPTED_BLOCK_INFO) */ IntPtr pEncryptedBlockInfo, /* [annotation] _In_ */ uint ContentKeySize, /* optional(void) */ IntPtr pContentKey, /* [annotation] _In_ */ uint IVSize, /* [annotation] _Inout_opt_bytecount_(IVSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pIV);
        
        [PreserveSig]
        void StartSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint RandomNumberSize, /* [annotation] _Out_writes_bytes_(RandomNumberSize) */ IntPtr pRandomNumber);
        
        [PreserveSig]
        void FinishSessionKeyRefresh(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession);
        
        [PreserveSig]
        HRESULT GetEncryptionBltKey(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ uint KeySize, /* [annotation] _Out_writes_bytes_(KeySize) */ IntPtr pReadbackKey);
        
        [PreserveSig]
        HRESULT NegotiateAuthenticatedChannelKeyExchange(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        HRESULT QueryAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ IntPtr pInput, /* [annotation] _In_ */ uint OutputSize, /* [annotation] _Out_writes_bytes_(OutputSize) */ IntPtr pOutput);
        
        [PreserveSig]
        HRESULT ConfigureAuthenticatedChannel(/* [annotation] _In_ */ ID3D11AuthenticatedChannel pChannel, /* [annotation] _In_ */ uint InputSize, /* [annotation] _In_reads_bytes_(InputSize) */ IntPtr pInput, /* [annotation] _Out_ */ out D3D11_AUTHENTICATED_CONFIGURE_OUTPUT pOutput);
        
        [PreserveSig]
        void VideoProcessorSetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _In_ */ bool Enable, /* [annotation] _In_ */ D3D11_VIDEO_PROCESSOR_ROTATION Rotation);
        
        [PreserveSig]
        void VideoProcessorGetStreamRotation(/* [annotation] _In_ */ ID3D11VideoProcessor pVideoProcessor, /* [annotation] _In_ */ uint StreamIndex, /* [annotation] _Out_ */ out bool pEnable, /* [annotation] _Out_ */ out D3D11_VIDEO_PROCESSOR_ROTATION pRotation);
    }
}
