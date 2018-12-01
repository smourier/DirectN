// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d10_1.h(506,5)
using System;
using System.Runtime.InteropServices;
using D3D10_RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("9b7e4c8f-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Device1 : ID3D10Device
    {
        // ID3D10Device
        [PreserveSig]
        new void VSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void PSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void PSSetShader(/* [annotation] _In_opt_ */ ID3D10PixelShader pPixelShader);
        
        [PreserveSig]
        new void PSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void VSSetShader(/* [annotation] _In_opt_ */ ID3D10VertexShader pVertexShader);
        
        [PreserveSig]
        new void DrawIndexed(/* [annotation] _In_ */ uint IndexCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation);
        
        [PreserveSig]
        new void Draw(/* [annotation] _In_ */ uint VertexCount, /* [annotation] _In_ */ uint StartVertexLocation);
        
        [PreserveSig]
        new void PSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void IASetInputLayout(/* [annotation] _In_opt_ */ ID3D10InputLayout pInputLayout);
        
        [PreserveSig]
        new void IASetVertexBuffers(/* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppVertexBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        new void IASetIndexBuffer(/* [annotation] _In_opt_ */ ID3D10Buffer pIndexBuffer, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint Offset);
        
        [PreserveSig]
        new void DrawIndexedInstanced(/* [annotation] _In_ */ uint IndexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        new void DrawInstanced(/* [annotation] _In_ */ uint VertexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        new void GSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void GSSetShader(/* [annotation] _In_opt_ */ ID3D10GeometryShader pShader);
        
        [PreserveSig]
        new void IASetPrimitiveTopology(/* [annotation] _In_ */ D3D_PRIMITIVE_TOPOLOGY Topology);
        
        [PreserveSig]
        new void VSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void VSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void SetPredication(/* [annotation] _In_opt_ */ ID3D10Predicate pPredicate, /* [annotation] _In_ */ bool PredicateValue);
        
        [PreserveSig]
        new void GSSetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void GSSetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void OMSetRenderTargets(/* [annotation] _In_range_( 0, D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* optional(ID3D10RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D10DepthStencilView pDepthStencilView);
        
        [PreserveSig]
        new void OMSetBlendState(/* [annotation] _In_opt_ */ ID3D10BlendState pBlendState, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _In_ */ uint SampleMask);
        
        [PreserveSig]
        new void OMSetDepthStencilState(/* [annotation] _In_opt_ */ ID3D10DepthStencilState pDepthStencilState, /* [annotation] _In_ */ uint StencilRef);
        
        [PreserveSig]
        new void SOSetTargets(/* [annotation] _In_range_( 0, D3D10_SO_BUFFER_SLOT_COUNT) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppSOTargets, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        new void DrawAuto();
        
        [PreserveSig]
        new void RSSetState(/* [annotation] _In_opt_ */ ID3D10RasterizerState pRasterizerState);
        
        [PreserveSig]
        new void RSSetViewports(/* [annotation] _In_range_(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumViewports, /* [annotation] _In_reads_opt_(NumViewports) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_VIEWPORT[] pViewports);
        
        [PreserveSig]
        new void RSSetScissorRects(/* [annotation] _In_range_(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumRects, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_RECT[] pRects);
        
        [PreserveSig]
        new void CopySubresourceRegion(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ID3D10Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D10_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        new void CopyResource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ ID3D10Resource pSrcResource);
        
        [PreserveSig]
        new void UpdateSubresource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D10_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        new void ClearRenderTargetView(/* [annotation] _In_ */ ID3D10RenderTargetView pRenderTargetView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA);
        
        [PreserveSig]
        new void ClearDepthStencilView(/* [annotation] _In_ */ ID3D10DepthStencilView pDepthStencilView, /* [annotation] _In_ */ uint ClearFlags, /* [annotation] _In_ */ float Depth, /* [annotation] _In_ */ byte Stencil);
        
        [PreserveSig]
        new void GenerateMips(/* [annotation] _In_ */ ID3D10ShaderResourceView pShaderResourceView);
        
        [PreserveSig]
        new void ResolveSubresource(/* [annotation] _In_ */ ID3D10Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ ID3D10Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* [annotation] _In_ */ DXGI_FORMAT Format);
        
        [PreserveSig]
        new void VSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void PSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void PSGetShader(/* [annotation] _Out_ */ out ID3D10PixelShader ppPixelShader);
        
        [PreserveSig]
        new void PSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void VSGetShader(/* [annotation] _Out_ */ out ID3D10VertexShader ppVertexShader);
        
        [PreserveSig]
        new void PSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void IAGetInputLayout(/* [annotation] _Out_ */ out ID3D10InputLayout ppInputLayout);
        
        [PreserveSig]
        new void IAGetVertexBuffers(/* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppVertexBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        new void IAGetIndexBuffer(/* [annotation] _Out_opt_ */ out ID3D10Buffer pIndexBuffer, /* [annotation] _Out_opt_ */ out DXGI_FORMAT Format, /* [annotation] _Out_opt_ */ out uint Offset);
        
        [PreserveSig]
        new void GSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void GSGetShader(/* [annotation] _Out_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        new void IAGetPrimitiveTopology(/* [annotation] _Out_ */ out D3D_PRIMITIVE_TOPOLOGY pTopology);
        
        [PreserveSig]
        new void VSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void VSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void GetPredication(/* [annotation] _Out_opt_ */ out ID3D10Predicate ppPredicate, /* [annotation] _Out_opt_ */ out bool pPredicateValue);
        
        [PreserveSig]
        new void GSGetShaderResources(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D10ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void GSGetSamplers(/* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D10_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D10SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void OMGetRenderTargets(/* [annotation] _In_range_( 0, D3D10_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* optional(ID3D10RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        new void OMGetBlendState(/* [annotation] _Out_opt_ */ out ID3D10BlendState ppBlendState, /* [annotation] _Out_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float BlendFactor, /* [annotation] _Out_opt_ */ out uint pSampleMask);
        
        [PreserveSig]
        new void OMGetDepthStencilState(/* [annotation] _Out_opt_ */ out ID3D10DepthStencilState ppDepthStencilState, /* [annotation] _Out_opt_ */ out uint pStencilRef);
        
        [PreserveSig]
        new void SOGetTargets(/* [annotation] _In_range_( 0, D3D10_SO_BUFFER_SLOT_COUNT ) */ uint NumBuffers, /* optional(ID3D10Buffer) */ out IntPtr ppSOTargets, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        new void RSGetState(/* [annotation] _Out_ */ out ID3D10RasterizerState ppRasterizerState);
        
        [PreserveSig]
        new void RSGetViewports(/* [annotation] _Inout_ _range(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ [MarshalAs(UnmanagedType.LPArray)] uint[] NumViewports, /* [annotation] _Out_writes_opt_(*NumViewports) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_VIEWPORT[] pViewports);
        
        [PreserveSig]
        new void RSGetScissorRects(/* [annotation] _Inout_ _range(0, D3D10_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ [MarshalAs(UnmanagedType.LPArray)] uint[] NumRects, /* [annotation] _Out_writes_opt_(*NumRects) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D10_RECT[] pRects);
        
        [PreserveSig]
        new HRESULT GetDeviceRemovedReason();
        
        [PreserveSig]
        new HRESULT SetExceptionMode(uint RaiseFlags);
        
        [PreserveSig]
        new uint GetExceptionMode();
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* [annotation] _Out_writes_bytes_opt_(*pDataSize) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_reads_bytes_opt_(DataSize) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new void ClearState();
        
        [PreserveSig]
        new void Flush();
        
        [PreserveSig]
        new HRESULT CreateBuffer(/* [annotation] _In_ */ ref D3D10_BUFFER_DESC pDesc, /* optional(D3D10_SUBRESOURCE_DATA) */ IntPtr pInitialData, /* [annotation] _Out_opt_ */ out ID3D10Buffer ppBuffer);
        
        [PreserveSig]
        new HRESULT CreateTexture1D(/* [annotation] _In_ */ ref D3D10_TEXTURE1D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture1D ppTexture1D);
        
        [PreserveSig]
        new HRESULT CreateTexture2D(/* [annotation] _In_ */ ref D3D10_TEXTURE2D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels * pDesc->ArraySize)) */ [MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture2D ppTexture2D);
        
        [PreserveSig]
        new HRESULT CreateTexture3D(/* [annotation] _In_ */ ref D3D10_TEXTURE3D_DESC pDesc, /* [annotation] _In_reads_opt_(_Inexpressible_(pDesc->MipLevels)) */ [MarshalAs(UnmanagedType.LPArray)] D3D10_SUBRESOURCE_DATA[] pInitialData, /* [annotation] _Out_ */ out ID3D10Texture3D ppTexture3D);
        
        [PreserveSig]
        new HRESULT CreateShaderResourceView(/* [annotation] _In_ */ ID3D10Resource pResource, /* optional(D3D10_SHADER_RESOURCE_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _Out_opt_ */ out ID3D10ShaderResourceView ppSRView);
        
        [PreserveSig]
        new HRESULT CreateRenderTargetView(/* [annotation] _In_ */ ID3D10Resource pResource, /* optional(D3D10_RENDER_TARGET_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _Out_opt_ */ out ID3D10RenderTargetView ppRTView);
        
        [PreserveSig]
        new HRESULT CreateDepthStencilView(/* [annotation] _In_ */ ID3D10Resource pResource, /* optional(D3D10_DEPTH_STENCIL_VIEW_DESC) */ IntPtr pDesc, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        new HRESULT CreateInputLayout(/* [annotation] _In_reads_(NumElements) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D10_INPUT_ELEMENT_DESC[] pInputElementDescs, /* [annotation] _In_range_( 0, D3D10_1_IA_VERTEX_INPUT_STRUCTURE_ELEMENT_COUNT ) */ uint NumElements, /* [annotation] _In_reads_(BytecodeLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pShaderBytecodeWithInputSignature, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10InputLayout ppInputLayout);
        
        [PreserveSig]
        new HRESULT CreateVertexShader(/* [annotation] _In_reads_(BytecodeLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10VertexShader ppVertexShader);
        
        [PreserveSig]
        new HRESULT CreateGeometryShader(/* [annotation] _In_reads_(BytecodeLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        new HRESULT CreateGeometryShaderWithStreamOutput(/* [annotation] _In_reads_(BytecodeLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _In_reads_opt_(NumEntries) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] D3D10_SO_DECLARATION_ENTRY[] pSODeclaration, /* [annotation] _In_range_( 0, D3D10_SO_SINGLE_BUFFER_COMPONENT_LIMIT ) */ uint NumEntries, /* [annotation] _In_ */ uint OutputStreamStride, /* [annotation] _Out_opt_ */ out ID3D10GeometryShader ppGeometryShader);
        
        [PreserveSig]
        new HRESULT CreatePixelShader(/* [annotation] _In_reads_(BytecodeLength) */ [MarshalAs(UnmanagedType.IUnknown)] object pShaderBytecode, /* [annotation] _In_ */ IntPtr BytecodeLength, /* [annotation] _Out_opt_ */ out ID3D10PixelShader ppPixelShader);
        
        [PreserveSig]
        new HRESULT CreateBlendState(/* [annotation] _In_ */ ref D3D10_BLEND_DESC pBlendStateDesc, /* [annotation] _Out_opt_ */ out ID3D10BlendState ppBlendState);
        
        [PreserveSig]
        new HRESULT CreateDepthStencilState(/* [annotation] _In_ */ ref D3D10_DEPTH_STENCIL_DESC pDepthStencilDesc, /* [annotation] _Out_opt_ */ out ID3D10DepthStencilState ppDepthStencilState);
        
        [PreserveSig]
        new HRESULT CreateRasterizerState(/* [annotation] _In_ */ ref D3D10_RASTERIZER_DESC pRasterizerDesc, /* [annotation] _Out_opt_ */ out ID3D10RasterizerState ppRasterizerState);
        
        [PreserveSig]
        new HRESULT CreateSamplerState(/* [annotation] _In_ */ ref D3D10_SAMPLER_DESC pSamplerDesc, /* [annotation] _Out_opt_ */ out ID3D10SamplerState ppSamplerState);
        
        [PreserveSig]
        new HRESULT CreateQuery(/* [annotation] _In_ */ ref D3D10_QUERY_DESC pQueryDesc, /* [annotation] _Out_opt_ */ out ID3D10Query ppQuery);
        
        [PreserveSig]
        new HRESULT CreatePredicate(/* [annotation] _In_ */ ref D3D10_QUERY_DESC pPredicateDesc, /* [annotation] _Out_opt_ */ out ID3D10Predicate ppPredicate);
        
        [PreserveSig]
        new HRESULT CreateCounter(/* [annotation] _In_ */ ref D3D10_COUNTER_DESC pCounterDesc, /* [annotation] _Out_opt_ */ out ID3D10Counter ppCounter);
        
        [PreserveSig]
        new HRESULT CheckFormatSupport(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _Out_ */ out uint pFormatSupport);
        
        [PreserveSig]
        new HRESULT CheckMultisampleQualityLevels(/* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint SampleCount, /* [annotation] _Out_ */ out uint pNumQualityLevels);
        
        [PreserveSig]
        new void CheckCounterInfo(/* [annotation] _Out_ */ out D3D10_COUNTER_INFO pCounterInfo);
        
        [PreserveSig]
        new HRESULT CheckCounter(/* [annotation] _In_ */ ref D3D10_COUNTER_DESC pDesc, /* [annotation] _Out_ */ out D3D10_COUNTER_TYPE pType, /* [annotation] _Out_ */ out uint pActiveCounters, /* [annotation] _Out_writes_opt_(*pNameLength) */ [MarshalAs(UnmanagedType.LPStr)] string szName, /* optional(UINT) */ IntPtr pNameLength, /* [annotation] _Out_writes_opt_(*pUnitsLength) */ [MarshalAs(UnmanagedType.LPStr)] string szUnits, /* optional(UINT) */ IntPtr pUnitsLength, /* [annotation] _Out_writes_opt_(*pDescriptionLength) */ [MarshalAs(UnmanagedType.LPStr)] string szDescription, /* optional(UINT) */ IntPtr pDescriptionLength);
        
        [PreserveSig]
        new uint GetCreationFlags();
        
        [PreserveSig]
        new HRESULT OpenSharedResource(/* [annotation] _In_ */ IntPtr hResource, /* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid ReturnedInterface, /* [annotation] _Out_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppResource);
        
        [PreserveSig]
        new void SetTextFilterSize(/* [annotation] _In_ */ uint Width, /* [annotation] _In_ */ uint Height);
        
        [PreserveSig]
        new void GetTextFilterSize(/* [annotation] _Out_opt_ */ out uint pWidth, /* [annotation] _Out_opt_ */ out uint pHeight);
        
        // ID3D10Device1
        [PreserveSig]
        HRESULT CreateShaderResourceView1(/* [annotation] _In_ */ ID3D10Resource pResource, /* optional(D3D10_SHADER_RESOURCE_VIEW_DESC1) */ IntPtr pDesc, /* [annotation] _Out_opt_ */ out ID3D10ShaderResourceView1 ppSRView);
        
        [PreserveSig]
        HRESULT CreateBlendState1(/* [annotation] _In_ */ ref D3D10_BLEND_DESC1 pBlendStateDesc, /* [annotation] _Out_opt_ */ out ID3D10BlendState1 ppBlendState);
        
        [PreserveSig]
        D3D10_FEATURE_LEVEL1 GetFeatureLevel();
    }
}
