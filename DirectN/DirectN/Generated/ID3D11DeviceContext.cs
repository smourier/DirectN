// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11.h(7748,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("c0bfa96c-e089-44fb-8eaf-26f8796190da"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D11DeviceContext : ID3D11DeviceChild
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
        void VSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void PSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void PSSetShader(/* [annotation] _In_opt_ */ ID3D11PixelShader pPixelShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void PSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void VSSetShader(/* [annotation] _In_opt_ */ ID3D11VertexShader pVertexShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void DrawIndexed(/* [annotation] _In_ */ uint IndexCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation);
        
        [PreserveSig]
        void Draw(/* [annotation] _In_ */ uint VertexCount, /* [annotation] _In_ */ uint StartVertexLocation);
        
        [PreserveSig]
        HRESULT Map(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ uint Subresource, /* [annotation] _In_ */ D3D11_MAP MapType, /* [annotation] _In_ */ uint MapFlags, /* optional(D3D11_MAPPED_SUBRESOURCE) */ IntPtr pMappedResource);
        
        [PreserveSig]
        void Unmap(/* [annotation] _In_ */ ID3D11Resource pResource, /* [annotation] _In_ */ uint Subresource);
        
        [PreserveSig]
        void PSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void IASetInputLayout(/* [annotation] _In_opt_ */ ID3D11InputLayout pInputLayout);
        
        [PreserveSig]
        void IASetVertexBuffers(/* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppVertexBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        void IASetIndexBuffer(/* [annotation] _In_opt_ */ ID3D11Buffer pIndexBuffer, /* [annotation] _In_ */ DXGI_FORMAT Format, /* [annotation] _In_ */ uint Offset);
        
        [PreserveSig]
        void DrawIndexedInstanced(/* [annotation] _In_ */ uint IndexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartIndexLocation, /* [annotation] _In_ */ int BaseVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void DrawInstanced(/* [annotation] _In_ */ uint VertexCountPerInstance, /* [annotation] _In_ */ uint InstanceCount, /* [annotation] _In_ */ uint StartVertexLocation, /* [annotation] _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void GSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void GSSetShader(/* [annotation] _In_opt_ */ ID3D11GeometryShader pShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void IASetPrimitiveTopology(/* [annotation] _In_ */ D3D_PRIMITIVE_TOPOLOGY Topology);
        
        [PreserveSig]
        void VSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void VSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void Begin(/* [annotation] _In_ */ ID3D11Asynchronous pAsync);
        
        [PreserveSig]
        void End(/* [annotation] _In_ */ ID3D11Asynchronous pAsync);
        
        [PreserveSig]
        HRESULT GetData(/* [annotation] _In_ */ ID3D11Asynchronous pAsync, /* optional(void) */ IntPtr pData, /* [annotation] _In_ */ uint DataSize, /* [annotation] _In_ */ uint GetDataFlags);
        
        [PreserveSig]
        void SetPredication(/* [annotation] _In_opt_ */ ID3D11Predicate pPredicate, /* [annotation] _In_ */ bool PredicateValue);
        
        [PreserveSig]
        void GSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void GSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void OMSetRenderTargets(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11RenderTargetView[] ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D11DepthStencilView pDepthStencilView);
        
        [PreserveSig]
        void OMSetRenderTargetsAndUnorderedAccessViews(/* [annotation] _In_ */ int NumRTVs, /* [annotation] _In_reads_opt_(NumRTVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11RenderTargetView[] ppRenderTargetViews, /* [annotation] _In_opt_ */ ID3D11DepthStencilView pDepthStencilView, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint UAVStartSlot, /* [annotation] _In_ */ int NumUAVs, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ID3D11UnorderedAccessView[] ppUnorderedAccessViews, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] uint[] pUAVInitialCounts);
        
        [PreserveSig]
        void OMSetBlendState(/* [annotation] _In_opt_ */ ID3D11BlendState pBlendState, /* [annotation] _In_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* [annotation] _In_ */ uint SampleMask);
        
        [PreserveSig]
        void OMSetDepthStencilState(/* [annotation] _In_opt_ */ ID3D11DepthStencilState pDepthStencilState, /* [annotation] _In_ */ uint StencilRef);
        
        [PreserveSig]
        void SOSetTargets(/* [annotation] _In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D11Buffer[] ppSOTargets, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pOffsets);
        
        [PreserveSig]
        void DrawAuto();
        
        [PreserveSig]
        void DrawIndexedInstancedIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        void DrawInstancedIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        void Dispatch(/* [annotation] _In_ */ uint ThreadGroupCountX, /* [annotation] _In_ */ uint ThreadGroupCountY, /* [annotation] _In_ */ uint ThreadGroupCountZ);
        
        [PreserveSig]
        void DispatchIndirect(/* [annotation] _In_ */ ID3D11Buffer pBufferForArgs, /* [annotation] _In_ */ uint AlignedByteOffsetForArgs);
        
        [PreserveSig]
        void RSSetState(/* [annotation] _In_opt_ */ ID3D11RasterizerState pRasterizerState);
        
        [PreserveSig]
        void RSSetViewports(/* [annotation] _In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumViewports, /* [annotation] _In_reads_opt_(NumViewports) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D11_VIEWPORT[] pViewports);
        
        [PreserveSig]
        void RSSetScissorRects(/* [annotation] _In_range_(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumRects, /* [annotation] _In_reads_opt_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        void CopySubresourceRegion(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ uint DstX, /* [annotation] _In_ */ uint DstY, /* [annotation] _In_ */ uint DstZ, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* optional(D3D11_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        void CopyResource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ ID3D11Resource pSrcResource);
        
        [PreserveSig]
        void UpdateSubresource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* optional(D3D11_BOX) */ IntPtr pDstBox, /* [annotation] _In_ */ IntPtr pSrcData, /* [annotation] _In_ */ uint SrcRowPitch, /* [annotation] _In_ */ uint SrcDepthPitch);
        
        [PreserveSig]
        void CopyStructureCount(/* [annotation] _In_ */ ID3D11Buffer pDstBuffer, /* [annotation] _In_ */ uint DstAlignedByteOffset, /* [annotation] _In_ */ ID3D11UnorderedAccessView pSrcView);
        
        [PreserveSig]
        void ClearRenderTargetView(/* [annotation] _In_ */ ID3D11RenderTargetView pRenderTargetView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA);
        
        [PreserveSig]
        void ClearUnorderedAccessViewUint(/* [annotation] _In_ */ ID3D11UnorderedAccessView pUnorderedAccessView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] Values);
        
        [PreserveSig]
        void ClearUnorderedAccessViewFloat(/* [annotation] _In_ */ ID3D11UnorderedAccessView pUnorderedAccessView, /* [annotation] _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Values);
        
        [PreserveSig]
        void ClearDepthStencilView(/* [annotation] _In_ */ ID3D11DepthStencilView pDepthStencilView, /* [annotation] _In_ */ uint ClearFlags, /* [annotation] _In_ */ float Depth, /* [annotation] _In_ */ byte Stencil);
        
        [PreserveSig]
        void GenerateMips(/* [annotation] _In_ */ ID3D11ShaderResourceView pShaderResourceView);
        
        [PreserveSig]
        void SetResourceMinLOD(/* [annotation] _In_ */ ID3D11Resource pResource, float MinLOD);
        
        [PreserveSig]
        float GetResourceMinLOD(/* [annotation] _In_ */ ID3D11Resource pResource);
        
        [PreserveSig]
        void ResolveSubresource(/* [annotation] _In_ */ ID3D11Resource pDstResource, /* [annotation] _In_ */ uint DstSubresource, /* [annotation] _In_ */ ID3D11Resource pSrcResource, /* [annotation] _In_ */ uint SrcSubresource, /* [annotation] _In_ */ DXGI_FORMAT Format);
        
        [PreserveSig]
        void ExecuteCommandList(/* [annotation] _In_ */ ID3D11CommandList pCommandList, bool RestoreContextState);
        
        [PreserveSig]
        void HSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void HSSetShader(/* [annotation] _In_opt_ */ ID3D11HullShader pHullShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void HSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void HSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void DSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void DSSetShader(/* [annotation] _In_opt_ */ ID3D11DomainShader pDomainShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void DSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void DSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void CSSetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumViews, /* [annotation] _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11ShaderResourceView[] ppShaderResourceViews);
        
        [PreserveSig]
        void CSSetUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) */ int NumUAVs, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11UnorderedAccessView[] ppUnorderedAccessViews, /* [annotation] _In_reads_opt_(NumUAVs) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pUAVInitialCounts);
        
        [PreserveSig]
        void CSSetShader(/* [annotation] _In_opt_ */ ID3D11ComputeShader pComputeShader, /* [annotation] _In_reads_opt_(NumClassInstances) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] ID3D11ClassInstance[] ppClassInstances, int NumClassInstances);
        
        [PreserveSig]
        void CSSetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ int NumSamplers, /* [annotation] _In_reads_opt_(NumSamplers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11SamplerState[] ppSamplers);
        
        [PreserveSig]
        void CSSetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* [annotation] _In_reads_opt_(NumBuffers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ID3D11Buffer[] ppConstantBuffers);
        
        [PreserveSig]
        void VSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void PSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void PSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11PixelShader ppPixelShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void PSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void VSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11VertexShader ppVertexShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void PSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void IAGetInputLayout(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11InputLayout ppInputLayout);
        
        [PreserveSig]
        void IAGetVertexBuffers(/* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_IA_VERTEX_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ int NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppVertexBuffers, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pStrides, /* [annotation] _Out_writes_opt_(NumBuffers) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] uint[] pOffsets);
        
        [PreserveSig]
        void IAGetIndexBuffer(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11Buffer pIndexBuffer, /* optional(DXGI_FORMAT) */ IntPtr Format, /* optional(UINT) */ IntPtr Offset);
        
        [PreserveSig]
        void GSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void GSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11GeometryShader ppGeometryShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void IAGetPrimitiveTopology(/* [annotation] _Out_ */ out D3D_PRIMITIVE_TOPOLOGY pTopology);
        
        [PreserveSig]
        void VSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void VSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void GetPredication(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11Predicate ppPredicate, /* optional(BOOL) */ IntPtr pPredicateValue);
        
        [PreserveSig]
        void GSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void GSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void OMGetRenderTargets(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumViews, /* optional(ID3D11RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilView ppDepthStencilView);
        
        [PreserveSig]
        void OMGetRenderTargetsAndUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_SIMULTANEOUS_RENDER_TARGET_COUNT ) */ uint NumRTVs, /* optional(ID3D11RenderTargetView) */ out IntPtr ppRenderTargetViews, /* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilView ppDepthStencilView, /* [annotation] _In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - 1 ) */ uint UAVStartSlot, /* [annotation] _In_range_( 0, D3D11_PS_CS_UAV_REGISTER_COUNT - UAVStartSlot ) */ uint NumUAVs, /* optional(ID3D11UnorderedAccessView) */ out IntPtr ppUnorderedAccessViews);
        
        [PreserveSig]
        void OMGetBlendState(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11BlendState ppBlendState, /* [annotation] _Out_opt_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor, /* optional(UINT) */ IntPtr pSampleMask);
        
        [PreserveSig]
        void OMGetDepthStencilState(/* [annotation] _Outptr_opt_result_maybenull_ */ out ID3D11DepthStencilState ppDepthStencilState, /* optional(UINT) */ IntPtr pStencilRef);
        
        [PreserveSig]
        void SOGetTargets(/* [annotation] _In_range_( 0, D3D11_SO_BUFFER_SLOT_COUNT ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppSOTargets);
        
        [PreserveSig]
        void RSGetState(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11RasterizerState ppRasterizerState);
        
        [PreserveSig]
        void RSGetViewports(/* [annotation] _Inout_ _range(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ ref int pNumViewports, /* [annotation] _Out_writes_opt_(*pNumViewports) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D11_VIEWPORT[] pViewports);
        
        [PreserveSig]
        void RSGetScissorRects(/* [annotation] _Inout_ _range(0, D3D11_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE ) */ ref int pNumRects, /* [annotation] _Out_writes_opt_(*pNumRects) */ [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);
        
        [PreserveSig]
        void HSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void HSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11HullShader ppHullShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void HSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void HSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void DSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void DSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11DomainShader ppDomainShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void DSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void DSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void CSGetShaderResources(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_INPUT_RESOURCE_SLOT_COUNT - StartSlot ) */ uint NumViews, /* optional(ID3D11ShaderResourceView) */ out IntPtr ppShaderResourceViews);
        
        [PreserveSig]
        void CSGetUnorderedAccessViews(/* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_1_UAV_SLOT_COUNT - StartSlot ) */ uint NumUAVs, /* optional(ID3D11UnorderedAccessView) */ out IntPtr ppUnorderedAccessViews);
        
        [PreserveSig]
        void CSGetShader(/* [annotation] _Outptr_result_maybenull_ */ out ID3D11ComputeShader ppComputeShader, /* optional(ID3D11ClassInstance) */ out IntPtr ppClassInstances, /* optional(UINT) */ IntPtr pNumClassInstances);
        
        [PreserveSig]
        void CSGetSamplers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_SAMPLER_SLOT_COUNT - StartSlot ) */ uint NumSamplers, /* optional(ID3D11SamplerState) */ out IntPtr ppSamplers);
        
        [PreserveSig]
        void CSGetConstantBuffers(/* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - 1 ) */ uint StartSlot, /* [annotation] _In_range_( 0, D3D11_COMMONSHADER_CONSTANT_BUFFER_API_SLOT_COUNT - StartSlot ) */ uint NumBuffers, /* optional(ID3D11Buffer) */ out IntPtr ppConstantBuffers);
        
        [PreserveSig]
        void ClearState();
        
        [PreserveSig]
        void Flush();
        
        [PreserveSig]
        D3D11_DEVICE_CONTEXT_TYPE GetType();
        
        [PreserveSig]
        uint GetContextFlags();
        
        [PreserveSig]
        HRESULT FinishCommandList(bool RestoreDeferredContextState, /* [annotation] _COM_Outptr_opt_ */ out ID3D11CommandList ppCommandList);
    }
}
