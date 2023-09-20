// generated from <Windows SDK Path>\um\d3d12.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("553103fb-1fe7-4557-bb38-946d7d0e7ca7"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12GraphicsCommandList1 : ID3D12GraphicsCommandList
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* optional(void) */ IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* optional(void) */ IntPtr pData);

        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* optional(IUnknown) */ IntPtr pData);

        [PreserveSig]
        new HRESULT SetName(/* _In_z_ */ [MarshalAs(UnmanagedType.LPWStr)] string Name);

        // ID3D12DeviceChild
        [PreserveSig]
        new HRESULT GetDevice([MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* _COM_Outptr_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppvDevice);

        // ID3D12CommandList
        [PreserveSig]
        new D3D12_COMMAND_LIST_TYPE GetType();

        // ID3D12GraphicsCommandList
        [PreserveSig]
        new HRESULT Close();

        [PreserveSig]
        new HRESULT Reset(/* _In_ */ ID3D12CommandAllocator pAllocator, /* _In_opt_ */ ID3D12PipelineState pInitialState);

        [PreserveSig]
        new void ClearState(/* _In_opt_ */ ID3D12PipelineState pPipelineState);

        [PreserveSig]
        new void DrawInstanced(/* _In_ */ uint VertexCountPerInstance, /* _In_ */ uint InstanceCount, /* _In_ */ uint StartVertexLocation, /* _In_ */ uint StartInstanceLocation);

        [PreserveSig]
        new void DrawIndexedInstanced(/* _In_ */ uint IndexCountPerInstance, /* _In_ */ uint InstanceCount, /* _In_ */ uint StartIndexLocation, /* _In_ */ int BaseVertexLocation, /* _In_ */ uint StartInstanceLocation);

        [PreserveSig]
        new void Dispatch(/* _In_ */ uint ThreadGroupCountX, /* _In_ */ uint ThreadGroupCountY, /* _In_ */ uint ThreadGroupCountZ);

        [PreserveSig]
        new void CopyBufferRegion(/* _In_ */ ID3D12Resource pDstBuffer, ulong DstOffset, /* _In_ */ ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes);

        [PreserveSig]
        new void CopyTextureRegion(/* _In_ */ ref D3D12_TEXTURE_COPY_LOCATION pDst, uint DstX, uint DstY, uint DstZ, /* _In_ */ ref D3D12_TEXTURE_COPY_LOCATION pSrc, /* optional(D3D12_BOX) */ IntPtr pSrcBox);

        [PreserveSig]
        new void CopyResource(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ ID3D12Resource pSrcResource);

        [PreserveSig]
        new void CopyTiles(/* _In_ */ ID3D12Resource pTiledResource, /* _In_ */ ref D3D12_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, /* _In_ */ ref D3D12_TILE_REGION_SIZE pTileRegionSize, /* _In_ */ ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);

        [PreserveSig]
        new void ResolveSubresource(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ uint DstSubresource, /* _In_ */ ID3D12Resource pSrcResource, /* _In_ */ uint SrcSubresource, /* _In_ */ DXGI_FORMAT Format);

        [PreserveSig]
        new void IASetPrimitiveTopology(/* _In_ */ D3D_PRIMITIVE_TOPOLOGY PrimitiveTopology);

        [PreserveSig]
        new void RSSetViewports(/* _In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumViewports, /* _In_reads_( NumViewports) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_VIEWPORT[] pViewports);

        [PreserveSig]
        new void RSSetScissorRects(/* _In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ int NumRects, /* _In_reads_( NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] tagRECT[] pRects);

        [PreserveSig]
        new void OMSetBlendFactor(/* _In_reads_opt_(4) */ [In, Out, MarshalAs(UnmanagedType.LPArray, SizeConst = 4)] float[] BlendFactor);

        [PreserveSig]
        new void OMSetStencilRef(/* _In_ */ uint StencilRef);

        [PreserveSig]
        new void SetPipelineState(/* _In_ */ ID3D12PipelineState pPipelineState);

        [PreserveSig]
        new void ResourceBarrier(/* _In_ */ int NumBarriers, /* _In_reads_(NumBarriers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);

        [PreserveSig]
        new void ExecuteBundle(/* _In_ */ ID3D12GraphicsCommandList pCommandList);

        [PreserveSig]
        new void SetDescriptorHeaps(/* _In_ */ int NumDescriptorHeaps, /* _In_reads_(NumDescriptorHeaps) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ID3D12DescriptorHeap[] ppDescriptorHeaps);

        [PreserveSig]
        new void SetComputeRootSignature(/* _In_opt_ */ ID3D12RootSignature pRootSignature);

        [PreserveSig]
        new void SetGraphicsRootSignature(/* _In_opt_ */ ID3D12RootSignature pRootSignature);

        [PreserveSig]
        new void SetComputeRootDescriptorTable(/* _In_ */ uint RootParameterIndex, /* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [PreserveSig]
        new void SetGraphicsRootDescriptorTable(/* _In_ */ uint RootParameterIndex, /* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);

        [PreserveSig]
        new void SetComputeRoot32BitConstant(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint SrcData, /* _In_ */ uint DestOffsetIn32BitValues);

        [PreserveSig]
        new void SetGraphicsRoot32BitConstant(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint SrcData, /* _In_ */ uint DestOffsetIn32BitValues);

        [PreserveSig]
        new void SetComputeRoot32BitConstants(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint Num32BitValuesToSet, /* _In_reads_(Num32BitValuesToSet*sizeof(UINT)) */ IntPtr pSrcData, /* _In_ */ uint DestOffsetIn32BitValues);

        [PreserveSig]
        new void SetGraphicsRoot32BitConstants(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint Num32BitValuesToSet, /* _In_reads_(Num32BitValuesToSet*sizeof(UINT)) */ IntPtr pSrcData, /* _In_ */ uint DestOffsetIn32BitValues);

        [PreserveSig]
        new void SetComputeRootConstantBufferView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void SetGraphicsRootConstantBufferView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void SetComputeRootShaderResourceView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void SetGraphicsRootShaderResourceView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void SetComputeRootUnorderedAccessView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void SetGraphicsRootUnorderedAccessView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);

        [PreserveSig]
        new void IASetIndexBuffer(/* optional(D3D12_INDEX_BUFFER_VIEW) */ IntPtr pView);

        [PreserveSig]
        new void IASetVertexBuffers(/* _In_ */ uint StartSlot, /* _In_ */ int NumViews, /* _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_VERTEX_BUFFER_VIEW[] pViews);

        [PreserveSig]
        new void SOSetTargets(/* _In_ */ uint StartSlot, /* _In_ */ int NumViews, /* _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_STREAM_OUTPUT_BUFFER_VIEW[] pViews);

        [PreserveSig]
        new void OMSetRenderTargets(/* _In_ */ int NumRenderTargetDescriptors, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_CPU_DESCRIPTOR_HANDLE[] pRenderTargetDescriptors, /* _In_ */ bool RTsSingleHandleToDescriptorRange, /* optional(D3D12_CPU_DESCRIPTOR_HANDLE) */ IntPtr pDepthStencilDescriptor);

        [PreserveSig]
        new void ClearDepthStencilView(/* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, /* _In_ */ D3D12_CLEAR_FLAGS ClearFlags, /* _In_ */ float Depth, /* _In_ */ byte Stencil, /* _In_ */ int NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] tagRECT[] pRects);

        [PreserveSig]
        new void ClearRenderTargetView(/* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA, /* _In_ */ int NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] tagRECT[] pRects);

        [PreserveSig]
        new void ClearUnorderedAccessViewUint(/* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, /* _In_ */ ID3D12Resource pResource, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] Values, /* _In_ */ int NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] tagRECT[] pRects);

        [PreserveSig]
        new void ClearUnorderedAccessViewFloat(/* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, /* _In_ */ ID3D12Resource pResource, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Values, /* _In_ */ int NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] tagRECT[] pRects);

        [PreserveSig]
        new void DiscardResource(/* _In_ */ ID3D12Resource pResource, /* optional(D3D12_DISCARD_REGION) */ IntPtr pRegion);

        [PreserveSig]
        new void BeginQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);

        [PreserveSig]
        new void EndQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);

        [PreserveSig]
        new void ResolveQueryData(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);

        [PreserveSig]
        new void SetPredication(/* _In_opt_ */ ID3D12Resource pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);

        [PreserveSig]
        new void SetMarker(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);

        [PreserveSig]
        new void BeginEvent(uint Metadata, /* optional(void) */ IntPtr pData, uint Size);

        [PreserveSig]
        new void EndEvent();

        [PreserveSig]
        new void ExecuteIndirect(/* _In_ */ ID3D12CommandSignature pCommandSignature, /* _In_ */ uint MaxCommandCount, /* _In_ */ ID3D12Resource pArgumentBuffer, /* _In_ */ ulong ArgumentBufferOffset, /* _In_opt_ */ ID3D12Resource pCountBuffer, /* _In_ */ ulong CountBufferOffset);

        // ID3D12GraphicsCommandList1
        [PreserveSig]
        void AtomicCopyBufferUINT(/* _In_ */ ID3D12Resource pDstBuffer, ulong DstOffset, /* _In_ */ ID3D12Resource pSrcBuffer, ulong SrcOffset, int Dependencies, /* _In_reads_(Dependencies) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ID3D12Resource[] ppDependentResources, /* _In_reads_(Dependencies) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_SUBRESOURCE_RANGE_UINT64[] pDependentSubresourceRanges);

        [PreserveSig]
        void AtomicCopyBufferUINT64(/* _In_ */ ID3D12Resource pDstBuffer, ulong DstOffset, /* _In_ */ ID3D12Resource pSrcBuffer, ulong SrcOffset, int Dependencies, /* _In_reads_(Dependencies) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] ID3D12Resource[] ppDependentResources, /* _In_reads_(Dependencies) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_SUBRESOURCE_RANGE_UINT64[] pDependentSubresourceRanges);

        [PreserveSig]
        void OMSetDepthBounds(/* _In_ */ float Min, /* _In_ */ float Max);

        [PreserveSig]
        void SetSamplePositions(/* _In_ */ uint NumSamplesPerPixel, /* _In_ */ uint NumPixels, /* _In_reads_(NumSamplesPerPixel*NumPixels) */ [MarshalAs(UnmanagedType.LPArray)] D3D12_SAMPLE_POSITION[] pSamplePositions);

        [PreserveSig]
        void ResolveSubresourceRegion(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ uint DstSubresource, /* _In_ */ uint DstX, /* _In_ */ uint DstY, /* _In_ */ ID3D12Resource pSrcResource, /* _In_ */ uint SrcSubresource, /* optional(tagRECT) */ IntPtr pSrcRect, /* _In_ */ DXGI_FORMAT Format, /* _In_ */ D3D12_RESOLVE_MODE ResolveMode);

        [PreserveSig]
        void SetViewInstanceMask(/* _In_ */ uint Mask);
    }
}
