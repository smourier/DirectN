// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_4.h(3148,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("59c0cb01-35f0-4a70-8f67-87905c906a53"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11VideoDevice2
    {
        [PreserveSig]
        HRESULT CheckFeatureSupport(D3D11_FEATURE_VIDEO Feature, /* [annotation] _Out_writes_bytes_(FeatureSupportDataSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        HRESULT NegotiateCryptoSessionKeyExchangeMT(/* [annotation] _In_ */ ref ID3D11CryptoSession pCryptoSession, /* [annotation] _In_ */ D3D11_CRYPTO_SESSION_KEY_EXCHANGE_FLAGS flags, /* [annotation] _In_ */ uint DataSize, /* [annotation] _Inout_updates_bytes_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
    }
}
