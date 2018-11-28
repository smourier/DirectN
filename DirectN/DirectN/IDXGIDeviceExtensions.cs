using System;

namespace DirectN
{
    public static class IDXGIDeviceExtensions
    {
        public static ComObject<T> GetAdapter<T>(this ComObject<IDXGIDevice> device) where T : IDXGIAdapter => GetAdapter<T>(device?.Object);
        public static ComObject<T> GetAdapter<T>(this ComObject<IDXGIDevice1> device) where T : IDXGIAdapter => GetAdapter<T>(device?.Object);
        public static ComObject<T> GetAdapter<T>(this ComObject<IDXGIDevice2> device) where T : IDXGIAdapter => GetAdapter<T>(device?.Object);
        public static ComObject<T> GetAdapter<T>(this ComObject<IDXGIDevice3> device) where T : IDXGIAdapter => GetAdapter<T>(device?.Object);
        public static ComObject<T> GetAdapter<T>(this ComObject<IDXGIDevice4> device) where T : IDXGIAdapter => GetAdapter<T>(device?.Object);
        public static ComObject<T> GetAdapter<T>(this IDXGIDevice device) where T : IDXGIAdapter
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetAdapter(out IDXGIAdapter adapter).ThrowOnError();
            return new ComObject<T>((T)adapter);
        }

        public static int GetGPUThreadPriority(this ComObject<IDXGIDevice> device) => GetGPUThreadPriority(device?.Object);
        public static int GetGPUThreadPriority(this ComObject<IDXGIDevice1> device) => GetGPUThreadPriority(device?.Object);
        public static int GetGPUThreadPriority(this ComObject<IDXGIDevice2> device) => GetGPUThreadPriority(device?.Object);
        public static int GetGPUThreadPriority(this ComObject<IDXGIDevice3> device) => GetGPUThreadPriority(device?.Object);
        public static int GetGPUThreadPriority(this ComObject<IDXGIDevice4> device) => GetGPUThreadPriority(device?.Object);
        public static int GetGPUThreadPriority(this IDXGIDevice device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetGPUThreadPriority(out int priority).ThrowOnError();
            return priority;
        }

        public static void SetGPUThreadPriority(this ComObject<IDXGIDevice> device, int priority) => SetGPUThreadPriority(device?.Object, priority);
        public static void SetGPUThreadPriority(this ComObject<IDXGIDevice1> device, int priority) => SetGPUThreadPriority(device?.Object, priority);
        public static void SetGPUThreadPriority(this ComObject<IDXGIDevice2> device, int priority) => SetGPUThreadPriority(device?.Object, priority);
        public static void SetGPUThreadPriority(this ComObject<IDXGIDevice3> device, int priority) => SetGPUThreadPriority(device?.Object, priority);
        public static void SetGPUThreadPriority(this ComObject<IDXGIDevice4> device, int priority) => SetGPUThreadPriority(device?.Object, priority);
        public static void SetGPUThreadPriority(this IDXGIDevice device, int priority)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.SetGPUThreadPriority(priority).ThrowOnError();
        }

        public static int GetMaximumFrameLatency(this ComObject<IDXGIDevice1> device) => GetMaximumFrameLatency(device?.Object);
        public static int GetMaximumFrameLatency(this ComObject<IDXGIDevice2> device) => GetMaximumFrameLatency(device?.Object);
        public static int GetMaximumFrameLatency(this ComObject<IDXGIDevice3> device) => GetMaximumFrameLatency(device?.Object);
        public static int GetMaximumFrameLatency(this ComObject<IDXGIDevice4> device) => GetMaximumFrameLatency(device?.Object);
        public static int GetMaximumFrameLatency(this IDXGIDevice1 device)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.GetMaximumFrameLatency(out int latency).ThrowOnError();
            return latency;
        }

        public static void SetMaximumFrameLatency(this ComObject<IDXGIDevice1> device, int latency) => SetMaximumFrameLatency(device?.Object, latency);
        public static void SetMaximumFrameLatency(this ComObject<IDXGIDevice2> device, int latency) => SetMaximumFrameLatency(device?.Object, latency);
        public static void SetMaximumFrameLatency(this ComObject<IDXGIDevice3> device, int latency) => SetMaximumFrameLatency(device?.Object, latency);
        public static void SetMaximumFrameLatency(this ComObject<IDXGIDevice4> device, int latency) => SetMaximumFrameLatency(device?.Object, latency);
        public static void SetMaximumFrameLatency(this IDXGIDevice1 device, int latency)
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device.SetMaximumFrameLatency(latency).ThrowOnError();
        }

        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this ComObject<IDXGIDevice> device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>(device?.Object, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this ComObject<IDXGIDevice1> device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>(device?.Object, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this ComObject<IDXGIDevice2> device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>(device?.Object, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this ComObject<IDXGIDevice3> device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>(device?.Object, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this ComObject<IDXGIDevice4> device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>(device?.Object, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(this IDXGIDevice device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain => CreateSwapChain<T>((object)device, desc);
        public static ComObject<IDXGISwapChain> CreateSwapChain<T>(object device, DXGI_SWAP_CHAIN_DESC desc) where T : IDXGISwapChain
        {
            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device = ComObject.Unwrap(device);
            using (var dev = new ComObject<IDXGIDevice>((IDXGIDevice)device))
            {
                using (var adapter = dev.GetAdapter<IDXGIAdapter>())
                {
                    using (var factory = adapter.GetParent<IDXGIFactory1>())
                    {
                        factory.Object.CreateSwapChain(device, ref desc, out IDXGISwapChain sw).ThrowOnError();
                        return new ComObject<IDXGISwapChain>(sw);
                    }
                }
            }
        }
    }
}
