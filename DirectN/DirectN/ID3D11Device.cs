using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("db6f6ddb-ac77-4e88-8253-819df9bbf140"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ID3D11Device
    {
        [PreserveSig]
        int CreateBuffer(ref D3D11_BUFFER_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, out ID3D11Buffer ppBuffer);

        [PreserveSig]
        int CreateTexture1D(ref D3D11_TEXTURE1D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, out ID3D11Texture1D ppTexture1D);

        [PreserveSig]
        int CreateTexture2D(ref D3D11_TEXTURE2D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, out ID3D11Texture2D ppTexture2D);

        [PreserveSig]
        int CreateTexture3D(ref D3D11_TEXTURE3D_DESC pDesc, ref D3D11_SUBRESOURCE_DATA pInitialData, out ID3D11Texture3D ppTexture3D);

        [PreserveSig]
        int CreateShaderResourceView(ID3D11Resource pResource, ref D3D11_SHADER_RESOURCE_VIEW_DESC pDesc, out ID3D11ShaderResourceView ppSRView);

        [PreserveSig]
        int CreateUnorderedAccessView(ID3D11Resource pResource, ref D3D11_UNORDERED_ACCESS_VIEW_DESC pDesc, out ID3D11UnorderedAccessView ppUAView);

        [PreserveSig]
        int CreateRenderTargetView(ID3D11Resource pResource, ref D3D11_RENDER_TARGET_VIEW_DESC pDesc, ID3D11RenderTargetView ppRTView);

        [PreserveSig]
        int CreateDepthStencilView(ID3D11Resource pResource, ref D3D11_DEPTH_STENCIL_VIEW_DESC pDesc, out ID3D11DepthStencilView ppDepthStencilView);

        [PreserveSig]
        int CreateInputLayout(D3D11_INPUT_ELEMENT_DESC[] pInputElementDescs, int NumElements, IntPtr pShaderBytecodeWithInputSignature, IntPtr BytecodeLength, out ID3D11InputLayout ppInputLayout);

        [PreserveSig]
        int CreateVertexShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11VertexShader ppVertexShader);

        [PreserveSig]
        int CreateGeometryShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11GeometryShader ppGeometryShader);

        [PreserveSig]
        int CreateGeometryShaderWithStreamOutput(IntPtr pShaderBytecode, IntPtr BytecodeLength, D3D11_SO_DECLARATION_ENTRY[] pSODeclaration, int NumEntries, int[] pBufferStrides, int NumStrides, int RasterizedStream, ID3D11ClassLinkage pClassLinkage, out ID3D11GeometryShader ppGeometryShader);

        [PreserveSig]
        int CreatePixelShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11PixelShader ppPixelShader);

        [PreserveSig]
        int CreateHullShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11HullShader ppHullShader);

        [PreserveSig]
        int CreateDomainShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11DomainShader ppDomainShader);

        [PreserveSig]
        int CreateComputeShader(IntPtr pShaderBytecode, IntPtr BytecodeLength, ID3D11ClassLinkage pClassLinkage, out ID3D11ComputeShader ppComputeShader);

        [PreserveSig]
        int CreateClassLinkage(out ID3D11ClassLinkage ppLinkage);

        [PreserveSig]
        int CreateBlendState(ref D3D11_BLEND_DESC pBlendStateDesc, out ID3D11BlendState ppBlendState);

        [PreserveSig]
        int CreateDepthStencilState(ref D3D11_DEPTH_STENCIL_DESC pDepthStencilDesc, out ID3D11DepthStencilState ppDepthStencilState);

        [PreserveSig]
        int CreateRasterizerState(ref D3D11_RASTERIZER_DESC pRasterizerDesc, out ID3D11RasterizerState ppRasterizerState);

        [PreserveSig]
        int CreateSamplerState(ref D3D11_SAMPLER_DESC pSamplerDesc, out ID3D11SamplerState ppSamplerState);

        [PreserveSig]
        int CreateQuery(ref D3D11_QUERY_DESC pQueryDesc, out ID3D11Query ppQuery);

        [PreserveSig]
        int CreatePredicate(ref D3D11_QUERY_DESC pPredicateDesc, out ID3D11Predicate ppPredicate);

        [PreserveSig]
        int CreateCounter(ref D3D11_COUNTER_DESC pCounterDesc, out ID3D11Counter ppCounter);

        [PreserveSig]
        int CreateDeferredContext(int ContextFlags, out ID3D11DeviceContext ppDeferredContext);

        [PreserveSig]
        int OpenSharedResource(IntPtr hResource, [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);

        [PreserveSig]
        int CheckFormatSupport(DXGI_FORMAT Format, out int pFormatSupport);

        [PreserveSig]
        int CheckMultisampleQualityLevels(DXGI_FORMAT Format, int SampleCount, out int pNumQualityLevels);

        [PreserveSig]
        void CheckCounterInfo(out D3D11_COUNTER_INFO pCounterInfo);

        [PreserveSig]
        int CheckCounter(ref D3D11_COUNTER_DESC pDesc, out D3D11_COUNTER_TYPE pType, out int pActiveCounters,
            [In, Out, MarshalAs(UnmanagedType.LPStr)] string szName,
            ref int pNameLength,
            [In, Out, MarshalAs(UnmanagedType.LPStr)] string szUnits,
            ref int pUnitsLength,
            [In, Out, MarshalAs(UnmanagedType.LPWStr)] string szDescription,
            ref int pDescriptionLength);

        [PreserveSig]
        int CheckFeatureSupport(D3D11_FEATURE Feature, IntPtr pFeatureSupportData, int FeatureSupportDataSize);

        [PreserveSig]
        int GetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, out int pDataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateData([MarshalAs(UnmanagedType.LPStruct)] Guid guid, int DataSize, IntPtr pData);

        [PreserveSig]
        int SetPrivateDataInterface([MarshalAs(UnmanagedType.LPStruct)] Guid guid, [MarshalAs(UnmanagedType.IUnknown)] object pData);

        [PreserveSig]
        D3D_FEATURE_LEVEL GetFeatureLevel();

        [PreserveSig]
        int GetCreationFlags();

        [PreserveSig]
        int GetDeviceRemovedReason();

        [PreserveSig]
        void GetImmediateContext(out ID3D11DeviceContext ppImmediateContext);

        [PreserveSig]
        int SetExceptionMode(int RaiseFlags);

        [PreserveSig]
        int GetExceptionMode();
    }
}
