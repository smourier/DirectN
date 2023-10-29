using System;

namespace DirectN
{
    public static class IDXGIDeviceExtensions
    {
        public static int GetGPUThreadPriority(this IComObject<IDXGIDevice> output) => GetGPUThreadPriority(output?.Object);
        public static int GetGPUThreadPriority(this IDXGIDevice device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetGPUThreadPriority(out var priority).ThrowOnError();
            return priority;
        }

        public static uint GetMaximumFrameLatency(this IComObject<IDXGIDevice1> output) => GetMaximumFrameLatency(output?.Object);
        public static uint GetMaximumFrameLatency(this IDXGIDevice1 device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetMaximumFrameLatency(out var latency).ThrowOnError();
            return latency;
        }

        public static IComObject<IDXGIAdapter> GetAdapter(this IComObject<IDXGIDevice> output) => GetAdapter(output?.Object);
        public static IComObject<IDXGIAdapter> GetAdapter(this IDXGIDevice device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetAdapter(out var adapter).ThrowOnError();
            return new ComObject<IDXGIAdapter>(adapter);
        }
    }
}
