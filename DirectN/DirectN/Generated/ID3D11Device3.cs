// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(5927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a05c8c37-d2c6-4732-b3a0-9ce0b0dc9ae6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device3 : ID3D11Device2
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
        new void GetImmediateContext2(/* [annotation] _Outptr_ */ out ID3D11DeviceContext2 ppImmediateContext);
        
        [PreserveSig]
        new HRESULT CreateDeferredContext2(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext2 ppDeferredContext);
        
        [PreserveSig]
        new void GetResourceTiling(/* [annotation] _In_ */ ref ID3D11Resource pTiledResource, /* [annotation] _Out_opt_ */ out uint pNumTilesForEntireResource, /* [annotation] _Out_opt_ */ out D3D11_PACKED_MIP_DESC pPackedMipDesc, /* [annotation] _Out_opt_ */ out D3D11_TILE_SHAPE pStandardTileShapeForNonPackedMips, /* optional(UINT) */ IntPtr pNumSubresourceTilings, /* [annotation] _In_ */ uint FirstSubresourceTilingToGet, /* [annotation] _Out_writes_(*pNumSubresourceTilings) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
        [PreserveSig]
        new HRESULT CheckMultisampleQualityLevels1(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint SampleCount, /* [annotation] _In_ */ uint Flags, /* [annotation] _Out_ */ out uint pNumQualityLevels);
        
        // ID3D11Device3
        [PreserveSig]
        HRESULT CreateTexture2D1(/* [annotation] _In_ */ ref D3D11_TEXTURE2D_DESC1 pDesc1, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc1->MipLevels * pDesc1->ArraySize)) */ [MarshalAs(UnmanagedType.LPArray)] D3D11_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Texture2D1 ppTexture2D);
        
        [PreserveSig]
        HRESULT CreateTexture3D1(/* [annotation] _In_ */ ref D3D11_TEXTURE3D_DESC1 pDesc1, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc1->MipLevels)) */ [MarshalAs(UnmanagedType.LPArray)] D3D11_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Texture3D1 ppTexture3D);
        
        [PreserveSig]
        HRESULT CreateRasterizerState2(/* [annotation] _In_ */ ref D3D11_RASTERIZER_DESC2 pRasterizerDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RasterizerState2 ppRasterizerState);
        
        [PreserveSig]
        HRESULT CreateShaderResourceView1(/* [annotation] _In_ */ ref ID3D11Resource pResource, /* optional(D3D11_SHADER_RESOURCE_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11ShaderResourceView1 ppSRView1);
        
        [PreserveSig]
        HRESULT CreateUnorderedAccessView1(/* [annotation] _In_ */ ref ID3D11Resource pResource, /* optional(D3D11_UNORDERED_ACCESS_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11UnorderedAccessView1 ppUAView1);
        
        [PreserveSig]
        HRESULT CreateRenderTargetView1(/* [annotation] _In_ */ ref ID3D11Resource pResource, /* optional(D3D11_RENDER_TARGET_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RenderTargetView1 ppRTView1);
        
        [PreserveSig]
        HRESULT CreateQuery1(/* [annotation] _In_ */ ref D3D11_QUERY_DESC1 pQueryDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Query1 ppQuery1);
        
        [PreserveSig]
        void GetImmediateContext3(/* [annotation] _Outptr_ */ out ID3D11DeviceContext3 ppImmediateContext);
        
        [PreserveSig]
        HRESULT CreateDeferredContext3(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext3 ppDeferredContext);
        
        [PreserveSig]
        void WriteToSubresource(/* [annotation] _In_ */ ref ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        void ReadFromSubresource(/* [annotation] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pDstData, /* [annotation] _In_ */ uint DstRowPitch, /* [annotation] _In_ */ uint DstDepthPitch, /* [annotation] _In_ */ ref ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox);
    }
}
