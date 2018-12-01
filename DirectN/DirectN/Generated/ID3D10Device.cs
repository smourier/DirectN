// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10.h(4831,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("9b7e4c0f-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Device
    {
        [PreserveSig]
        void VSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void PSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _In_reads_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void PSSetShader(/* [annotation] _In_opt_ */ ID3D10PixelShader pPixelShader);
        
        [PreserveSig]
        void PSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void VSSetShader(/* [annotation] _In_opt_ */ ID3D10VertexShader pVertexShader);
        
        [PreserveSig]
        void DrawIndexed(/* [annotation] _In_ */ uint IndexCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation);
        
        [PreserveSig]
        void Draw(/* [annotation] _In_ */ uint VertexCount, /* [annotation] _In_ */ uint StartVertexLocation);
        
        [PreserveSig]
        void PSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void IASetInputLayout(/* [annotation] _In_opt_ */ ID3D10InputLayout pInputLayout);
        
        [PreserveSig]
        void IASetVertexBuffers(/* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ out ID3D10Buffer[] ppVertexBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _In_reads_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        void IASetIndexBuffer(/* [annotation] _In_opt_ */ ID3D10Buffer pIndexBuffer, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint Offset);
        
        [PreserveSig]
        void DrawIndexedInstanced(/* [annotation] _In_ */ uint IndexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void DrawInstanced(/* [annotation] _In_ */ uint VertexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void GSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void GSSetShader(/* [annotation] _In_opt_ */ ID3D10GeometryShader pShader);
        
        [PreserveSig]
        void IASetPrimitiveTopology(/* [annotation] _In_ */ D3D_PRIMITIVE_TOPOLOGY Topology);
        
        [PreserveSig]
        void VSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _In_reads_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void VSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void SetPredication(/* [annotation] _In_opt_ */ ID3D10Predicate pPredicate, /* [annotation] _In_ */ bool PredicateValue);
        
        [PreserveSig]
        void GSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _In_reads_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void GSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void OMSetRenderTargets(/* [annotation] _In_range_( 0, D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* [annotation] _In_reads_opt_(NumViews) */ out ID3D10RenderTargetView[] ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D10DepthStencilView pDepthStencilView);
        
        [PreserveSig]
        void OMSetBlendState(/* [annotation] _In_opt_ */ ID3D10BlendState pBlendState, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _In_ */ uint SampleMask);
        
        [PreserveSig]
        void OMSetDepthStencilState(/* [annotation] _In_opt_ */ ID3D10DepthStencilState pDepthStencilState, /* [annotation] _In_ */ uint StencilRef);
        
        [PreserveSig]
        void SOSetTargets(/* [annotation] _In_range_( 0, D3D10_SO_BUFFER_SLOT_COUNT) */ uint NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ out ID3D10Buffer[] ppSOTargets, /* [annotation] _In_reads_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        void DrawAuto();
        
        [PreserveSig]
        void RSSetState(/* [annotation] _In_opt_ */ ID3D10RasterizerState pRasterizerState);
        
        [PreserveSig]
        void RSSetViewports(/* [annotation] _In_range_(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumViewports, /* [annotation] _In_reads_opt_(NumViewports) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_VIEWPORT[] pViewports);
        
        [PreserveSig]
        void RSSetScissorRects(/* [annotation] _In_range_(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumRects, /* [annotation] _In_reads_opt_(NumRects) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        void CopySubresourceRegion(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ID3D10Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* [annotation] _In_opt_ */ ref D3D10_BOX pSrcBox);
        
        [PreserveSig]
        void CopyResource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ ID3D10Resource pSrcResource);
        
        [PreserveSig]
        void UpdateSubresource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_opt_ */ ref D3D10_BOX pDstBox, /* [annotation] _In_ */ IntPtr pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        void ClearRenderTargetView(/* [annotation] _In_ */ ID3D10RenderTargetView pRenderTargetView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA);
        
        [PreserveSig]
        void ClearDepthStencilView(/* [annotation] _In_ */ ID3D10DepthStencilView pDepthStencilView, /* [annotation] _In_ */ uint ClearFlags, /* [annotation] _In_ */ float Depth, /* [annotation] _In_ */ byte Stencil);
        
        [PreserveSig]
        void GenerateMips(/* [annotation] _In_ */ ID3D10ShaderResourceView pShaderResourceView);
        
        [PreserveSig]
        void ResolveSubresource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ ID3D10Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* [annotation] _In_ */ DXGI_FORMAT Format);
        
        [PreserveSig]
        void VSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void PSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _Out_writes_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void PSGetShader(/* [annotation] _Out_ */ out ID3D10PixelShader ppPixelShader);
        
        [PreserveSig]
        void PSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _Out_writes_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void VSGetShader(/* [annotation] _Out_ */ out ID3D10VertexShader ppVertexShader);
        
        [PreserveSig]
        void PSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void IAGetInputLayout(/* [annotation] _Out_ */ out ID3D10InputLayout ppInputLayout);
        
        [PreserveSig]
        void IAGetVertexBuffers(/* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ out ID3D10Buffer[] ppVertexBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _Out_writes_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        void IAGetIndexBuffer(/* [annotation] _Out_opt_ */ out ID3D10Buffer pIndexBuffer, /* [annotation] _Out_opt_ */ out DXGI_FORMAT Format, /* [annotation] _Out_opt_ */ out uint Offset);
        
        [PreserveSig]
        void GSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ out ID3D10Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void GSGetShader(/* [annotation] _Out_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        void IAGetPrimitiveTopology(/* [annotation] _Out_ */ out D3D_PRIMITIVE_TOPOLOGY pTopology);
        
        [PreserveSig]
        void VSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _Out_writes_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void VSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _Out_writes_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void GetPredication(/* [annotation] _Out_opt_ */ out ID3D10Predicate ppPredicate, /* [annotation] _Out_opt_ */ out bool pPredicateValue);
        
        [PreserveSig]
        void GSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* [annotation] _Out_writes_opt_(NumViews) */ out ID3D10ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void GSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* [annotation] _Out_writes_opt_(NumSamplers) */ out ID3D10SamplerState[] ppSamplers);
        
        [PreserveSig]
        void OMGetRenderTargets(/* [annotation] _In_range_( 0, D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* [annotation] _Out_writes_opt_(NumViews) */ out ID3D10RenderTargetView[] ppRenderTargetViews, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        void OMGetBlendState(/* [annotation] _Out_opt_ */ out ID3D10BlendState ppBlendState, /* [annotation] _Out_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _Out_opt_ */ out uint pSampleMask);
        
        [PreserveSig]
        void OMGetDepthStencilState(/* [annotation] _Out_opt_ */ out ID3D10DepthStencilState ppDepthStencilState, /* [annotation] _Out_opt_ */ out uint pStencilRef);
        
        [PreserveSig]
        void SOGetTargets(/* [annotation] _In_range_( 0, D3D10_SO_BUFFER_SLOT_COUNT ) */ uint NumBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ out ID3D10Buffer[] ppSOTargets, /* [annotation] _Out_writes_opt_(NumBuffers) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        void RSGetState(/* [annotation] _Out_ */ out ID3D10RasterizerState ppRasterizerState);
        
        [PreserveSig]
        void RSGetViewports(/* [annotation] _Inout_ _range(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] NumViewports, /* [annotation] _Out_writes_opt_(*NumViewports) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_VIEWPORT[] pViewports);
        
        [PreserveSig]
        void RSGetScissorRects(/* [annotation] _Inout_ _range(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] NumRects, /* [annotation] _Out_writes_opt_(*NumRects) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        HRESULT SetExceptionMode(uint RaiseFlags);
        
        [PreserveSig]
        uint GetExceptionMode();
        
        [PreserveSig]
        HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_(*pDataSize) */ out IntPtr pData);
        
        [PreserveSig]
        HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_(DataSize) */ out IntPtr pData);
        
        [PreserveSig]
        HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        void ClearState();
        
        [PreserveSig]
        void Flush();
        
        [PreserveSig]
        HRESULT CreateBuffer(/* [annotation] _In_ */ ref D3D10_BUFFER_DESC pDesc, /* [annotation] _In_opt_ */ ref D3D10_SUBRESOURCE_DATA pInitialData, /* [annotation] _Out_opt_ */ out ID3D10Buffer ppBuffer);
        
        [PreserveSig]
        HRESULT CreateTexture1D(/* [annotation] _In_ */ ref D3D10_TEXTURE1D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture1D ppTexture1D);
        
        [PreserveSig]
        HRESULT CreateTexture2D(/* [annotation] _In_ */ ref D3D10_TEXTURE2D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture2D ppTexture2D);
        
        [PreserveSig]
        HRESULT CreateTexture3D(/* [annotation] _In_ */ ref D3D10_TEXTURE3D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels)) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture3D ppTexture3D);
        
        [PreserveSig]
        HRESULT CreateShaderResourceView(/* [annotation] _In_ */ ID3D10Resource pResource, /* [annotation] _In_opt_ */ ref D3D10_SHADER_RESOURCE_VIEW_DESC pDesc, /* [annotation] _Out_opt_ */ out ID3D10ShaderResourceView ppSRView);
        
        [PreserveSig]
        HRESULT CreateRenderTargetView(/* [annotation] _In_ */ ID3D10Resource pResource, /* [annotation] _In_opt_ */ ref D3D10_RENDER_TARGET_VIEW_DESC pDesc, /* [annotation] _Out_opt_ */ out ID3D10RenderTargetView ppRTView);
        
        [PreserveSig]
        HRESULT CreateDepthStencilView(/* [annotation] _In_ */ ID3D10Resource pResource, /* [annotation] _In_opt_ */ ref D3D10_DEPTH_STENCIL_VIEW_DESC pDesc, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        HRESULT CreateInputLayout(/* [annotation] _In_reads_(NumElements) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D10_INPUT_ELEMENT_DESC[] pInputElementDescs, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ) */ uint NumElements, /* [annotation] _In_reads_(BytecodeLength) */ out IntPtr pShaderBytecodeWithInputSignature, /* [annotation] _In_ */ ulong BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10InputLayout ppInputLayout);
        
        [PreserveSig]
        HRESULT CreateVertexShader(/* [annotation] _In_reads_(BytecodeLength) */ out IntPtr pShaderBytecode, /* [annotation] _In_ */ ulong BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10VertexShader ppVertexShader);
        
        [PreserveSig]
        HRESULT CreateGeometryShader(/* [annotation] _In_reads_(BytecodeLength) */ out IntPtr pShaderBytecode, /* [annotation] _In_ */ ulong BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        HRESULT CreateGeometryShaderWithStreamOutput(/* [annotation] _In_reads_(BytecodeLength) */ out IntPtr pShaderBytecode, /* [annotation] _In_ */ ulong BytecodeLength, /* [annotation] _In_reads_opt_(NumEntries) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D10_SO_DECLARATION_ENTRY[] pSODeclaration, /* [annotation] _In_range_( 0, D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT ) */ uint NumEntries, /* [annotation] _In_ */ uint OutputStreamStride, /* [annotation] _Out_opt_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        HRESULT CreatePixelShader(/* [annotation] _In_reads_(BytecodeLength) */ out IntPtr pShaderBytecode, /* [annotation] _In_ */ ulong BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10PixelShader ppPixelShader);
        
        [PreserveSig]
        HRESULT CreateBlendState(/* [annotation] _In_ */ ref D3D10_BLEND_DESC pBlendStateDesc, /* [annotation] _Out_opt_ */ out ID3D10BlendState ppBlendState);
        
        [PreserveSig]
        HRESULT CreateDepthStencilState(/* [annotation] _In_ */ ref D3D10_DEPTH_STENCIL_DESC pDepthStencilDesc, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilState ppDepthStencilState);
        
        [PreserveSig]
        HRESULT CreateRasterizerState(/* [annotation] _In_ */ ref D3D10_RASTERIZER_DESC pRasterizerDesc, /* [annotation] _Out_opt_ */ out ID3D10RasterizerState ppRasterizerState);
        
        [PreserveSig]
        HRESULT CreateSamplerState(/* [annotation] _In_ */ ref D3D10_SAMPLER_DESC pSamplerDesc, /* [annotation] _Out_opt_ */ out ID3D10SamplerState ppSamplerState);
        
        [PreserveSig]
        HRESULT CreateQuery(/* [annotation] _In_ */ ref D3D10_QUERY_DESC pQueryDesc, /* [annotation] _Out_opt_ */ out ID3D10Query ppQuery);
        
        [PreserveSig]
        HRESULT CreatePredicate(/* [annotation] _In_ */ ref D3D10_QUERY_DESC pPredicateDesc, /* [annotation] _Out_opt_ */ out ID3D10Predicate ppPredicate);
        
        [PreserveSig]
        HRESULT CreateCounter(/* [annotation] _In_ */ ref D3D10_COUNTER_DESC pCounterDesc, /* [annotation] _Out_opt_ */ out ID3D10Counter ppCounter);
        
        [PreserveSig]
        HRESULT CheckFormatSupport(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out uint pFormatSupport);
        
        [PreserveSig]
        HRESULT CheckMultisampleQualityLevels(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint SampleCount, /* [annotation] _Out_ */ out uint pNumQualityLevels);
        
        [PreserveSig]
        void CheckCounterInfo(/* [annotation] _Out_ */ out D3D10_COUNTER_INFO pCounterInfo);
        
        [PreserveSig]
        HRESULT CheckCounter(/* [annotation] _In_ */ ref D3D10_COUNTER_DESC pDesc, /* [annotation] _Out_ */ out D3D10_COUNTER_TYPE pType, /* [annotation] _Out_ */ out uint pActiveCounters, /* [annotation] _Out_writes_opt_(*pNameLength) */ [MarshalAs(UnmanagedType.LPStr)] string szName, /* [annotation] _Inout_opt_ */ ref uint pNameLength, /* [annotation] _Out_writes_opt_(*pUnitsLength) */ [MarshalAs(UnmanagedType.LPStr)] string szUnits, /* [annotation] _Inout_opt_ */ ref uint pUnitsLength, /* [annotation] _Out_writes_opt_(*pDescriptionLength) */ [MarshalAs(UnmanagedType.LPStr)] string szDescription, /* [annotation] _Inout_opt_ */ ref uint pDescriptionLength);
        
        [PreserveSig]
        uint GetCreationFlags();
        
        [PreserveSig]
        HRESULT OpenSharedResource(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, /* [annotation] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        void SetTextFilterSize(/* [annotation] _In_ */ uint Width, /* [annotation] _In_ */ uint Height);
        
        [PreserveSig]
        void GetTextFilterSize(/* [annotation] _Out_opt_ */ out uint pWidth, /* [annotation] _Out_opt_ */ out uint pHeight);
    }
}
