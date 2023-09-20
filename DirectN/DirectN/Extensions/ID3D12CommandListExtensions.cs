using System;
using System.Collections.Generic;
using System.Linq;

namespace DirectN
{
    public static class ID3D12CommandListExtensions
    {
        public static void GetType(this IComObject<ID3D12CommandList> list) => GetType(list?.Object);
        public static D3D12_COMMAND_LIST_TYPE GetType(this ID3D12CommandList list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            return list.GetType();
        }

        public static void Close(this IComObject<ID3D12GraphicsCommandList> list) => Close(list?.Object);
        public static void Close(this ID3D12GraphicsCommandList list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.Close().ThrowOnError();
        }

        public static void Reset(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12CommandAllocator> allocator, IComObject<ID3D12PipelineState> initialState = null) => Reset(list?.Object, allocator?.Object, initialState?.Object);
        public static void Reset(this ID3D12GraphicsCommandList list, ID3D12CommandAllocator allocator, ID3D12PipelineState initialState = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (allocator == null)
                throw new ArgumentNullException(nameof(allocator));

            list.Reset(allocator, initialState).ThrowOnError();
        }

        public static void ClearState(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12PipelineState> pipelineState = null) => ClearState(list?.Object, pipelineState?.Object);
        public static void ClearState(this ID3D12GraphicsCommandList list, ID3D12PipelineState pipelineState = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.ClearState(pipelineState);
        }

        public static void DrawInstanced(this IComObject<ID3D12GraphicsCommandList> list, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation) => DrawInstanced(list?.Object, vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
        public static void DrawInstanced(this ID3D12GraphicsCommandList list, uint vertexCountPerInstance, uint instanceCount, uint startVertexLocation, uint startInstanceLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.DrawInstanced(vertexCountPerInstance, instanceCount, startVertexLocation, startInstanceLocation);
        }

        public static void DrawIndexedInstanced(this IComObject<ID3D12GraphicsCommandList> list, uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation) => DrawIndexedInstanced(list?.Object, indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
        public static void DrawIndexedInstanced(this ID3D12GraphicsCommandList list, uint indexCountPerInstance, uint instanceCount, uint startIndexLocation, int baseVertexLocation, uint startInstanceLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.DrawIndexedInstanced(indexCountPerInstance, instanceCount, startIndexLocation, baseVertexLocation, startInstanceLocation);
        }

        public static void Dispatch(this IComObject<ID3D12GraphicsCommandList> list, uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ) => Dispatch(list?.Object, threadGroupCountX, threadGroupCountY, threadGroupCountZ);
        public static void Dispatch(this ID3D12GraphicsCommandList list, uint threadGroupCountX, uint threadGroupCountY, uint threadGroupCountZ)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.Dispatch(threadGroupCountX, threadGroupCountY, threadGroupCountZ);
        }

        public static void CopyBufferRegion(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstBuffer, ulong dstOffset, IComObject<ID3D12Resource> srcBuffer, ulong srcOffset, ulong numBytes) => CopyBufferRegion(list?.Object, dstBuffer?.Object, dstOffset, srcBuffer?.Object, srcOffset, numBytes);
        public static void CopyBufferRegion(this ID3D12GraphicsCommandList list, ID3D12Resource dstBuffer, ulong dstOffset, ID3D12Resource srcBuffer, ulong srcOffset, ulong numBytes)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.CopyBufferRegion(dstBuffer, dstOffset, srcBuffer, srcOffset, numBytes);
        }

        public static void CopyTextureRegion(this IComObject<ID3D12GraphicsCommandList> list, D3D12_TEXTURE_COPY_LOCATION dst, uint dstX, uint dstY, uint dstZ, D3D12_TEXTURE_COPY_LOCATION src, D3D12_BOX? srcBox = null) => CopyTextureRegion(list?.Object, dst, dstX, dstY, dstZ, src, srcBox);
        public static void CopyTextureRegion(this ID3D12GraphicsCommandList list, D3D12_TEXTURE_COPY_LOCATION dst, uint dstX, uint dstY, uint dstZ, D3D12_TEXTURE_COPY_LOCATION src, D3D12_BOX? srcBox = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            using (var mem = new ComMemory(srcBox))
            {
                list.CopyTextureRegion(ref dst, dstX, dstY, dstZ, ref src, mem.Pointer);
            }
        }

        public static void CopyResource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstResource, IComObject<ID3D12Resource> srcResource) => CopyResource(list?.Object, dstResource?.Object, srcResource?.Object);
        public static void CopyResource(this ID3D12GraphicsCommandList list, ID3D12Resource dstResource, ID3D12Resource srcResource)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.CopyResource(dstResource, srcResource);
        }

        public static void CopyTiles(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> tiledResource, D3D12_TILED_RESOURCE_COORDINATE tileRegionStartCoordinate, D3D12_TILE_REGION_SIZE tileRegionSize, IComObject<ID3D12Resource> buffer, ulong bufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS flags) => CopyTiles(list?.Object, tiledResource?.Object, tileRegionStartCoordinate, tileRegionSize, buffer?.Object, bufferStartOffsetInBytes, flags);
        public static void CopyTiles(this ID3D12GraphicsCommandList list, ID3D12Resource tiledResource, D3D12_TILED_RESOURCE_COORDINATE tileRegionStartCoordinate, D3D12_TILE_REGION_SIZE tileRegionSize, ID3D12Resource buffer, ulong bufferStartOffsetInBytes, D3D12_TILE_COPY_FLAGS flags)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.CopyTiles(tiledResource, tileRegionStartCoordinate, tileRegionSize, buffer, bufferStartOffsetInBytes, flags);
        }

        public static void ResolveSubresource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> dstResource, uint dstSubresource, IComObject<ID3D12Resource> srcResource, uint srcSubresource, DXGI_FORMAT format) => ResolveSubresource(list?.Object, dstResource?.Object, dstSubresource, srcResource?.Object, srcSubresource, format);
        public static void ResolveSubresource(this ID3D12GraphicsCommandList list, ID3D12Resource dstResource, uint dstSubresource, ID3D12Resource srcResource, uint srcSubresource, DXGI_FORMAT format)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.ResolveSubresource(dstResource, dstSubresource, srcResource, srcSubresource, format);
        }

        public static void IASetPrimitiveTopology(this IComObject<ID3D12GraphicsCommandList> list, D3D_PRIMITIVE_TOPOLOGY primitiveTopology) => IASetPrimitiveTopology(list?.Object, primitiveTopology);
        public static void IASetPrimitiveTopology(this ID3D12GraphicsCommandList list, D3D_PRIMITIVE_TOPOLOGY primitiveTopology)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.IASetPrimitiveTopology(primitiveTopology);
        }

        public static void RSSetViewports(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_VIEWPORT> viewports) => RSSetViewports(list?.Object, viewports);
        public static void RSSetViewports(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_VIEWPORT> viewports)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (viewports == null)
                throw new ArgumentNullException(nameof(viewports));

            var array = viewports.ToArray();
            list.RSSetViewports(array.Length, array);
        }

        public static void RSSetScissorRects(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<tagRECT> rects) => RSSetScissorRects(list?.Object, rects);
        public static void RSSetScissorRects(this ID3D12GraphicsCommandList list, IEnumerable<tagRECT> rects)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            var array = rects.ToArray();
            list.RSSetScissorRects(array.Length, array);
        }

        public static void OMSetBlendFactor(this IComObject<ID3D12GraphicsCommandList> list, IReadOnlyList<float> blendFactor) => OMSetBlendFactor(list?.Object, blendFactor);
        public static void OMSetBlendFactor(this ID3D12GraphicsCommandList list, IReadOnlyList<float> blendFactor)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (blendFactor == null || blendFactor.Count != 4)
                throw new ArgumentNullException(nameof(blendFactor));

            list.OMSetBlendFactor(blendFactor);
        }

        public static void OMSetStencilRef(this IComObject<ID3D12GraphicsCommandList> list, uint stencilRef) => OMSetStencilRef(list?.Object, stencilRef);
        public static void OMSetStencilRef(this ID3D12GraphicsCommandList list, uint stencilRef)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.OMSetStencilRef(stencilRef);
        }

        public static void SetPipelineState(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12PipelineState> pipelineState) => SetPipelineState(list?.Object, pipelineState?.Object);
        public static void SetPipelineState(this ID3D12GraphicsCommandList list, ID3D12PipelineState pipelineState)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (pipelineState == null)
                throw new ArgumentNullException(nameof(pipelineState));

            list.SetPipelineState(pipelineState);
        }

        public static void ResourceBarrier(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_RESOURCE_BARRIER> barriers) => ResourceBarrier(list?.Object, barriers);
        public static void ResourceBarrier(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_RESOURCE_BARRIER> barriers)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (barriers == null)
                throw new ArgumentNullException(nameof(barriers));

            var array = barriers.ToArray();
            list.ResourceBarrier(array.Length, array);
        }

        public static void ExecuteBundle(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12GraphicsCommandList> commandLists) => ExecuteBundle(list?.Object, commandLists?.Object);
        public static void ExecuteBundle(this ID3D12GraphicsCommandList list, ID3D12GraphicsCommandList commandLists)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (commandLists == null)
                throw new ArgumentNullException(nameof(commandLists));

            list.ExecuteBundle(commandLists);
        }

        public static void SetDescriptorHeaps(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<IComObject<ID3D12DescriptorHeap>> heaps) => SetDescriptorHeaps(list?.Object, heaps?.Select(h => h.Object));
        public static void SetDescriptorHeaps(this ID3D12GraphicsCommandList list, IEnumerable<ID3D12DescriptorHeap> heaps)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (heaps == null)
                throw new ArgumentNullException(nameof(heaps));

            var array = heaps.ToArray();
            list.SetDescriptorHeaps(array.Length, array);
        }

        public static void SetComputeRootSignature(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12RootSignature> rootSignature = null) => SetComputeRootSignature(list?.Object, rootSignature?.Object);
        public static void SetComputeRootSignature(this ID3D12GraphicsCommandList list, ID3D12RootSignature rootSignature = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRootSignature(rootSignature);
        }

        public static void SetGraphicsRootSignature(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12RootSignature> rootSignature = null) => SetGraphicsRootSignature(list?.Object, rootSignature?.Object);
        public static void SetGraphicsRootSignature(this ID3D12GraphicsCommandList list, ID3D12RootSignature rootSignature = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRootSignature(rootSignature);
        }

        public static void SetComputeRootDescriptorTable(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor) => SetComputeRootDescriptorTable(list?.Object, rootParameterIndex, baseDescriptor);
        public static void SetComputeRootDescriptorTable(this ID3D12GraphicsCommandList list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRootDescriptorTable(rootParameterIndex, baseDescriptor);
        }

        public static void SetGraphicsRootDescriptorTable(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor) => SetGraphicsRootDescriptorTable(list?.Object, rootParameterIndex, baseDescriptor);
        public static void SetGraphicsRootDescriptorTable(this ID3D12GraphicsCommandList list, uint rootParameterIndex, D3D12_GPU_DESCRIPTOR_HANDLE baseDescriptor)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRootDescriptorTable(rootParameterIndex, baseDescriptor);
        }

        public static void SetComputeRoot32BitConstant(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) => SetComputeRoot32BitConstant(list?.Object, rootParameterIndex, srcData, destOffsetIn32BitValues);
        public static void SetComputeRoot32BitConstant(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRoot32BitConstant(rootParameterIndex, srcData, destOffsetIn32BitValues);
        }

        public static void SetGraphicsRoot32BitConstant(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues) => SetGraphicsRoot32BitConstant(list?.Object, rootParameterIndex, srcData, destOffsetIn32BitValues);
        public static void SetGraphicsRoot32BitConstant(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint srcData, uint destOffsetIn32BitValues)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRoot32BitConstant(rootParameterIndex, srcData, destOffsetIn32BitValues);
        }

        public static void SetComputeRoot32BitConstants(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint num32BitValuesToSet, IntPtr srcData, uint destOffsetIn32BitValues) => SetComputeRoot32BitConstants(list?.Object, rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
        public static void SetComputeRoot32BitConstants(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint num32BitValuesToSet, IntPtr srcData, uint destOffsetIn32BitValues)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRoot32BitConstants(rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
        }

        public static void SetGraphicsRoot32BitConstants(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, uint num32BitValuesToSet, IntPtr srcData, uint destOffsetIn32BitValues) => SetGraphicsRoot32BitConstants(list?.Object, rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
        public static void SetGraphicsRoot32BitConstants(this ID3D12GraphicsCommandList list, uint rootParameterIndex, uint num32BitValuesToSet, IntPtr srcData, uint destOffsetIn32BitValues)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRoot32BitConstants(rootParameterIndex, num32BitValuesToSet, srcData, destOffsetIn32BitValues);
        }

        public static void SetComputeRootConstantBufferView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootConstantBufferView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetComputeRootConstantBufferView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRootConstantBufferView(rootParameterIndex, bufferLocation);
        }

        public static void SetGraphicsRootConstantBufferView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootConstantBufferView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetGraphicsRootConstantBufferView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRootConstantBufferView(rootParameterIndex, bufferLocation);
        }

        public static void SetComputeRootShaderResourceView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootShaderResourceView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetComputeRootShaderResourceView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRootShaderResourceView(rootParameterIndex, bufferLocation);
        }

        public static void SetGraphicsRootShaderResourceView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootShaderResourceView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetGraphicsRootShaderResourceView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRootShaderResourceView(rootParameterIndex, bufferLocation);
        }

        public static void SetComputeRootUnorderedAccessView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetComputeRootUnorderedAccessView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetComputeRootUnorderedAccessView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetComputeRootUnorderedAccessView(rootParameterIndex, bufferLocation);
        }

        public static void SetGraphicsRootUnorderedAccessView(this IComObject<ID3D12GraphicsCommandList> list, uint rootParameterIndex, ulong bufferLocation) => SetGraphicsRootUnorderedAccessView(list?.Object, rootParameterIndex, bufferLocation);
        public static void SetGraphicsRootUnorderedAccessView(this ID3D12GraphicsCommandList list, uint rootParameterIndex, ulong bufferLocation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetGraphicsRootUnorderedAccessView(rootParameterIndex, bufferLocation);
        }

        public static void IASetIndexBuffer(this IComObject<ID3D12GraphicsCommandList> list, D3D12_INDEX_BUFFER_VIEW? view = null) => IASetIndexBuffer(list?.Object, view);
        public static void IASetIndexBuffer(this ID3D12GraphicsCommandList list, D3D12_INDEX_BUFFER_VIEW? view = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            using (var mem = new ComMemory(view))
            {
                list.IASetIndexBuffer(mem.Pointer);
            }
        }

        public static void IASetVertexBuffers(this IComObject<ID3D12GraphicsCommandList> list, uint startSlot, IEnumerable<D3D12_VERTEX_BUFFER_VIEW> views) => IASetVertexBuffers(list?.Object, startSlot, views);
        public static void IASetVertexBuffers(this ID3D12GraphicsCommandList list, uint startSlot, IEnumerable<D3D12_VERTEX_BUFFER_VIEW> views)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (views == null)
                throw new ArgumentNullException(nameof(views));

            var array = views.ToArray();
            list.IASetVertexBuffers(startSlot, array.Length, array);
        }

        public static void SOSetTargets(this IComObject<ID3D12GraphicsCommandList> list, uint startSlot, IEnumerable<D3D12_STREAM_OUTPUT_BUFFER_VIEW> views) => SOSetTargets(list?.Object, startSlot, views);
        public static void SOSetTargets(this ID3D12GraphicsCommandList list, uint startSlot, IEnumerable<D3D12_STREAM_OUTPUT_BUFFER_VIEW> views)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (views == null)
                throw new ArgumentNullException(nameof(views));

            var array = views.ToArray();
            list.SOSetTargets(startSlot, array.Length, array);
        }

        public static void OMSetRenderTargets(this IComObject<ID3D12GraphicsCommandList> list, IEnumerable<D3D12_CPU_DESCRIPTOR_HANDLE> renderTargetDescriptors, bool rtsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE? depthStencilDescriptor = null) => OMSetRenderTargets(list?.Object, renderTargetDescriptors, rtsSingleHandleToDescriptorRange, depthStencilDescriptor);
        public static void OMSetRenderTargets(this ID3D12GraphicsCommandList list, IEnumerable<D3D12_CPU_DESCRIPTOR_HANDLE> renderTargetDescriptors, bool rtsSingleHandleToDescriptorRange, D3D12_CPU_DESCRIPTOR_HANDLE? depthStencilDescriptor = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (renderTargetDescriptors == null)
                throw new ArgumentNullException(nameof(renderTargetDescriptors));

            var array = renderTargetDescriptors.ToArray();
            using (var mem = new ComMemory(depthStencilDescriptor))
            {
                list.OMSetRenderTargets(array.Length, array, rtsSingleHandleToDescriptorRange, mem.Pointer);
            }
        }

        public static void ClearDepthStencilView(this IComObject<ID3D12GraphicsCommandList> list, D3D12_CPU_DESCRIPTOR_HANDLE depthStencilView, D3D12_CLEAR_FLAGS clearFlags, float depth, byte stencil, IEnumerable<tagRECT> rects) => ClearDepthStencilView(list?.Object, depthStencilView, clearFlags, depth, stencil, rects);
        public static void ClearDepthStencilView(this ID3D12GraphicsCommandList list, D3D12_CPU_DESCRIPTOR_HANDLE depthStencilView, D3D12_CLEAR_FLAGS clearFlags, float depth, byte stencil, IEnumerable<tagRECT> rects)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            var array = rects.ToArray();
            list.ClearDepthStencilView(depthStencilView, clearFlags, depth, stencil, array.Length, array);
        }

        public static void ClearRenderTargetView(this IComObject<ID3D12GraphicsCommandList> list, D3D12_CPU_DESCRIPTOR_HANDLE renderTargetView, float[] colorRGBA, IEnumerable<tagRECT> rects) => ClearRenderTargetView(list?.Object, renderTargetView, colorRGBA, rects);
        public static void ClearRenderTargetView(this ID3D12GraphicsCommandList list, D3D12_CPU_DESCRIPTOR_HANDLE renderTargetView, float[] colorRGBA, IEnumerable<tagRECT> rects)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            var array = rects.ToArray();
            list.ClearRenderTargetView(renderTargetView, colorRGBA, array.Length, array);
        }

        public static void ClearUnorderedAccessViewUint(this IComObject<ID3D12GraphicsCommandList> list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, IComObject<ID3D12Resource> resource, uint[] values, IEnumerable<tagRECT> rects) => ClearUnorderedAccessViewUint(list?.Object, viewGPUHandleInCurrentHeap, viewCPUHandle, resource?.Object, values, rects);
        public static void ClearUnorderedAccessViewUint(this ID3D12GraphicsCommandList list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, ID3D12Resource resource, uint[] values, IEnumerable<tagRECT> rects)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            var array = rects.ToArray();
            list.ClearUnorderedAccessViewUint(viewGPUHandleInCurrentHeap, viewCPUHandle, resource, values, array.Length, array);
        }

        public static void ClearUnorderedAccessViewFloat(this IComObject<ID3D12GraphicsCommandList> list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, IComObject<ID3D12Resource> resource, float[] values, IEnumerable<tagRECT> rects) => ClearUnorderedAccessViewFloat(list?.Object, viewGPUHandleInCurrentHeap, viewCPUHandle, resource?.Object, values, rects);
        public static void ClearUnorderedAccessViewFloat(this ID3D12GraphicsCommandList list, D3D12_GPU_DESCRIPTOR_HANDLE viewGPUHandleInCurrentHeap, D3D12_CPU_DESCRIPTOR_HANDLE viewCPUHandle, ID3D12Resource resource, float[] values, IEnumerable<tagRECT> rects)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            if (rects == null)
                throw new ArgumentNullException(nameof(rects));

            var array = rects.ToArray();
            list.ClearUnorderedAccessViewFloat(viewGPUHandleInCurrentHeap, viewCPUHandle, resource, values, array.Length, array);
        }

        public static void DiscardResource(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> resource, D3D12_DISCARD_REGION? region = null) => DiscardResource(list?.Object, resource?.Object, region);
        public static void DiscardResource(this ID3D12GraphicsCommandList list, ID3D12Resource resource, D3D12_DISCARD_REGION? region = null)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            using (var mem = new ComMemory(region))
            {
                list.DiscardResource(resource, mem.Pointer);
            }
        }

        public static void BeginQuery(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint index) => BeginQuery(list?.Object, queryHeap?.Object, type, index);
        public static void BeginQuery(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint index)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (queryHeap == null)
                throw new ArgumentNullException(nameof(queryHeap));

            list.BeginQuery(queryHeap, type, index);
        }

        public static void EndQuery(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint index) => EndQuery(list?.Object, queryHeap?.Object, type, index);
        public static void EndQuery(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint index)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (queryHeap == null)
                throw new ArgumentNullException(nameof(queryHeap));

            list.EndQuery(queryHeap, type, index);
        }

        public static void ResolveQueryData(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12QueryHeap> queryHeap, D3D12_QUERY_TYPE type, uint startIndex, uint numQueries, IComObject<ID3D12Resource> destinationBuffer, ulong alignedDestinationBufferOffset) => ResolveQueryData(list?.Object, queryHeap?.Object, type, startIndex, numQueries, destinationBuffer?.Object, alignedDestinationBufferOffset);
        public static void ResolveQueryData(this ID3D12GraphicsCommandList list, ID3D12QueryHeap queryHeap, D3D12_QUERY_TYPE type, uint startIndex, uint numQueries, ID3D12Resource destinationBuffer, ulong alignedDestinationBufferOffset)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (queryHeap == null)
                throw new ArgumentNullException(nameof(queryHeap));

            if (destinationBuffer == null)
                throw new ArgumentNullException(nameof(destinationBuffer));

            list.ResolveQueryData(queryHeap, type, startIndex, numQueries, destinationBuffer, alignedDestinationBufferOffset);
        }

        public static void SetPredication(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12Resource> buffer, ulong alignedBufferOffset, D3D12_PREDICATION_OP operation) => SetPredication(list?.Object, buffer?.Object, alignedBufferOffset, operation);
        public static void SetPredication(this ID3D12GraphicsCommandList list, ID3D12Resource buffer, ulong alignedBufferOffset, D3D12_PREDICATION_OP operation)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            if (buffer == null)
                throw new ArgumentNullException(nameof(buffer));

            list.SetPredication(buffer, alignedBufferOffset, operation);
        }

        public static void SetMarker(this IComObject<ID3D12GraphicsCommandList> list, uint metadata, IntPtr data, uint size) => SetMarker(list?.Object, metadata, data, size);
        public static void SetMarker(this ID3D12GraphicsCommandList list, uint metadata, IntPtr data, uint size)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.SetMarker(metadata, data, size);
        }

        public static void BeginEvent(this IComObject<ID3D12GraphicsCommandList> list, uint metadata, IntPtr data, uint size) => BeginEvent(list?.Object, metadata, data, size);
        public static void BeginEvent(this ID3D12GraphicsCommandList list, uint metadata, IntPtr data, uint size)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.BeginEvent(metadata, data, size);
        }

        public static void EndEvent(this IComObject<ID3D12GraphicsCommandList> list) => EndEvent(list?.Object);
        public static void EndEvent(this ID3D12GraphicsCommandList list)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.EndEvent();
        }

        public static void ExecuteIndirect(this IComObject<ID3D12GraphicsCommandList> list, IComObject<ID3D12CommandSignature> commandSignature, uint maxCommandCount, IComObject<ID3D12Resource> argumentBuffer, ulong argumentBufferOffset, IComObject<ID3D12Resource> countBuffer = null, ulong countBufferOffset = 0) => ExecuteIndirect(list?.Object, commandSignature?.Object, maxCommandCount, argumentBuffer?.Object, argumentBufferOffset, countBuffer?.Object, countBufferOffset);
        public static void ExecuteIndirect(this ID3D12GraphicsCommandList list, ID3D12CommandSignature commandSignature, uint maxCommandCount, ID3D12Resource argumentBuffer, ulong argumentBufferOffset, ID3D12Resource countBuffer = null, ulong countBufferOffset = 0)
        {
            if (list == null)
                throw new ArgumentNullException(nameof(list));

            list.ExecuteIndirect(commandSignature, maxCommandCount, argumentBuffer, argumentBufferOffset, countBuffer, countBufferOffset);
        }
    }
}
