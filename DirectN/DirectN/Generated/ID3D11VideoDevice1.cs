// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_1.h(3842,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("29da1d51-1321-4454-804b-f5fc9f861f0f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDevice1
    {
        [PreserveSig]
        HRESULT GetCryptoSessionPrivateDataSize(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pDecoderProfile, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pKeyExchangeType, /* [annotation] _Out_ */ out uint pPrivateInputSize, /* [annotation] _Out_ */ out uint pPrivateOutputSize);
        
        [PreserveSig]
        HRESULT GetVideoDecoderCaps(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pDecoderProfile, /* [annotation] _In_ */ uint SampleWidth, /* [annotation] _In_ */ uint SampleHeight, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _In_ */ uint BitRate, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid pCryptoType, /* [annotation] _Out_ */ out uint pDecoderCaps);
        
        [PreserveSig]
        HRESULT CheckVideoDecoderDownsampling(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pInputDesc, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pInputConfig, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _In_ */ ref D3D11_VIDEO_SAMPLE_DESC pOutputDesc, /* [annotation] _Out_ */ out bool pSupported, /* [annotation] _Out_ */ out bool pRealTimeHint);
        
        [PreserveSig]
        HRESULT RecommendVideoDecoderDownsampleParameters(/* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_DESC pInputDesc, /* [annotation] _In_ */ DXGI_COLOR_SPACE_TYPE InputColorSpace, /* [annotation] _In_ */ ref D3D11_VIDEO_DECODER_CONFIG pInputConfig, /* [annotation] _In_ */ ref DXGI_RATIONAL pFrameRate, /* [annotation] _Out_ */ out D3D11_VIDEO_SAMPLE_DESC pRecommendedOutputDesc);
    }
}
