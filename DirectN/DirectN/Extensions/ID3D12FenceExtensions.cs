using System;

namespace DirectN
{
    public static class ID3D12FenceExtensions
    {
        public static ulong GetCompletedValue(this IComObject<ID3D12Fence> resource) => GetCompletedValue(resource?.Object);
        public static ulong GetCompletedValue(this ID3D12Fence fence)
        {
            if (fence == null)
                throw new ArgumentNullException(nameof(fence));

            return fence.GetCompletedValue();
        }

        public static void Signal(this IComObject<ID3D12Fence> fence, ulong value) => Signal(fence?.Object, value);
        public static void Signal(this ID3D12Fence fence, ulong value)
        {
            if (fence == null)
                throw new ArgumentNullException(nameof(fence));

            fence.Signal(value).ThrowOnError();
        }

        public static void SetEventOnCompletion(this IComObject<ID3D12Fence> fence, ulong value, IntPtr @event) => SetEventOnCompletion(fence?.Object, value, @event);
        public static void SetEventOnCompletion(this ID3D12Fence fence, ulong value, IntPtr @event)
        {
            if (fence == null)
                throw new ArgumentNullException(nameof(fence));

            fence.SetEventOnCompletion(value, @event).ThrowOnError();
        }
    }
}
