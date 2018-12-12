// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(13172,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("10ec4d5b-975a-4689-b9e4-d0aac30fe333"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDevice
    {
        [PreserveSig]
        HRESULT CreateVideoDecoder(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pVideoDesc, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pConfig, /* [annotation] _COM_Outptr_ */ out ID3D11VideoDecoder ppDecoder);
        
        [PreserveSig]
        HRESULT CreateVideoProcessor(/* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ uint RateConversionIndex, /* [annotation] _COM_Outptr_ */ out ID3D11VideoProcessor ppVideoProcessor);
        
        [PreserveSig]
        HRESULT CreateAuthenticatedChannel(/* [annotation] _In_ */ D3D11_AUTHENTICATED_CHANNEL_TYPE ChannelType, /* [annotation] _COM_Outptr_ */ out ID3D11AuthenticatedChannel ppAuthenticatedChannel);
        
        [PreserveSig]
        HRESULT CreateCryptoSession(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pKeyExchangeType, /* [annotation] _COM_Outptr_ */ out ID3D11CryptoSession ppCryptoSession);
        
        [PreserveSig]
        HRESULT CreateVideoDecoderOutputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_OUTPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoDecoderOutputView ppVDOVView);
        
        [PreserveSig]
        HRESULT CreateVideoProcessorInputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_INPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoProcessorInputView ppVPIView);
        
        [PreserveSig]
        HRESULT CreateVideoProcessorOutputView(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ ID3D11VideoProcessorEnumerator pEnum, /* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_OUTPUT_VIEW_DESC pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VideoProcessorOutputView ppVPOView);
        
        [PreserveSig]
        HRESULT CreateVideoProcessorEnumerator(/* [annotation] _In_ */ ref D3D11_VIDEO_PROCESSOR_CONTENT_DESC pDesc, /* [annotation] _COM_Outptr_ */ out ID3D11VideoProcessorEnumerator ppEnum);
        
        [PreserveSig]
        uint GetVideoDecoderProfileCount();
        
        [PreserveSig]
        HRESULT GetVideoDecoderProfile(/* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out Guid pDecoderProfile);
        
        [PreserveSig]
        HRESULT CheckVideoDecoderFormat(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pDecoderProfile, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out bool pSupported);
        
        [PreserveSig]
        HRESULT GetVideoDecoderConfigCount(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pDesc, /* [annotation] _Out_ */ out uint pCount);
        
        [PreserveSig]
        HRESULT GetVideoDecoderConfig(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pDesc, /* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out D3D11_VIDEO_DECODER_CONFIG pConfig);
        
        [PreserveSig]
        HRESULT GetContentProtectionCaps(/* optional(GUID) */ IntPtr pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _Out_ */ out D3D11_VIDEO_CONTENT_PROTECTION_CAPS pCaps);
        
        [PreserveSig]
        HRESULT CheckCryptoKeyExchange(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* optional(GUID) */ IntPtr pDecoderProfile, /* [annotation] _In_ */ uint Index, /* [annotation] _Out_ */ out Guid pKeyExchangeType);
        
        [PreserveSig]
        HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
    }
}
