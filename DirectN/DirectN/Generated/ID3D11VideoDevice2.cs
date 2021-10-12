// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_4.h(3382,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("59c0cb01-35f0-4a70-8f67-87905c906a53"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDevice2 : ID3D11VideoDevice1
    {
        // ID3D11VideoDevice
        [PreserveSig]
        new HRESULT CreateVideoDecoder(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pVideoDesc, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pConfig, /* [annotation] _COM_Outptr_ */ out ID3D11VideoDecoder ppDecoder);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessor(/* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ uint RateConversionIndex, /* [annotation] _COM_Outptr_ */ out ID3D11VideoProcessor ppVideoProcessor);
        
        [PreserveSig]
        new HRESULT CreateAuthenticatedChannel(/* [annotation] _In_ */ D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, /* [annotation] _COM_Outptr_ */ out ID3D11AuthenticatedChannel ppAuthenticatedChannel);
        
        [PreserveSig]
        new HRESULT CreateCryptoSession(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pKeyExchangeType, /* [annotation] _COM_Outptr_ */ out ID3D11CryptoSession ppCryptoSession);
        
        [PreserveSig]
        new HRESULT CreateVideoDecoderOutputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoDecoderOutputView ppVDOVView);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessorInputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoProcessorInputView ppVPIView);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessorOutputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoProcessorOutputView ppVPOView);
        
        [PreserveSig]
        new HRESULT CreateVideoProcessorEnumerator(/* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, /* [annotation] _COM_Outptr_ */ out ID3D11VideoProcessorEnumerator ppEnum);
        
        [PreserveSig]
        new uint GetVideoDecoderProfileCount();
        
        [PreserveSig]
        new HRESULT GetVideoDecoderProfile(/* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out Guid pDecoderProfile);
        
        [PreserveSig]
        new HRESULT CheckVideoDecoderFormat(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pDecoderProfile, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out bool pSupported);
        
        [PreserveSig]
        new HRESULT GetVideoDecoderConfigCount(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pDesc, /* [annotation] _Out_ */ out uint pCount);
        
        [PreserveSig]
        new HRESULT GetVideoDecoderConfig(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pDesc, /* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out D3D11_VIDEO_DECODER_CONFIG pConfig);
        
        [PreserveSig]
        new HRESULT GetContentProtectionCaps(/* optional(GUID) */ IntPtr pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _Out_ */ out D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
        
        [PreserveSig]
        new HRESULT CheckCryptoKeyExchange(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out Guid pKeyExchangeType);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11VideoDevice1
        [PreserveSig]
        new HRESULT GetCryptoSessionPrivateDataSize(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pKeyExchangeType, /* [annotation] _Out_ */ out uint pPrivateInputSize, /* [annotation] _Out_ */ out uint pPrivateOutputSize);
        
        [PreserveSig]
        new HRESULT GetVideoDecoderCaps(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pDecoderProfile, /* [annotation] _In_ */ uint SampleWidth, /* [annotation] _In_ */ uint SampleHeight, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _In_ */ uint BitRate, /* optional(GUID) */ IntPtr pCryptoType, /* [annotation] _Out_ */ out uint pDecoderCaps);
        
        [PreserveSig]
        new HRESULT CheckVideoDecoderDownsampling(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pInputDesc, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pInputConfig, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc, /* [annotation] _Out_ */ out bool pSupported, /* [annotation] _Out_ */ out bool pRealTimeHint);
        
        [PreserveSig]
        new HRESULT RecommendVideoDecoderDownsampleParameters(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pInputDesc, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pInputConfig, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _Out_ */ out D3D11_VIDEO_SAMPLE_DESC pRecommendedOutputDesc);
        
        // ID3D11VideoDevice2
        [PreserveSig]
        HRESULT CheckFeatureSupport(D3D11_FEATURE_VIDEO Feature, /* [annotation] _Out_writes_bytes_(FeatureSupportDataSize) */ IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        HRESULT NegotiateCryptoSessionKeyExchangeMT(/* [annotation] _In_ */ ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ IntPtr pData);
    }
}
