using System;

namespace DirectN
{
    public static class ID3D12DescriptorHeapExtensions
    {
        public static D3D12_DESCRIPTOR_HEAP_DESC GetDesc(this IComObject<ID3D12DescriptorHeap> device) => GetDesc(device?.Object);
        public static D3D12_DESCRIPTOR_HEAP_DESC GetDesc(this ID3D12DescriptorHeap heap)
        {
            if (heap == null)
                throw new ArgumentNullException(nameof(heap));

            heap.GetDesc(out var desc);
            return desc;
        }

        public static D3D12_GPU_DESCRIPTOR_HANDLE GetGPUDescriptorHandleForHeapStart(this IComObject<ID3D12DescriptorHeap> device) => GetGPUDescriptorHandleForHeapStart(device?.Object);
        public static D3D12_GPU_DESCRIPTOR_HANDLE GetGPUDescriptorHandleForHeapStart(this ID3D12DescriptorHeap heap)
        {
            if (heap == null)
                throw new ArgumentNullException(nameof(heap));

            heap.GetGPUDescriptorHandleForHeapStart(out var size);
            return size;
        }

        public static D3D12_CPU_DESCRIPTOR_HANDLE GetCPUDescriptorHandleForHeapStart(this IComObject<ID3D12DescriptorHeap> device) => GetCPUDescriptorHandleForHeapStart(device?.Object);
        public static D3D12_CPU_DESCRIPTOR_HANDLE GetCPUDescriptorHandleForHeapStart(this ID3D12DescriptorHeap heap)
        {
            if (heap == null)
                throw new ArgumentNullException(nameof(heap));

            heap.GetCPUDescriptorHandleForHeapStart(out var size);
            return size;
        }
    }
}
