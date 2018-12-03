// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11_3.h(5927,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("a05c8c37-d2c6-4732-b3a0-9ce0b0dc9ae6"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11Device3 : ID3D11Device2
    {
        // ID3D11Device
        [PreserveSig]
        new HRESULT CreateBuffer(/* [annotation] _In_ */ ref D3D11_BUFFER_DESC pDesc, /* optional(D3D11_SUBRESOURCE_DATA) */ IntPtr pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Buffer ppBuffer);
        
        [PreserveSig]
        new HRESULT CreateTexture1D(/* [annotation] _In_ */ ref D3D11_TEXTURE1D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [MarshalAs(UnmanagedType.LPArray)] D3D11_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Texture1D ppTexture1D);
        
        [PreserveSig]
        new HRESULT CreateTexture2D(/* [annotation] _In_ */ ref D3D11_TEXTURE2D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [MarshalAs(UnmanagedType.LPArray)] D3D11_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Texture2D ppTexture2D);
        
        [PreserveSig]
        new HRESULT CreateTexture3D(/* [annotation] _In_ */ ref D3D11_TEXTURE3D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels)) */ [MarshalAs(UnmanagedType.LPArray)] D3D11_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Texture3D ppTexture3D);
        
        [PreserveSig]
        new HRESULT CreateShaderResourceView(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_SHADER_RESOURCE_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11ShaderResourceView ppSRView);
        
        [PreserveSig]
        new HRESULT CreateUnorderedAccessView(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_UNORDERED_ACCESS_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11UnorderedAccessView ppUAView);
        
        [PreserveSig]
        new HRESULT CreateRenderTargetView(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_RENDER_TARGET_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RenderTargetView ppRTView);
        
        [PreserveSig]
        new HRESULT CreateDepthStencilView(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_DEPTH_STENCIL_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        new HRESULT CreateInputLayout(/* [annotation] _In_reads_(NumElements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_INPUT_ELEMENT_DESC[] pInputElementDescs, /* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ) */ uint NumElements, /* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecodeWithInputSignature, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _COM_Outptr_opt_ */ out ID3D11InputLayout ppInputLayout);
        
        [PreserveSig]
        new HRESULT CreateVertexShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11VertexShader ppVertexShader);
        
        [PreserveSig]
        new HRESULT CreateGeometryShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11GeometryShader ppGeometryShader);
        
        [PreserveSig]
        new HRESULT CreateGeometryShaderWithStreamOutput(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_reads_opt_(NumEntries) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D11_SO_DECLARATION_ENTRY[] pSODeclaration, /* [annotation] _In_range_( 0, D3D11_SO_STREAM_COUNT * D3D11_SO_OUTPUT_COMPONENT_COUNT ) */ uint NumEntries, /* [annotation] _In_reads_opt_(NumStrides) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pBufferStrides, /* [annotation] _In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) */ uint NumStrides, /* [annotation] _In_ */ uint RasterizedStream, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11GeometryShader ppGeometryShader);
        
        [PreserveSig]
        new HRESULT CreatePixelShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11PixelShader ppPixelShader);
        
        [PreserveSig]
        new HRESULT CreateHullShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11HullShader ppHullShader);
        
        [PreserveSig]
        new HRESULT CreateDomainShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DomainShader ppDomainShader);
        
        [PreserveSig]
        new HRESULT CreateComputeShader(/* [annotation] _In_reads_(BytecodeLength) */ IntPtr pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_opt_ */ ID3D11ClassLinkage pClassLinkage, /* [annotation] _COM_Outptr_opt_ */ out ID3D11ComputeShader ppComputeShader);
        
        [PreserveSig]
        new HRESULT CreateClassLinkage(/* [annotation] _COM_Outptr_ */ out ID3D11ClassLinkage ppLinkage);
        
        [PreserveSig]
        new HRESULT CreateBlendState(/* [annotation] _In_ */ ref D3D11_BLEND_DESC pBlendStateDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11BlendState ppBlendState);
        
        [PreserveSig]
        new HRESULT CreateDepthStencilState(/* [annotation] _In_ */ ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DepthStencilState ppDepthStencilState);
        
        [PreserveSig]
        new HRESULT CreateRasterizerState(/* [annotation] _In_ */ ref D3D11_RASTERIZER_DESC pRasterizerDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RasterizerState ppRasterizerState);
        
        [PreserveSig]
        new HRESULT CreateSamplerState(/* [annotation] _In_ */ ref D3D11_SAMPLER_DESC pSamplerDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11SamplerState ppSamplerState);
        
        [PreserveSig]
        new HRESULT CreateQuery(/* [annotation] _In_ */ ref D3D11_QUERY_DESC pQueryDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Query ppQuery);
        
        [PreserveSig]
        new HRESULT CreatePredicate(/* [annotation] _In_ */ ref D3D11_QUERY_DESC pPredicateDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Predicate ppPredicate);
        
        [PreserveSig]
        new HRESULT CreateCounter(/* [annotation] _In_ */ ref D3D11_COUNTER_DESC pCounterDesc, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Counter ppCounter);
        
        [PreserveSig]
        new HRESULT CreateDeferredContext(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext ppDeferredContext);
        
        [PreserveSig]
        new HRESULT OpenSharedResource(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, /* [annotation] _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        new HRESULT CheckFormatSupport(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out uint pFormatSupport);
        
        [PreserveSig]
        new HRESULT CheckMultisampleQualityLevels(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint SampleCount, /* [annotation] _Out_ */ out uint pNumQualityLevels);
        
        [PreserveSig]
        new void CheckCounterInfo(/* [annotation] _Out_ */ out D3D11_COUNTER_INFO pCounterInfo);
        
        [PreserveSig]
        new HRESULT CheckCounter(/* [annotation] _In_ */ ref D3D11_COUNTER_DESC pDesc, /* [annotation] _Out_ */ out D3D11_COUNTER_TYPE pType, /* [annotation] _Out_ */ out uint pActiveCounters, /* [annotation] _Out_writes_opt_(*pNameLength) */ [MarshalAs(UnmanagedType.LPStr)] string szName, /* optional(UINT) */ IntPtr pNameLength, /* [annotation] _Out_writes_opt_(*pUnitsLength) */ [MarshalAs(UnmanagedType.LPStr)] string szUnits, /* optional(UINT) */ IntPtr pUnitsLength, /* [annotation] _Out_writes_opt_(*pDescriptionLength) */ [MarshalAs(UnmanagedType.LPStr)] string szDescription, /* optional(UINT) */ IntPtr pDescriptionLength);
        
        [PreserveSig]
        new HRESULT CheckFeatureSupport(D3D11_FEATURE Feature, /* [annotation] _Out_writes_bytes_(FeatureSupportDataSize) */ IntPtr pFeatureSupportData, uint FeatureSupportDataSize);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        [PreserveSig]
        new D3D_FEATURE_LEVEL GetFeatureLevel();
        
        [PreserveSig]
        new uint GetCreationFlags();
        
        [PreserveSig]
        new HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        new void GetImmediateContext(/* [annotation] _Outptr_ */ out ID3D11DeviceContext ppImmediateContext);
        
        [PreserveSig]
        new HRESULT SetExceptionMode(uint RaiseFlags);
        
        [PreserveSig]
        new uint GetExceptionMode();
        
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
        new HRESULT CreateDeviceContextState(uint Flags, /* [annotation] _In_reads_( FeatureLevels ) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D_FEATURE_LEVEL[] pFeatureLevels, uint FeatureLevels, uint SDKVersion, [MarshalAs(UnmanagedType.LPStruct)] Guid EmulatedInterface, /* [annotation] _Out_opt_ */ out D3D_FEATURE_LEVEL pChosenFeatureLevel, /* [annotation] _Out_opt_ */ out ID3DDeviceContextState ppContextState);
        
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
        new void GetResourceTiling(/* [annotation] _In_ */ ID3D11Resource pTiledResource, /* [annotation] _Out_opt_ */ out uint pNumTilesForEntireResource, /* [annotation] _Out_opt_ */ out D3D11_PACKED_MIP_DESC pPackedMipDesc, /* [annotation] _Out_opt_ */ out D3D11_TILE_SHAPE pStandardTileShapeForNonPackedMips, /* optional(UINT) */ IntPtr pNumSubresourceTilings, /* [annotation] _In_ */ uint FirstSubresourceTilingToGet, /* [annotation] _Out_writes_(*pNumSubresourceTilings) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D11_SUBRESOURCE_TILING[] pSubresourceTilingsForNonPackedMips);
        
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
        HRESULT CreateShaderResourceView1(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_SHADER_RESOURCE_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11ShaderResourceView1 ppSRView1);
        
        [PreserveSig]
        HRESULT CreateUnorderedAccessView1(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_UNORDERED_ACCESS_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11UnorderedAccessView1 ppUAView1);
        
        [PreserveSig]
        HRESULT CreateRenderTargetView1(/* [annotation] _In_ */ ID3D11Resource pResource, /* optional(D3D11_RENDER_TARGET_VIEW_DESC1) */ IntPtr pDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11RenderTargetView1 ppRTView1);
        
        [PreserveSig]
        HRESULT CreateQuery1(/* [annotation] _In_ */ ref D3D11_QUERY_DESC1 pQueryDesc1, /* [annotation] _COM_Outptr_opt_ */ out ID3D11Query1 ppQuery1);
        
        [PreserveSig]
        void GetImmediateContext3(/* [annotation] _Outptr_ */ out ID3D11DeviceContext3 ppImmediateContext);
        
        [PreserveSig]
        HRESULT CreateDeferredContext3(uint ContextFlags, /* [annotation] _COM_Outptr_opt_ */ out ID3D11DeviceContext3 ppDeferredContext);
        
        [PreserveSig]
        void WriteToSubresource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ IntPtr pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        void ReadFromSubresource(/* [annotation] _Out_ */ [MarshalAs(UnmanagedType.IUnknown)] out object pDstData, /* [annotation] _In_ */ uint DstRowPitch, /* [annotation] _In_ */ uint DstDepthPitch, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox);
    }
}
