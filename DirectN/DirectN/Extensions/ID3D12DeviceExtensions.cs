using System;

namespace DirectN
{
    public static class ID3D12DeviceExtensions
    {
        public static IComObject<ID3D12CommandAllocator> CreateCommandAllocator(this IComObject<ID3D12Device> device, D3D12_COMMAND_LIST_TYPE type) => CreateCommandAllocator(device?.Object, type);
        public static IComObject<ID3D12CommandAllocator> CreateCommandAllocator(this ID3D12Device device, D3D12_COMMAND_LIST_TYPE type)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateCommandAllocator(type, typeof(ID3D12CommandAllocator).GUID, out var allocator).ThrowOnError();
            return new ComObject<ID3D12CommandAllocator>((ID3D12CommandAllocator)allocator);
        }

        public static IComObject<ID3D12CommandList> CreateCommandList(this IComObject<ID3D12Device> device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, IComObject<ID3D12CommandAllocator> commandAllocator, IComObject<ID3D12PipelineState> initialState = null) => CreateCommandList<ID3D12CommandList>(device?.Object, nodeMask, type, commandAllocator?.Object, initialState?.Object);
        public static IComObject<ID3D12CommandList> CreateCommandList(this ID3D12Device device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator commandAllocator, ID3D12PipelineState initialState = null) => CreateCommandList<ID3D12CommandList>(device, nodeMask, type, commandAllocator, initialState);
        public static IComObject<T> CreateCommandList<T>(this IComObject<ID3D12Device> device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, IComObject<ID3D12CommandAllocator> commandAllocator, IComObject<ID3D12PipelineState> initialState = null) where T : ID3D12CommandList => CreateCommandList<T>(device?.Object, nodeMask, type, commandAllocator?.Object, initialState?.Object);
        public static IComObject<T> CreateCommandList<T>(this ID3D12Device device, uint nodeMask, D3D12_COMMAND_LIST_TYPE type, ID3D12CommandAllocator commandAllocator, ID3D12PipelineState initialState = null) where T : ID3D12CommandList
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateCommandList(nodeMask, type, commandAllocator, initialState, typeof(T).GUID, out var list).ThrowOnError();
            return new ComObject<T>((T)list);
        }

        public static IComObject<ID3D12CommandQueue> CreateCommandQueue(this IComObject<ID3D12Device> device, D3D12_COMMAND_QUEUE_DESC desc) => CreateCommandQueue(device?.Object, desc);
        public static IComObject<ID3D12CommandQueue> CreateCommandQueue(this ID3D12Device device, D3D12_COMMAND_QUEUE_DESC desc)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateCommandQueue(ref desc, typeof(ID3D12CommandQueue).GUID, out var queue).ThrowOnError();
            return new ComObject<ID3D12CommandQueue>((ID3D12CommandQueue)queue);
        }

        public static IComObject<ID3D12DescriptorHeap> CreateDescriptorHeap(this IComObject<ID3D12Device> device, D3D12_DESCRIPTOR_HEAP_DESC desc) => CreateDescriptorHeap(device?.Object, desc);
        public static IComObject<ID3D12DescriptorHeap> CreateDescriptorHeap(this ID3D12Device device, D3D12_DESCRIPTOR_HEAP_DESC desc)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateDescriptorHeap(ref desc, typeof(ID3D12DescriptorHeap).GUID, out var heap).ThrowOnError();
            return new ComObject<ID3D12DescriptorHeap>((ID3D12DescriptorHeap)heap);
        }

        public static IComObject<ID3D12PipelineState> CreateGraphicsPipelineState(this IComObject<ID3D12Device> device, D3D12_GRAPHICS_PIPELINE_STATE_DESC desc) => CreateGraphicsPipelineState(device?.Object, desc);
        public static IComObject<ID3D12PipelineState> CreateGraphicsPipelineState(this ID3D12Device device, D3D12_GRAPHICS_PIPELINE_STATE_DESC desc)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateGraphicsPipelineState(ref desc, typeof(ID3D12PipelineState).GUID, out var state).ThrowOnError();
            return new ComObject<ID3D12PipelineState>((ID3D12PipelineState)state);
        }

        public static IComObject<ID3D12PipelineState> CreateComputePipelineState(this IComObject<ID3D12Device> device, D3D12_COMPUTE_PIPELINE_STATE_DESC desc) => CreateComputePipelineState(device?.Object, desc);
        public static IComObject<ID3D12PipelineState> CreateComputePipelineState(this ID3D12Device device, D3D12_COMPUTE_PIPELINE_STATE_DESC desc)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateComputePipelineState(ref desc, typeof(ID3D12PipelineState).GUID, out var state).ThrowOnError();
            return new ComObject<ID3D12PipelineState>((ID3D12PipelineState)state);
        }

        public static IComObject<ID3D12RootSignature> CreateRootSignature(this IComObject<ID3D12Device> device, uint nodeMask, IntPtr blobWithRootSignature, IntPtr blobLengthInBytes) => CreateRootSignature(device?.Object, nodeMask, blobWithRootSignature, blobLengthInBytes);
        public static IComObject<ID3D12RootSignature> CreateRootSignature(this ID3D12Device device, uint nodeMask, IntPtr blobWithRootSignature, IntPtr blobLengthInBytes)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateRootSignature(nodeMask, blobWithRootSignature, blobLengthInBytes, typeof(ID3D12RootSignature).GUID, out var sig).ThrowOnError();
            return new ComObject<ID3D12RootSignature>((ID3D12RootSignature)sig);
        }

        public static IComObject<ID3D12Heap> CreateHeap(this IComObject<ID3D12Device> device, D3D12_HEAP_DESC desc) => CreateHeap<ID3D12Heap>(device?.Object, desc);
        public static IComObject<ID3D12Heap> CreateHeap(this ID3D12Device device, D3D12_HEAP_DESC desc) => CreateHeap<ID3D12Heap>(device, desc);
        public static IComObject<T> CreateHeap<T>(this IComObject<ID3D12Device> device, D3D12_HEAP_DESC desc) where T : ID3D12Heap => CreateHeap<T>(device?.Object, desc);
        public static IComObject<T> CreateHeap<T>(this ID3D12Device device, D3D12_HEAP_DESC desc) where T : ID3D12Heap
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateHeap(desc, typeof(T).GUID, out var heap).ThrowOnError();
            return new ComObject<T>((T)heap);
        }

        public static void CopyDescriptorsSimple(this IComObject<ID3D12Device> device, int numDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE destDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE srcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE descriptorHeapsType) => CopyDescriptorsSimple(device?.Object, numDescriptors, destDescriptorRangeStart, srcDescriptorRangeStart, descriptorHeapsType);
        public static void CopyDescriptorsSimple(this ID3D12Device device, int numDescriptors, D3D12_CPU_DESCRIPTOR_HANDLE destDescriptorRangeStart, D3D12_CPU_DESCRIPTOR_HANDLE srcDescriptorRangeStart, D3D12_DESCRIPTOR_HEAP_TYPE descriptorHeapsType)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CopyDescriptorsSimple(numDescriptors, destDescriptorRangeStart, srcDescriptorRangeStart, descriptorHeapsType);
        }

        public static uint GetDescriptorHandleIncrementSize(this IComObject<ID3D12Device> device, D3D12_DESCRIPTOR_HEAP_TYPE type) => GetDescriptorHandleIncrementSize(device?.Object, type);
        public static uint GetDescriptorHandleIncrementSize(this ID3D12Device device, D3D12_DESCRIPTOR_HEAP_TYPE type)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            return device.GetDescriptorHandleIncrementSize(type);
        }

        public static uint GetNodeCount(this IComObject<ID3D12Device> device) => GetNodeCount(device?.Object);
        public static uint GetNodeCount(this ID3D12Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            return device.GetNodeCount();
        }

        public static _LUID GetAdapterLuid(this IComObject<ID3D12Device> device) => GetAdapterLuid(device?.Object);
        public static _LUID GetAdapterLuid(this ID3D12Device device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetAdapterLuid(out var luid);
            return luid;
        }

        public static IComObject<ID3D12Fence> CreateFence(this IComObject<ID3D12Device> device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) => CreateFence<ID3D12Fence>(device.Object, initialValue, flags);
        public static IComObject<ID3D12Fence> CreateFence(this ID3D12Device device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) => CreateFence<ID3D12Fence>(device, initialValue, flags);
        public static IComObject<T> CreateFence<T>(this IComObject<ID3D12Device> device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) where T : ID3D12Fence => CreateFence<T>(device.Object, initialValue, flags);
        public static IComObject<T> CreateFence<T>(this ID3D12Device device, ulong initialValue, D3D12_FENCE_FLAGS flags = D3D12_FENCE_FLAGS.D3D12_FENCE_FLAG_NONE) where T : ID3D12Fence
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateFence(initialValue, flags, typeof(T).GUID, out var fence).ThrowOnError();
            return new ComObject<T>((T)fence);
        }

        public static void CreateRenderTargetView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateRenderTargetView(device?.Object, resource?.Object, desc, handle);
        public static void CreateRenderTargetView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = new ComMemory(desc))
            {
                device.CreateRenderTargetView(resource, mem.Pointer, handle);
            }
        }

        public static void CreateConstantBufferView(this IComObject<ID3D12Device> device, D3D12_CONSTANT_BUFFER_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateConstantBufferView(device?.Object, desc, handle);
        public static void CreateConstantBufferView(this ID3D12Device device, D3D12_CONSTANT_BUFFER_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = new ComMemory(desc))
            {
                device.CreateConstantBufferView(mem.Pointer, handle);
            }
        }

        public static void CreateSampler(this IComObject<ID3D12Device> device, D3D12_SAMPLER_DESC desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateSampler(device?.Object, desc, handle);
        public static void CreateSampler(this ID3D12Device device, D3D12_SAMPLER_DESC desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.CreateSampler(ref desc, handle);
        }

        public static void CreateShaderResourceView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateShaderResourceView(device?.Object, resource?.Object, desc, handle);
        public static void CreateShaderResourceView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = new ComMemory(desc))
            {
                device.CreateShaderResourceView(resource, mem.Pointer, handle);
            }
        }

        public static void CreateDepthStencilView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateDepthStencilView(device?.Object, resource?.Object, desc, handle);
        public static void CreateDepthStencilView(this ID3D12Device device, ID3D12Resource resource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = new ComMemory(desc))
            {
                device.CreateDepthStencilView(resource, mem.Pointer, handle);
            }
        }

        public static void CreateUnorderedAccessView(this IComObject<ID3D12Device> device, IComObject<ID3D12Resource> resource, IComObject<ID3D12Resource> counterResource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle) => CreateUnorderedAccessView(device?.Object, resource?.Object, counterResource?.Object, desc, handle);
        public static void CreateUnorderedAccessView(this ID3D12Device device, ID3D12Resource resource, ID3D12Resource counterResource, D3D12_RENDER_TARGET_VIEW_DESC? desc, D3D12_CPU_DESCRIPTOR_HANDLE handle)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            using (var mem = new ComMemory(desc))
            {
                device.CreateUnorderedAccessView(resource, counterResource, mem.Pointer, handle);
            }
        }
    }
}
