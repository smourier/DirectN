using System;

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
    }
}
