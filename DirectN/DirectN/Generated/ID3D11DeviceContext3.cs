// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\d3d11_3.h(2144,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("b4e3c01d-e79e-4637-91b2-510e9f4c9b8f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DeviceContext3 : ID3D11DeviceContext2
    {
        // ID3D11DeviceChild
        [PreserveSig]
        new void GetDevice(/* [annotation] _Outptr_ */ out ID3D11Device ppDevice);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* [annotation] _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);
        
        // ID3D11DeviceContext
        [PreserveSig]
        new void VSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void PSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void PSSetShader(/* [annotation] _In_opt_ */ ID3D11PixelShader pPixelShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void PSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void VSSetShader(/* [annotation] _In_opt_ */ ID3D11VertexShader pVertexShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void DrawIndexed(/* [annotation] _In_ */ uint IndexCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation);
        
        [PreserveSig]
        new void Draw(/* [annotation] _In_ */ uint VertexCount, /* [annotation] _In_ */ uint StartVertexLocation);
        
        [PreserveSig]
        new HRESULT Map(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ uint Subresource, /* [annotation] _In_ */ D3D11_MAP MapType, /* [annotation] _In_ */ uint MapFlags, /* [annotation] _Out_opt_ */ out D3D11_MAPPED_SUBRESOURCE pMappedResource);
        
        [PreserveSig]
        new void Unmap(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ uint Subresource);
        
        [PreserveSig]
        new void PSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void IASetInputLayout(/* [annotation] _In_opt_ */ ID3D11InputLayout pInputLayout);
        
        [PreserveSig]
        new void IASetVertexBuffers(/* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppVertexBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        new void IASetIndexBuffer(/* [annotation] _In_opt_ */ ID3D11Buffer pIndexBuffer, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint Offset);
        
        [PreserveSig]
        new void DrawIndexedInstanced(/* [annotation] _In_ */ uint IndexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        new void DrawInstanced(/* [annotation] _In_ */ uint VertexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        new void GSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void GSSetShader(/* [annotation] _In_opt_ */ ID3D11GeometryShader pShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void IASetPrimitiveTopology(/* [annotation] _In_ */ D3D_PRIMITIVE_TOPOLOGY Topology);
        
        [PreserveSig]
        new void VSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void VSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void Begin(/* [annotation] _In_ */ ID3D11Asynchronous pAsync);
        
        [PreserveSig]
        new void End(/* [annotation] _In_ */ ID3D11Asynchronous pAsync);
        
        [PreserveSig]
        new HRESULT GetData(/* [annotation] _In_ */ ID3D11Asynchronous pAsync, /* optional(void) */ IntPtr pData, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ uint GetDataFlags);
        
        [PreserveSig]
        new void SetPredication(/* [annotation] _In_opt_ */ ID3D11Predicate pPredicate, /* [annotation] _In_ */ bool PredicateValue);
        
        [PreserveSig]
        new void GSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void GSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void OMSetRenderTargets(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11RenderTargetView[] ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D11DepthStencilView pDepthStencilView);
        
        [PreserveSig]
        new void OMSetRenderTargetsAndUnorderedAccessViews(/* [annotation] _In_ */ int NumRTVs, /* [annotation] _In_reads_opt_(NumRTVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11RenderTargetView[] ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D11DepthStencilView pDepthStencilView, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint UAVStartSlot, /* [annotation] _In_ */ int NumUAVs, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ID3D11UnorderedAccessView[] ppUnorderedAccessViews, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] pUAVInitialCounts);
        
        [PreserveSig]
        new void OMSetBlendState(/* [annotation] _In_opt_ */ ID3D11BlendState pBlendState, /* [annotation] _In_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _In_ */ uint SampleMask);
        
        [PreserveSig]
        new void OMSetDepthStencilState(/* [annotation] _In_opt_ */ ID3D11DepthStencilState pDepthStencilState, /* [annotation] _In_ */ uint StencilRef);
        
        [PreserveSig]
        new void SOSetTargets(/* [annotation] _In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11Buffer[] ppSOTargets, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        new void DrawAuto();
        
        [PreserveSig]
        new void DrawIndexedInstancedIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        new void DrawInstancedIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        new void Dispatch(/* [annotation] _In_ */ uint ThreadGroupCountX, /* [annotation] _In_ */ uint ThreadGroupCountY, /* [annotation] _In_ */ uint ThreadGroupCountZ);
        
        [PreserveSig]
        new void DispatchIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        new void RSSetState(/* [annotation] _In_opt_ */ ID3D11RasterizerState pRasterizerState);
        
        [PreserveSig]
        new void RSSetViewports(/* [annotation] _In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumViewports, /* [annotation] _In_reads_opt_(NumViewports) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D11_VIEWPORT[] pViewports);
        
        [PreserveSig]
        new void RSSetScissorRects(/* [annotation] _In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumRects, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        new void CopySubresourceRegion(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        new void CopyResource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ ID3D11Resource pSrcResource);
        
        [PreserveSig]
        new void UpdateSubresource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ IntPtr pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        new void CopyStructureCount(/* [annotation] _In_ */ ID3D11Buffer pDstBuffer, /* [annotation] _In_ */ uint DstAlignedByteOffset, /* [annotation] _In_ */ ID3D11UnorderedAccessView pSrcView);
        
        [PreserveSig]
        new void ClearRenderTargetView(/* [annotation] _In_ */ ID3D11RenderTargetView pRenderTargetView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA);
        
        [PreserveSig]
        new void ClearUnorderedAccessViewUint(/* [annotation] _In_ */ ID3D11UnorderedAccessView pUnorderedAccessView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] Values);
        
        [PreserveSig]
        new void ClearUnorderedAccessViewFloat(/* [annotation] _In_ */ ID3D11UnorderedAccessView pUnorderedAccessView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Values);
        
        [PreserveSig]
        new void ClearDepthStencilView(/* [annotation] _In_ */ ID3D11DepthStencilView pDepthStencilView, /* [annotation] _In_ */ uint ClearFlags, /* [annotation] _In_ */ float Depth, /* [annotation] _In_ */ byte Stencil);
        
        [PreserveSig]
        new void GenerateMips(/* [annotation] _In_ */ ID3D11ShaderResourceView pShaderResourceView);
        
        [PreserveSig]
        new void SetResourceMinLOD(/* [annotation] _In_ */ ID3D11Resource pResource, float MinLOD);
        
        [PreserveSig]
        new float GetResourceMinLOD(/* [annotation] _In_ */ ID3D11Resource pResource);
        
        [PreserveSig]
        new void ResolveSubresource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* [annotation] _In_ */ DXGI_FORMAT Format);
        
        [PreserveSig]
        new void ExecuteCommandList(/* [annotation] _In_ */ ID3D11CommandList pCommandList, bool RestoreContextState);
        
        [PreserveSig]
        new void HSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void HSSetShader(/* [annotation] _In_opt_ */ ID3D11HullShader pHullShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void HSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void HSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void DSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void DSSetShader(/* [annotation] _In_opt_ */ ID3D11DomainShader pDomainShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void DSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void DSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void CSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        new void CSSetUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) */ int NumUAVs, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11UnorderedAccessView[] ppUnorderedAccessViews, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pUAVInitialCounts);
        
        [PreserveSig]
        new void CSSetShader(/* [annotation] _In_opt_ */ ID3D11ComputeShader pComputeShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        new void CSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        new void CSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        new void VSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void PSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void PSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11PixelShader ppPixelShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void PSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void VSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11VertexShader ppVertexShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void PSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void IAGetInputLayout(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11InputLayout ppInputLayout);
        
        [PreserveSig]
        new void IAGetVertexBuffers(/* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppVertexBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        new void IAGetIndexBuffer(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11Buffer pIndexBuffer, /* [annotation] _Out_opt_ */ out DXGI_FORMAT Format, /* [annotation] _Out_opt_ */ out uint Offset);
        
        [PreserveSig]
        new void GSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void GSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11GeometryShader ppGeometryShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void IAGetPrimitiveTopology(/* [annotation] _Out_ */ out D3D_PRIMITIVE_TOPOLOGY pTopology);
        
        [PreserveSig]
        new void VSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void VSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void GetPredication(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11Predicate ppPredicate, /* [annotation] _Out_opt_ */ out bool pPredicateValue);
        
        [PreserveSig]
        new void GSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void GSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void OMGetRenderTargets(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* optional(ID3D11RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        new void OMGetRenderTargetsAndUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumRTVs, /* optional(ID3D11RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilView ppDepthStencilView, /* [annotation] _In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - 1 ) */ uint UAVStartSlot, /* [annotation] _In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - UAVStartSlot ) */ uint NumUAVs, /* optional(ID3D11UnorderedAccessView) */ out IntPtr ppUnorderedAccessViews);
        
        [PreserveSig]
        new void OMGetBlendState(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11BlendState ppBlendState, /* [annotation] _Out_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _Out_opt_ */ out uint pSampleMask);
        
        [PreserveSig]
        new void OMGetDepthStencilState(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilState ppDepthStencilState, /* [annotation] _Out_opt_ */ out uint pStencilRef);
        
        [PreserveSig]
        new void SOGetTargets(/* [annotation] _In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppSOTargets);
        
        [PreserveSig]
        new void RSGetState(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11RasterizerState ppRasterizerState);
        
        [PreserveSig]
        new void RSGetViewports(/* [annotation] _Inout_ _range(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ ref int pNumViewports, /* [annotation] _Out_writes_opt_(*pNumViewports) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D11_VIEWPORT[] pViewports);
        
        [PreserveSig]
        new void RSGetScissorRects(/* [annotation] _Inout_ _range(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ ref int pNumRects, /* [annotation] _Out_writes_opt_(*pNumRects) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        new void HSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void HSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11HullShader ppHullShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void HSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void HSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void DSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void DSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11DomainShader ppDomainShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void DSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void DSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void CSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        new void CSGetUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) */ uint NumUAVs, /* optional(ID3D11UnorderedAccessView) */ out IntPtr ppUnorderedAccessViews);
        
        [PreserveSig]
        new void CSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11ComputeShader ppComputeShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        new void CSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        new void CSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        new void ClearState();
        
        [PreserveSig]
        new void Flush();
        
        [PreserveSig]
        new D3D11_DEVICE_CONTEXT_TYPE GetType();
        
        [PreserveSig]
        new uint GetContextFlags();
        
        [PreserveSig]
        new HRESULT FinishCommandList(bool RestoreDeferredContextState, /* [annotation] _COM_Outptr_opt_ */ out ID3D11CommandList ppCommandList);
        
        // ID3D11DeviceContext1
        [PreserveSig]
        new void CopySubresourceRegion1(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        new void UpdateSubresource1(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ IntPtr pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch, /* [annotation] _In_ */ uint CopyFlags);
        
        [PreserveSig]
        new void DiscardResource(/* [annotation] _In_ */ ID3D11Resource pResource);
        
        [PreserveSig]
        new void DiscardView(/* [annotation] _In_ */ ID3D11View pResourceView);
        
        [PreserveSig]
        new void VSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void HSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void DSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void GSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void PSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void CSSetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void VSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void HSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void DSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void GSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void PSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void CSGetConstantBuffers1(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pFirstConstant, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pNumConstants);
        
        [PreserveSig]
        new void SwapDeviceContextState(/* [annotation] _In_ */ ID3DDeviceContextState pState, /* [annotation] _Outptr_opt_ */ out ID3DDeviceContextState ppPreviousState);
        
        [PreserveSig]
        new void ClearView(/* [annotation] _In_ */ ID3D11View pView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Color, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] tagRECT[] pRect, int NumRects);
        
        [PreserveSig]
        new void DiscardView1(/* [annotation] _In_ */ ID3D11View pResourceView, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] pRects, int NumRects);
        
        // ID3D11DeviceContext2
        [PreserveSig]
        new HRESULT UpdateTileMappings(/* [annotation] _In_ */ ID3D11Resource pTiledResource, /* [annotation] _In_ */ int NumTiledResourceRegions, /* [annotation] _In_reads_opt_(NumTiledResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_TILED_RESOURCE_COORDINATE[] pTiledResourceRegionStartCoordinates, /* [annotation] _In_reads_opt_(NumTiledResourceRegions) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D11_TILE_REGION_SIZE[] pTiledResourceRegionSizes, /* [annotation] _In_opt_ */ ID3D11Buffer pTilePool, /* [annotation] _In_ */ int NumRanges, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pRangeFlags, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pTilePoolStartOffsets, /* [annotation] _In_reads_opt_(NumRanges) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] uint[] pRangeTileCounts, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new HRESULT CopyTileMappings(/* [annotation] _In_ */ ID3D11Resource pDestTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pDestRegionStartCoordinate, /* [annotation] _In_ */ ID3D11Resource pSourceTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pSourceRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pTileRegionSize, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new void CopyTiles(/* [annotation] _In_ */ ID3D11Resource pTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pTileRegionSize, /* [annotation] _In_ */ ID3D11Buffer pBuffer, /* [annotation] _In_ */ ulong BufferStartOffsetInBytes, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new void UpdateTiles(/* [annotation] _In_ */ ID3D11Resource pDestTiledResource, /* [annotation] _In_ */ ref D3D11_TILED_RESOURCE_COORDINATE pDestTileRegionStartCoordinate, /* [annotation] _In_ */ ref D3D11_TILE_REGION_SIZE pDestTileRegionSize, /* [annotation] _In_ */ IntPtr pSourceTileData, /* [annotation] _In_ */ uint Flags);
        
        [PreserveSig]
        new HRESULT ResizeTilePool(/* [annotation] _In_ */ ID3D11Buffer pTilePool, /* [annotation] _In_ */ ulong NewSizeInBytes);
        
        [PreserveSig]
        new void TiledResourceBarrier(/* [annotation] _In_opt_ */ ID3D11DeviceChild pTiledResourceOrViewAccessBeforeBarrier, /* [annotation] _In_opt_ */ ID3D11DeviceChild pTiledResourceOrViewAccessAfterBarrier);
        
        [PreserveSig]
        new bool IsAnnotationEnabled();
        
        [PreserveSig]
        new void SetMarkerInt(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLabel, int Data);
        
        [PreserveSig]
        new void BeginEventInt(/* [annotation] _In_ */ [MarshalAs(UnmanagedType.LPWStr)] string pLabel, int Data);
        
        [PreserveSig]
        new void EndEvent();
        
        // ID3D11DeviceContext3
        [PreserveSig]
        void Flush1(D3D11_CONTEXT_TYPE ContextType, /* optional(HANDLE) */ IntPtr hEvent);
        
        [PreserveSig]
        void SetHardwareProtectionState(/* [annotation] _In_ */ bool HwProtectionEnable);
        
        [PreserveSig]
        void GetHardwareProtectionState(/* [annotation] _Out_ */ out bool pHwProtectionEnable);
    }
}
