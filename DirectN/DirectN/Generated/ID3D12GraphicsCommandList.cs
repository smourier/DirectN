// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d12.h(5288,5)
using System;
using System.Runtime.InteropServices;
using D3D12_PRIMITIVE_TOPOLOGY = DirectN.D3D_PRIMITIVE_TOPOLOGY;
using D3D12_RECT = DirectN.tagRECT;

namespace DirectN
{
    [Guid("5b160d0f-ac1b-4185-8ba8-b3ae42a5a455"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D12GraphicsCommandList : ID3D12CommandList
    {
        // ID3D12Object
        [PreserveSig]
        new HRESULT GetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _Inout_ */ ref uint pDataSize, /* _Out_writes_bytes_opt_( *pDataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] out object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateData(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_ */ uint DataSize, /* _In_reads_bytes_opt_( DataSize ) */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid guid, /* _In_opt_ */ [MarshalAs(UnmanagedType.IUnknown)] object pData);
        
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
        HRESULT Close();
        
        [PreserveSig]
        HRESULT Reset(/* _In_ */ ID3D12CommandAllocator pAllocator, /* _In_opt_ */ ID3D12PipelineState pInitialState);
        
        [PreserveSig]
        void ClearState(/* _In_opt_ */ ID3D12PipelineState pPipelineState);
        
        [PreserveSig]
        void DrawInstanced(/* _In_ */ uint VertexCountPerInstance, /* _In_ */ uint InstanceCount, /* _In_ */ uint StartVertexLocation, /* _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void DrawIndexedInstanced(/* _In_ */ uint IndexCountPerInstance, /* _In_ */ uint InstanceCount, /* _In_ */ uint StartIndexLocation, /* _In_ */ int BaseVertexLocation, /* _In_ */ uint StartInstanceLocation);
        
        [PreserveSig]
        void Dispatch(/* _In_ */ uint ThreadGroupCountX, /* _In_ */ uint ThreadGroupCountY, /* _In_ */ uint ThreadGroupCountZ);
        
        [PreserveSig]
        void CopyBufferRegion(/* _In_ */ ID3D12Resource pDstBuffer, ulong DstOffset, /* _In_ */ ID3D12Resource pSrcBuffer, ulong SrcOffset, ulong NumBytes);
        
        [PreserveSig]
        void CopyTextureRegion(/* _In_ */ ref D3D12_TEXTURE_COPY_LOCATION pDst, uint DstX, uint DstY, uint DstZ, /* _In_ */ ref D3D12_TEXTURE_COPY_LOCATION pSrc, /* optional(D3D12_BOX) */ IntPtr pSrcBox);
        
        [PreserveSig]
        void CopyResource(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ ID3D12Resource pSrcResource);
        
        [PreserveSig]
        void CopyTiles(/* _In_ */ ID3D12Resource pTiledResource, /* _In_ */ ref D3D12_TILED_RESOURCE_COORDINATE pTileRegionStartCoordinate, /* _In_ */ ref D3D12_TILE_REGION_SIZE pTileRegionSize, /* _In_ */ ID3D12Resource pBuffer, ulong BufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS Flags);
        
        [PreserveSig]
        void ResolveSubresource(/* _In_ */ ID3D12Resource pDstResource, /* _In_ */ uint DstSubresource, /* _In_ */ ID3D12Resource pSrcResource, /* _In_ */ uint SrcSubresource, /* _In_ */ DXGI_FORMAT Format);
        
        [PreserveSig]
        void IASetPrimitiveTopology(/* _In_ */ D3D12_PRIMITIVE_TOPOLOGY PrimitiveTopology);
        
        [PreserveSig]
        void RSSetViewports(/* _In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumViewports, /* _In_reads_( NumViewports) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_VIEWPORT[] pViewports);
        
        [PreserveSig]
        void RSSetScissorRects(/* _In_range_(0, D3D12_VIEWPORT_AND_SCISSORRECT_OBJECT_COUNT_PER_PIPELINE) */ uint NumRects, /* _In_reads_( NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RECT[] pRects);
        
        [PreserveSig]
        void OMSetBlendFactor(/* _In_reads_opt_(4) */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] BlendFactor);
        
        [PreserveSig]
        void OMSetStencilRef(/* _In_ */ uint StencilRef);
        
        [PreserveSig]
        void SetPipelineState(/* _In_ */ ID3D12PipelineState pPipelineState);
        
        [PreserveSig]
        void ResourceBarrier(/* _In_ */ uint NumBarriers, /* _In_reads_(NumBarriers) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] D3D12_RESOURCE_BARRIER[] pBarriers);
        
        [PreserveSig]
        void ExecuteBundle(/* _In_ */ ID3D12GraphicsCommandList pCommandList);
        
        [PreserveSig]
        void SetDescriptorHeaps(/* _In_ */ uint NumDescriptorHeaps, /* _In_reads_(NumDescriptorHeaps) */ out IntPtr ppDescriptorHeaps);
        
        [PreserveSig]
        void SetComputeRootSignature(/* _In_opt_ */ ID3D12RootSignature pRootSignature);
        
        [PreserveSig]
        void SetGraphicsRootSignature(/* _In_opt_ */ ID3D12RootSignature pRootSignature);
        
        [PreserveSig]
        void SetComputeRootDescriptorTable(/* _In_ */ uint RootParameterIndex, /* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
        
        [PreserveSig]
        void SetGraphicsRootDescriptorTable(/* _In_ */ uint RootParameterIndex, /* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE BaseDescriptor);
        
        [PreserveSig]
        void SetComputeRoot32BitConstant(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint SrcData, /* _In_ */ uint DestOffsetIn32BitValues);
        
        [PreserveSig]
        void SetGraphicsRoot32BitConstant(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint SrcData, /* _In_ */ uint DestOffsetIn32BitValues);
        
        [PreserveSig]
        void SetComputeRoot32BitConstants(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint Num32BitValuesToSet, /* _In_reads_(Num32BitValuesToSet*sizeof(UINT)) */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* _In_ */ uint DestOffsetIn32BitValues);
        
        [PreserveSig]
        void SetGraphicsRoot32BitConstants(/* _In_ */ uint RootParameterIndex, /* _In_ */ uint Num32BitValuesToSet, /* _In_reads_(Num32BitValuesToSet*sizeof(UINT)) */ [MarshalAs(UnmanagedType.IUnknown)] object pSrcData, /* _In_ */ uint DestOffsetIn32BitValues);
        
        [PreserveSig]
        void SetComputeRootConstantBufferView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void SetGraphicsRootConstantBufferView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void SetComputeRootShaderResourceView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void SetGraphicsRootShaderResourceView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void SetComputeRootUnorderedAccessView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void SetGraphicsRootUnorderedAccessView(/* _In_ */ uint RootParameterIndex, /* _In_ */ ulong BufferLocation);
        
        [PreserveSig]
        void IASetIndexBuffer(/* optional(D3D12_INDEX_BUFFER_VIEW) */ IntPtr pView);
        
        [PreserveSig]
        void IASetVertexBuffers(/* _In_ */ uint StartSlot, /* _In_ */ uint NumViews, /* _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_VERTEX_BUFFER_VIEW[] pViews);
        
        [PreserveSig]
        void SOSetTargets(/* _In_ */ uint StartSlot, /* _In_ */ uint NumViews, /* _In_reads_opt_(NumViews) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] D3D12_STREAM_OUTPUT_BUFFER_VIEW[] pViews);
        
        [PreserveSig]
        void OMSetRenderTargets(/* _In_ */ uint NumRenderTargetDescriptors, /* optional(D3D12_CPU_DESCRIPTOR_HANDLE) */ IntPtr pRenderTargetDescriptors, /* _In_ */ bool RTsSingleHandleToDescriptorRange, /* optional(D3D12_CPU_DESCRIPTOR_HANDLE) */ IntPtr pDepthStencilDescriptor);
        
        [PreserveSig]
        void ClearDepthStencilView(/* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE DepthStencilView, /* _In_ */ D3D12_CLEAR_FLAGS ClearFlags, /* _In_ */ float Depth, /* _In_ */ byte Stencil, /* _In_ */ uint NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_RECT[] pRects);
        
        [PreserveSig]
        void ClearRenderTargetView(/* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE RenderTargetView, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] ColorRGBA, /* _In_ */ uint NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] D3D12_RECT[] pRects);
        
        [PreserveSig]
        void ClearUnorderedAccessViewUint(/* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, /* _In_ */ ID3D12Resource pResource, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] uint[] Values, /* _In_ */ uint NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_RECT[] pRects);
        
        [PreserveSig]
        void ClearUnorderedAccessViewFloat(/* _In_ */ D3D12_GPU_DESCRIPTOR_HANDLE ViewGPUHandleInCurrentHeap, /* _In_ */ D3D12_CPU_DESCRIPTOR_HANDLE ViewCPUHandle, /* _In_ */ ID3D12Resource pResource, /* _In_ */ [In, Out, MarshalAs(UnmanagedType.LPArray)] float[] Values, /* _In_ */ uint NumRects, /* _In_reads_(NumRects) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] D3D12_RECT[] pRects);
        
        [PreserveSig]
        void DiscardResource(/* _In_ */ ID3D12Resource pResource, /* optional(D3D12_DISCARD_REGION) */ IntPtr pRegion);
        
        [PreserveSig]
        void BeginQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void EndQuery(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint Index);
        
        [PreserveSig]
        void ResolveQueryData(/* _In_ */ ID3D12QueryHeap pQueryHeap, /* _In_ */ D3D12_QUERY_TYPE Type, /* _In_ */ uint StartIndex, /* _In_ */ uint NumQueries, /* _In_ */ ID3D12Resource pDestinationBuffer, /* _In_ */ ulong AlignedDestinationBufferOffset);
        
        [PreserveSig]
        void SetPredication(/* _In_opt_ */ ID3D12Resource pBuffer, /* _In_ */ ulong AlignedBufferOffset, /* _In_ */ D3D12_PREDICATION_OP Operation);
        
        [PreserveSig]
        void SetMarker(uint Metadata, /* _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Size);
        
        [PreserveSig]
        void BeginEvent(uint Metadata, /* _In_reads_bytes_opt_(Size) */ [MarshalAs(UnmanagedType.IUnknown)] object pData, uint Size);
        
        [PreserveSig]
        void EndEvent();
        
        [PreserveSig]
        void ExecuteIndirect(/* _In_ */ ID3D12CommandSignature pCommandSignature, /* _In_ */ uint MaxCommandCount, /* _In_ */ ID3D12Resource pArgumentBuffer, /* _In_ */ ulong ArgumentBufferOffset, /* _In_opt_ */ ID3D12Resource pCountBuffer, /* _In_ */ ulong CountBufferOffset);
    }
}
