// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_2.h(2019,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9d06dffa-d1e5-4d07-83a8-1bb123f2f841"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device2 : ID3D11Device1
    {
        // ID3D11Device1
        [PreserveSig]
        new void GetImmediateContext1(/* [annotation] _Outptr_ */ out ID3D11DeviceContext1 ppImmediateContext);
        
        [PreserveSig]
        new HRESULT CreateDeferredContext1(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext1 ppDeferredContext);
        
        [PreserveSig]
        new HRESULT CreateBlendState1(/* [annotation] _In_ */ ref D3D11_BLEND_DESC1 pBlendStateDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11BlendState1 ppBlendState);
        
        [PreserveSig]
        new HRESULT CreateRasterizerState1(/* [annotation] _In_ */ ref D3D11_RASTERIZER_DESC1 pRasterizerDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RasterizerState1 ppRasterizerState);
        
        [PreserveSig]
        new HRESULT CreateDeviceContextState(uint Flags, /* [annotation] _In_reads_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, [MarshalAs(UnmanagedType.LPStruct)] Guid EmulatedInterface, /* [annotation] _Out_opt_ */ out D3D_FEATURE_LEVEL pChosenFeatureLevel, /* optional(ID3DDeviceContextState) */ out IntPtr ppContextState);
        
        [PreserveSig]
        new HRESULT OpenSharedResource1(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid returnedInterface, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        new HRESULT OpenSharedResourceByName(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string lpName, /* [annotation] _In_ */ uint dwDesiredAccess, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid returnedInterface, /* [annotation] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        // ID3D11Device2
        [PreserveSig]
        void GetImmediateContext2(/* [annotation] _Outptr_ */ out ID3D11DeviceContext2 ppImmediateContext);
        
        [PreserveSig]
        HRESULT CreateDeferredContext2(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext2 ppDeferredContext);
        
        [PreserveSig]
        void GetResourceTiling(/* [annotation] _In_ */ ref ID3D11Resource pTiledResource, /* [annotation] _Out_opt_ */ out uint pNumTilesForEntireResource, /* [annotation] _Out_opt_ */ out D3D11_PACKED_MIP_DESC pPackedMipDesc, /* [annotation] _Out_opt_ */ out D3D11_TILE_SHAPE pStandardTileShapeForNonPackedMips, /* optional(UINT) */ IntPtr pNumSubresourceTilings, /* [annotation] _In_ */ uint FirstSubresourceTilingToGet, /* [annotation] _Out_writes_(*pNumSubresourceTilings) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
        [PreserveSig]
        HRESULT CheckMultisampleQualityLevels1(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint SampleCount, /* [annotation] _In_ */ uint Flags, /* [annotation] _Out_ */ out uint pNumQualityLevels);
    }
}
